using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLAUtilities.Core.Models.Domain
{
    public class Settings :XPObject
    {
        public Settings(Session session) : base(session)
        {
        }

        string apiKey;
        [Size(50)]
        public string APIKey
        {
            get { return this.apiKey; }
            set { SetPropertyValue(nameof(APIKey), ref this.apiKey, value); }
        }

        string apiSecret;
        [Size(50)]
        public string APISecret
        {
            get { return this.apiSecret; }
            set { SetPropertyValue(nameof(apiSecret), ref this.apiSecret, value); }
        }

        string ldapServer;
        [Size(20)]
        public string LDAPServer
        {
            get { return this.ldapServer; }
            set { SetPropertyValue(nameof(LDAPServer), ref this.ldapServer, value); }
        }
    }
}
