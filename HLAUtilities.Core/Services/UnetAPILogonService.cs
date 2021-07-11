using HLAUtilities.Core.Models.Common;
using HLAUtilities.Core.Models.UnetAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HLAUtilities.Core.Services
{
    public static class UnetAPILogonService
    {
        private static readonly HttpClient _httpClient;

        static UnetAPILogonService()
        {
            _httpClient = HttpClientService.GetHttpClient();
            UnetAPILogonService.SetHttpClient();

        }
        private static void SetHttpClient()
        {
            _httpClient.BaseAddress = new Uri(APISettings.Url);
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
            _httpClient.DefaultRequestHeaders.Clear();
        }
        public static async Task<Status> GetBearerToken()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.unos.org/oauth/accesstoken?grant_type=client_credentials");
            request.Headers.Add("Authorization", "Bearer " + APISettings.Token);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var status = new Status();

            try
            {
                var response = await _httpClient.SendAsync(request);
                string json = await response.Content.ReadAsStringAsync();
                var oauth = JsonConvert.DeserializeObject<OAuth>(json);

                if (response.IsSuccessStatusCode)
                {
                    status.OK = true;
                    status.ReturnValue = oauth.AccessToken;
                }

            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex);
                status.ErrorMessage = ex.Message;
            }

            return status;
        }

        public static async Task<OAuthStatus> GetBearerTokenForPasswordProtectedUNetAPI(string userName, string password)
        {
            var oauthStatus = new OAuthStatus() { OK = true, OAuthResponse = new OAuthResponse() };
            string token = APISettings.Token;
            var keyValues = new List<KeyValuePair<string, string>>();
            keyValues.Add(new KeyValuePair<string, string>("username", userName));
            keyValues.Add(new KeyValuePair<string, string>("password", password));

            var request = new HttpRequestMessage(HttpMethod.Post, "oauth/accesstoken?grant_type=password");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.TryAddWithoutValidation("Authorization", token);
            request.Content = new FormUrlEncodedContent(keyValues);

            try
            {
                var response = await _httpClient.SendAsync(request);
                string json = await response.Content.ReadAsStringAsync();

                oauthStatus.OAuthResponse.StatusCode = response.StatusCode;
                oauthStatus.OAuthResponse.DateCreated = DateTime.Now;

                if (response.IsSuccessStatusCode)
                {
                    oauthStatus.OAuthResponse.BearerToken = JsonConvert.DeserializeObject<OAuth>(json).AccessToken;

                }
                else
                {
                    oauthStatus.OAuthResponse.OAuthErrorMessage = JsonConvert.DeserializeObject<OAuthErrorMessage>(json);

                }
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex);
                oauthStatus.OK = false;
                oauthStatus.ErrorMessage = ex.Message;
            }

            return oauthStatus;
        }
    }
}
