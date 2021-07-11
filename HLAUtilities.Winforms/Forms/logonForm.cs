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
    public partial class logonForm : SfForm
    {
        public logonForm()
        {
            InitializeComponent();
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            var form = new mainForm();
            form.Show();
            this.Visible = false;
        }
    }
}
