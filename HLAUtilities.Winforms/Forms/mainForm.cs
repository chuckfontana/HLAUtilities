using HLAUtilities.Winforms.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLAUtilities.Winforms.Forms
{
    public partial class mainForm : SfForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainFrameBarManager_ItemClicked(object sender, Syncfusion.Windows.Forms.Tools.XPMenus.BarItemClickedEventArgs args)
        {
            if(args.ClickedBarItem.BarName == "usersBarItem")
            {
                var form = new usersForm();
                form.MdiParent = this;
                form.Show();
                return;
            }

            if (args.ClickedBarItem.BarName == "settingsBarItem")
            {
                var form = new settingsForm();
                form.MdiParent = this;
                form.Show();
                return;
            }

            if (args.ClickedBarItem.BarName == "exitBarItem") Application.Exit();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
