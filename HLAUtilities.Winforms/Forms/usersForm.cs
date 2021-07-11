using DevExpress.Xpo;
using HLAUtilities.Core.Models.Domain;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Windows.Forms;

namespace HLAUtilities.Winforms.Forms
{
    public partial class usersForm : SfForm
    {
        public usersForm()
        {
            InitializeComponent();
            this.SetButtons();
        }

        private void Add()
        {
            var user = new User(this.unitOfWork);
            this.usersXPCollection.Add(user);
            int lastRow = this.usersDataGridView.Rows.GetLastRow(DataGridViewElementStates.Visible);
            this.usersDataGridView.CurrentCell = this.usersDataGridView[0, lastRow];
            this.usersDataGridView.Columns[0].Selected = false;
            this.lastNameTextBox.Focus();

        }

        private void ResetUnitOfWork()
        {
            this.unitOfWork.RollbackTransaction();
            this.unitOfWork = new UnitOfWork();
            this.usersXPCollection.Session = this.unitOfWork;
            this.unitOfWork.AfterBeginTransaction += unitOfWork_AfterBeginTransaction;
            this.unitOfWork.AfterCommitTransaction += unitOfWork_AfterCommitTransaction;
            this.unitOfWork.AfterRollbackTransaction += unitOfWork_AfterRollbackTransaction;
        }
        private void Save()
        {
           //this.usersDataGridView.EndEdit();
            this.unitOfWork.CommitChanges();
        }
        private void Cancel()
        {
            this.ResetUnitOfWork();
            this.usersXPCollection.Reload();
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
                this.addToolStripButton.Enabled = false;
                this.saveToolStripButton.Enabled = true;
                this.cancelToolStripButton.Enabled = true;
                this.closeToolStripButton.Enabled = false;

            }
            else
            {
                this.addToolStripButton.Enabled = true;
                this.saveToolStripButton.Enabled = false;
                this.cancelToolStripButton.Enabled = false;
                this.closeToolStripButton.Enabled = true;
            }
        }

        private void usersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unitOfWork.InTransaction)
            {
                e.Cancel = true;
            }
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            this.Add();
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
