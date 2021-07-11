using HLAUtilities.Core.Models.UnetAPI;
using HLAUtilities.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HLAUtilities.Test.IntegrationTests
{
    [TestClass]
    public class TestUNOSAPILogin
    {
        [TestMethod]
        public async Task TestGetBearerToken()
        {
            APISettings.Center = "OHUH";
            APISettings.Url = "https://api.unos.org";
            APISettings.Token = Secret.Token;


            OAuthStatus oauthStatus = await UnetAPILogonService.GetBearerTokenForPasswordProtectedUNetAPI(Secret.UserName, Secret.Password + "1");

            if (oauthStatus.OK && oauthStatus.OAuthResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Debug.WriteLine(oauthStatus.OAuthResponse.OAuthErrorMessage.Error);
                Debug.WriteLine(oauthStatus.OAuthResponse.OAuthErrorMessage.ErrorDescription);
                Assert.IsFalse(false);
            }

        }
    }
}
