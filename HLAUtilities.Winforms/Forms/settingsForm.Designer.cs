
namespace HLAUtilities.Winforms.Forms
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.apiSecretTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.settingsXPBindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.apiKeyTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.adC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.adDomianTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusBarAdv = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apiSecretTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsXPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apiKeyTextBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDomianTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv)).BeginInit();
            this.statusBarAdv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoLabel6);
            this.groupBox1.Controls.Add(this.apiSecretTextBox);
            this.groupBox1.Controls.Add(this.autoLabel5);
            this.groupBox1.Controls.Add(this.apiKeyTextBox);
            this.groupBox1.Controls.Add(this.autoLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos API Keys";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.Location = new System.Drawing.Point(26, 90);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(68, 13);
            this.autoLabel6.TabIndex = 8;
            this.autoLabel6.Text = "API Secret";
            // 
            // apiSecretTextBox
            // 
            this.apiSecretTextBox.BeforeTouchSize = new System.Drawing.Size(141, 20);
            this.apiSecretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsXPBindingSource, "APISecret", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.apiSecretTextBox.Location = new System.Drawing.Point(26, 106);
            this.apiSecretTextBox.MaxLength = 50;
            this.apiSecretTextBox.Name = "apiSecretTextBox";
            this.apiSecretTextBox.PasswordChar = '*';
            this.apiSecretTextBox.Size = new System.Drawing.Size(327, 20);
            this.apiSecretTextBox.TabIndex = 7;
            // 
            // settingsXPBindingSource
            // 
            this.settingsXPBindingSource.ObjectType = typeof(HLAUtilities.Core.Models.Domain.Settings);
            // 
            // autoLabel5
            // 
            this.autoLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.Location = new System.Drawing.Point(27, 39);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(52, 13);
            this.autoLabel5.TabIndex = 6;
            this.autoLabel5.Text = "API Key";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.BeforeTouchSize = new System.Drawing.Size(141, 20);
            this.apiKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsXPBindingSource, "APIKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.apiKeyTextBox.Location = new System.Drawing.Point(27, 55);
            this.apiKeyTextBox.MaxLength = 50;
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.PasswordChar = '*';
            this.apiKeyTextBox.Size = new System.Drawing.Size(327, 20);
            this.apiKeyTextBox.TabIndex = 5;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(121, 52);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(0, 13);
            this.autoLabel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.autoLabel4);
            this.groupBox2.Controls.Add(this.adC);
            this.groupBox2.Controls.Add(this.autoLabel3);
            this.groupBox2.Controls.Add(this.adDomianTextBox);
            this.groupBox2.Controls.Add(this.autoLabel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active Directory Settings";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.Location = new System.Drawing.Point(26, 95);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(128, 13);
            this.autoLabel4.TabIndex = 4;
            this.autoLabel4.Text = "AD Domain Controller";
            this.autoLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adC
            // 
            this.adC.BeforeTouchSize = new System.Drawing.Size(141, 20);
            this.adC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsXPBindingSource, "ActiveDirectoryDomainController", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adC.Location = new System.Drawing.Point(26, 111);
            this.adC.MaxLength = 100;
            this.adC.Name = "adC";
            this.adC.Size = new System.Drawing.Size(400, 20);
            this.adC.TabIndex = 3;
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(26, 38);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(70, 13);
            this.autoLabel3.TabIndex = 2;
            this.autoLabel3.Text = "AD Domain";
            // 
            // adDomianTextBox
            // 
            this.adDomianTextBox.BeforeTouchSize = new System.Drawing.Size(141, 20);
            this.adDomianTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsXPBindingSource, "ActiveDirectoryDomain", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adDomianTextBox.Location = new System.Drawing.Point(26, 54);
            this.adDomianTextBox.MaxLength = 20;
            this.adDomianTextBox.Name = "adDomianTextBox";
            this.adDomianTextBox.Size = new System.Drawing.Size(141, 20);
            this.adDomianTextBox.TabIndex = 1;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(83, 42);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(0, 13);
            this.autoLabel2.TabIndex = 0;
            // 
            // unitOfWork
            // 
            this.unitOfWork.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork.AfterBeginTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.unitOfWork_AfterBeginTransaction);
            this.unitOfWork.AfterCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.unitOfWork_AfterCommitTransaction);
            this.unitOfWork.AfterRollbackTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.unitOfWork_AfterRollbackTransaction);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.cancelToolStripButton,
            this.closeToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(473, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            // statusBarAdv
            // 
            this.statusBarAdv.BeforeTouchSize = new System.Drawing.Size(473, 26);
            this.statusBarAdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarAdv.Controls.Add(this.autoLabel7);
            this.statusBarAdv.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv.Location = new System.Drawing.Point(2, 422);
            this.statusBarAdv.Name = "statusBarAdv";
            this.statusBarAdv.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv.Size = new System.Drawing.Size(473, 26);
            this.statusBarAdv.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv.TabIndex = 6;
            // 
            // autoLabel7
            // 
            this.autoLabel7.Location = new System.Drawing.Point(0, 2);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(38, 13);
            this.autoLabel7.TabIndex = 0;
            this.autoLabel7.Text = "Ready";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.statusBarAdv);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apiSecretTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsXPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apiKeyTextBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDomianTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv)).EndInit();
            this.statusBarAdv.ResumeLayout(false);
            this.statusBarAdv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt adDomianTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt adC;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt apiKeyTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt apiSecretTextBox;
        private DevExpress.Xpo.XPBindingSource settingsXPBindingSource;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
    }
}