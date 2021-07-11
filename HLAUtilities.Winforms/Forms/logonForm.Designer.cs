
namespace HLAUtilities.Winforms.Forms
{
    partial class logonForm
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
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.userNameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.passwordTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBoxExt)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(35, 56);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(73, 13);
            this.autoLabel3.TabIndex = 4;
            this.autoLabel3.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BeforeTouchSize = new System.Drawing.Size(155, 20);
            this.userNameTextBox.Location = new System.Drawing.Point(114, 56);
            this.userNameTextBox.MaxLength = 20;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.userNameTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sfButton2);
            this.groupBox1.Controls.Add(this.sfButton1);
            this.groupBox1.Controls.Add(this.autoLabel1);
            this.groupBox1.Controls.Add(this.passwordTextBoxExt);
            this.groupBox1.Controls.Add(this.autoLabel3);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logon for HLA Utilities";
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sfButton2.Location = new System.Drawing.Point(170, 141);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(96, 28);
            this.sfButton2.TabIndex = 8;
            this.sfButton2.Text = "&Exit";
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sfButton1.Location = new System.Drawing.Point(49, 141);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(96, 28);
            this.sfButton1.TabIndex = 7;
            this.sfButton1.Text = "&Login In";
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(35, 92);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(65, 13);
            this.autoLabel1.TabIndex = 6;
            this.autoLabel1.Text = "Password:";
            // 
            // passwordTextBoxExt
            // 
            this.passwordTextBoxExt.BeforeTouchSize = new System.Drawing.Size(155, 20);
            this.passwordTextBoxExt.Location = new System.Drawing.Point(114, 92);
            this.passwordTextBoxExt.MaxLength = 20;
            this.passwordTextBoxExt.Name = "passwordTextBoxExt";
            this.passwordTextBoxExt.PasswordChar = '*';
            this.passwordTextBoxExt.Size = new System.Drawing.Size(155, 20);
            this.passwordTextBoxExt.TabIndex = 5;
            // 
            // logonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 248);
            this.CloseButtonVisible = false;
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "logonForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Logon";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBoxExt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt userNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt passwordTextBoxExt;
    }
}