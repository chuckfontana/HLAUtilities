using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLAUtilities.Core.Models.UnetAPI
{
    public class OAuthErrorMessage
    {
        [Newtonsoft.Json.JsonProperty("error")]
        public string Error { get; set; }

        [Newtonsoft.Json.JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
