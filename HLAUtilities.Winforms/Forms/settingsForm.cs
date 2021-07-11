using DevExpress.Xpo;
using HLAUtilities.Core.Models.Domain;
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
    public partial class settingsForm : SfForm
    {
        public settingsForm()
        {
            InitializeComponent();
            this.SetDatasource();
            this.SetButtons();
        }

        private void SetDatasource()
        { 
            var settings = new XPQuery<Settings>(this.unitOfWork).FirstOrDefault();

            if(settings != null)
            {
                this.settingsXPBindingSource.DataSource = settings;
            }
            else
            {
                //This code should only run once when the Settings table is empty.
                settings = new Settings(this.unitOfWork); 
                this.unitOfWork.CommitChanges();
            }
        }

        private void Save()
        {
            this.unitOfWork.CommitChanges();
        }
        private void Cancel()
        {
            this.unitOfWork.ReloadChangedObjects();
        }

        private void unitOfWork_AfterBeginTransaction(object sender, SessionManipulationEventArgs e)
        {
            this.SetButtons();
        }

        private void unitOfWork_AfterCommitTransaction(object sender, SessionManipulationEventArgs e)
        {
            this.SetButtons();
        }

        private void unitOfWork_AfterRollbackTransaction(object sender, SessionManipulationEventArgs e)
        {
            this.SetButtons();
        }

        private void SetButtons()
        {
            if (this.unitOfWork.InTransaction)
            {
                this.saveToolStripButton.Enabled = true;
                this.cancelToolStripButton.Enabled = true;
                this.closeToolStripButton.Enabled = false;

            }
            else
            {
                this.saveToolStripButton.Enabled = false;
                this.cancelToolStripButton.Enabled = false;
                this.closeToolStripButton.Enabled = true;
            }
        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unitOfWork.InTransaction)
            {
                e.Cancel = true;
            }
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBoxAdv.Show("Are you sure you want to save your changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Save();
            }
        }

        private void cancelToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBoxAdv.Show("Are you sure you want to cancel your changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cancel();
            }
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
