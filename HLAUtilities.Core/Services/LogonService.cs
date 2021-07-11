using HLAUtilities.Core.Models.Common;
using System;
using System.DirectoryServices;


namespace HLAUtilities.Core.Services
{
    public static class LogonService
    {
        private static Status Authenticate(string userName, string password, string domain)
        {
            var status = new Status();

            try
            {
                DirectoryEntry de = new DirectoryEntry("LDAP://" + domain, userName, password, AuthenticationTypes.Secure);
                DirectorySearcher dsearch = new DirectorySearcher(de);
                SearchResult results = dsearch.FindOne();
                results = dsearch.FindOne();
                if (results != null) status.OK = true;
            }
            catch (Exception ex)
            {
                LoggingService.LogError(ex);
                status.ErrorMessage = ex.Message;
            }

            return status;
        }
    }
}
