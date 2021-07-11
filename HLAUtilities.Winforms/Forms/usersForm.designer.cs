
namespace HLAUtilities.Winforms.Forms
{
    partial class usersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusBarAdv = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastNameLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lastNameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.firstNameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.firstNameLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.networkIdLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.usersXPCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.networkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv)).BeginInit();
            this.statusBarAdv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersXPCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // unitOfWork
            // 
            this.unitOfWork.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork.LockingOption = DevExpress.Xpo.LockingOption.None;
            this.unitOfWork.AfterBeginTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.unitOfWork_AfterBeginTransaction);
            this.unitOfWork.AfterCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.unitOfWork_AfterCommitTransaction);
            this.unitOfWork.AfterRollbackTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.unitOfWork_AfterRollbackTransaction);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.saveToolStripButton,
            this.cancelToolStripButton,
            this.closeToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.addToolStripButton.Text = "&Add";
            this.addToolStripButton.ToolTipText = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelToolStripButton.Image")));
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.cancelToolStripButton.Text = "&Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.cancelToolStripButton_Click);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.closeToolStripButton.Text = "&Close";
            this.closeToolStripButton.ToolTipText = "Close";
            this.closeToolStripButton.Click += new System.EventHandler(this.closeToolStripButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.usersXPCollection;
            // 
            // statusBarAdv
            // 
            this.statusBarAdv.BeforeTouchSize = new System.Drawing.Size(593, 26);
            this.statusBarAdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarAdv.Controls.Add(this.autoLabel1);
            this.statusBarAdv.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv.Location = new System.Drawing.Point(2, 412);
            this.statusBarAdv.Name = "statusBarAdv";
            this.statusBarAdv.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv.Size = new System.Drawing.Size(593, 26);
            this.statusBarAdv.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv.TabIndex = 5;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(0, 2);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(38, 13);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usersDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxExt3);
            this.groupBox2.Controls.Add(this.networkIdLabel);
            this.groupBox2.Controls.Add(this.firstNameTextBox);
            this.groupBox2.Controls.Add(this.firstNameLabel);
            this.groupBox2.Controls.Add(this.lastNameTextBox);
            this.groupBox2.Controls.Add(this.lastNameLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit User";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(15, 35);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(71, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BeforeTouchSize = new System.Drawing.Size(152, 20);
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersXPCollection, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lastNameTextBox.Location = new System.Drawing.Point(92, 33);
            this.lastNameTextBox.MaxLength = 30;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BeforeTouchSize = new System.Drawing.Size(152, 20);
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersXPCollection, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.firstNameTextBox.Location = new System.Drawing.Point(361, 33);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(284, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(71, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.BeforeTouchSize = new System.Drawing.Size(152, 20);
            this.textBoxExt3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersXPCollection, "NetworkId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxExt3.Location = new System.Drawing.Point(93, 75);
            this.textBoxExt3.MaxLength = 20;
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.Size = new System.Drawing.Size(152, 20);
            this.textBoxExt3.TabIndex = 5;
            // 
            // networkIdLabel
            // 
            this.networkIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkIdLabel.Location = new System.Drawing.Point(15, 77);
            this.networkIdLabel.Name = "networkIdLabel";
            this.networkIdLabel.Size = new System.Drawing.Size(72, 13);
            this.networkIdLabel.TabIndex = 4;
            this.networkIdLabel.Text = "Network ld:";
            // 
            // usersXPCollection
            // 
            this.usersXPCollection.ObjectType = typeof(HLAUtilities.Core.Models.Domain.User);
            this.usersXPCollection.Session = this.unitOfWork;
            // 
            // networkIdDataGridViewTextBoxColumn
            // 
            this.networkIdDataGridViewTextBoxColumn.DataPropertyName = "NetworkId";
            this.networkIdDataGridViewTextBoxColumn.HeaderText = "Network Id";
            this.networkIdDataGridViewTextBoxColumn.Name = "networkIdDataGridViewTextBoxColumn";
            this.networkIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.networkIdDataGridViewTextBoxColumn});
            this.usersDataGridView.DataSource = this.usersXPCollection;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.usersDataGridView.Location = new System.Drawing.Point(15, 19);
            this.usersDataGridView.MultiSelect = false;
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.usersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.ShowCellErrors = false;
            this.usersDataGridView.ShowRowErrors = false;
            this.usersDataGridView.Size = new System.Drawing.Size(528, 150);
            this.usersDataGridView.TabIndex = 0;
            // 
            // usersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBarAdv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "usersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Users Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.usersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv)).EndInit();
            this.statusBarAdv.ResumeLayout(false);
            this.statusBarAdv.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersXPCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.Xpo.XPCollection usersXPCollection;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt lastNameTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lastNameLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel networkIdLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt firstNameTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel firstNameLabel;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkIdDataGridViewTextBoxColumn;
    }
}