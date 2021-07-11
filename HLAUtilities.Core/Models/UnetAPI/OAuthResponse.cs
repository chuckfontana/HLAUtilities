using System;
using System.Net;

namespace HLAUtilities.Core.Models.UnetAPI
{
    public class OAuthResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string BearerToken { get; set; }
        public DateTime DateCreated { get; set; }
        public OAuthErrorMessage OAuthErrorMessage { get; set; }
    }
}
