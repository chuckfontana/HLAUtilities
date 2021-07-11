using HLAUtilities.Core.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HLAUtilities.Core.Services
{
    public static class LoggingService
    {
        public static bool LogError(Exception ex)
        {
            string message = LoggingService.CreateMessage(ex);
            bool returnValue = false;
            StreamWriter streamWriter = null;
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(message + Environment.NewLine);
                    streamWriter.Flush();
                }

                returnValue = true;
            }

            return returnValue;
        }

        private static string CreateMessage(Exception ex)
        {
            string userName = "N/A";

            if (AppHelper.CurrentUser != null)
            {
                if (String.IsNullOrEmpty(AppHelper.CurrentUser.NetworkId))
                {
                    userName = AppHelper.CurrentUser.NetworkId;
                }
            }

            return DateTime.Now + " " + userName + " " + ex.Message + "  " + ex.GetType()
                   + Environment.NewLine + ex.StackTrace + Environment.NewLine;
        }
    }
}
