using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using HLAUtilities.Core.Models.Domain;
using HLAUtilities.Core.Services;
using HLAUtilities.Winforms.Forms;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLAUtilities.StartUp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // SkinManager.ApplicationVisualTheme = "Office2016Blue";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetDataLayer();
            UpdateSchema();
            Application.Run(new logonForm());
        }

        private static void SetDataLayer()
        {
            string appDataPath = Environment.CurrentDirectory;
            string connectionString = SQLiteConnectionProvider.GetConnectionString(Path.Combine(appDataPath, "hlautilies.db"));
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
        }

        private static void UpdateSchema()
        {
            XpoDefault.Session.UpdateSchema(new Type[] { typeof(User) });
            XpoDefault.Session.UpdateSchema(new Type[] { typeof(Settings) });
        }

        private static void GlobalExceptionHandler(Exception ex)
        {
            DialogResult result = DialogResult.Abort;

            if (ex != null)
            {
                LoggingService.LogError(ex);

                result = MessageBoxAdv.Show(String.Format("An Unexpected Error has occured!\n\n{0}{1}", ex.Message, ex.StackTrace),
                         "Unexpected Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }


            if (result == DialogResult.Abort)
            {
                MessageBoxAdv.Show("There was an unexpected problem with this application. The application will not close", "HLA Tools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        public static void GlobalUIThreadExceptionHandler(object sender, ThreadExceptionEventArgs ex)
        {
            GlobalExceptionHandler(ex.Exception);
        }

        public static void GlobalNonUIThreadExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            GlobalExceptionHandler(args.ExceptionObject as Exception);
        }

    }
}
