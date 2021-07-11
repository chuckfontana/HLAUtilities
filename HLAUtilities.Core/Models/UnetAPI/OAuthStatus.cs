using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLAUtilities.Core.Models.UnetAPI
{
    public class OAuthStatus
    {
        public bool OK { get; set; }
        public string ErrorMessage { get; set; }
        public OAuthResponse OAuthResponse { get; set; }
    }
}
