
namespace HLAUtilities.Winforms.Forms
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainFrameBarManager = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.mainToolbar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager, "mainToolbar");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.exitBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.uaToolBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.usersBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.settingsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.statusBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager, "statusToolbar");
            this.staticBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFrameBarManager
            // 
            this.mainFrameBarManager.AllowUserRenaming = false;
            this.mainFrameBarManager.AutoScale = true;
            this.mainFrameBarManager.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager.BarPositionInfo")));
            this.mainFrameBarManager.Bars.Add(this.mainToolbar);
            this.mainFrameBarManager.Bars.Add(this.statusBar);
            this.mainFrameBarManager.Categories.Add("File");
            this.mainFrameBarManager.Categories.Add("Utilities");
            this.mainFrameBarManager.Categories.Add("Maintenance");
            this.mainFrameBarManager.Categories.Add("Status");
            this.mainFrameBarManager.CurrentBaseFormType = "Syncfusion.WinForms.Controls.SfForm";
            this.mainFrameBarManager.EnableMenuMerge = true;
            this.mainFrameBarManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager.Form = this;
            this.mainFrameBarManager.IgnoreWorkingArea = true;
            this.mainFrameBarManager.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.exitBarItem,
            this.parentBarItem2,
            this.uaToolBarItem,
            this.parentBarItem3,
            this.usersBarItem,
            this.settingsBarItem,
            this.staticBarItem});
            this.mainFrameBarManager.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.mainFrameBarManager.ResetCustomization = false;
            this.mainFrameBarManager.ThemeName = "OfficeXP";
            this.mainFrameBarManager.UseBackwardCompatiblity = false;
            this.mainFrameBarManager.ItemClicked += new Syncfusion.Windows.Forms.Tools.XPMenus.BarItemClickedEventHandler(this.mainFrameBarManager_ItemClicked);
            // 
            // mainToolbar
            // 
            this.mainToolbar.BarName = "mainToolbar";
            this.mainToolbar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.mainToolbar.Caption = "mainToolbar";
            this.mainToolbar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem3});
            this.mainToolbar.Manager = this.mainFrameBarManager;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.Customizable = false;
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.IgnoreWorkingArea = true;
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.exitBarItem});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "&File";
            this.parentBarItem1.WrapLength = 20;
            // 
            // exitBarItem
            // 
            this.exitBarItem.BarName = "exitBarItem";
            this.exitBarItem.CategoryIndex = 0;
            this.exitBarItem.Customizable = false;
            this.exitBarItem.ID = "&Exit";
            this.exitBarItem.ShowToolTipInPopUp = false;
            this.exitBarItem.SizeToFit = true;
            this.exitBarItem.Text = "&Exit";
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "&Utilities";
            this.parentBarItem2.IgnoreWorkingArea = true;
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.uaToolBarItem});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "&Utilities";
            this.parentBarItem2.WrapLength = 20;
            // 
            // uaToolBarItem
            // 
            this.uaToolBarItem.BarName = "uaToolBarItem";
            this.uaToolBarItem.CategoryIndex = 1;
            this.uaToolBarItem.ID = "&UA Tool";
            this.uaToolBarItem.ShowToolTipInPopUp = false;
            this.uaToolBarItem.SizeToFit = true;
            this.uaToolBarItem.Text = "&UA Tool";
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.ID = "&Maintenance";
            this.parentBarItem3.IgnoreWorkingArea = true;
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.usersBarItem,
            this.settingsBarItem});
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "&Maintenance";
            this.parentBarItem3.WrapLength = 20;
            // 
            // usersBarItem
            // 
            this.usersBarItem.BarName = "usersBarItem";
            this.usersBarItem.CategoryIndex = 2;
            this.usersBarItem.ID = "&Users";
            this.usersBarItem.ShowToolTipInPopUp = false;
            this.usersBarItem.SizeToFit = true;
            this.usersBarItem.Text = "&Users";
            // 
            // settingsBarItem
            // 
            this.settingsBarItem.BarName = "settingsBarItem";
            this.settingsBarItem.CategoryIndex = 2;
            this.settingsBarItem.ID = "Settings";
            this.settingsBarItem.ShowToolTipInPopUp = false;
            this.settingsBarItem.SizeToFit = true;
            this.settingsBarItem.Text = "Settings";
            // 
            // statusBar
            // 
            this.statusBar.AllowCustomizing = false;
            this.statusBar.AllowHiding = false;
            this.statusBar.BarName = "statusToolbar";
            this.statusBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar)));
            this.statusBar.Caption = "statusToolbar";
            this.statusBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.staticBarItem});
            this.statusBar.Manager = this.mainFrameBarManager;
            // 
            // staticBarItem
            // 
            this.staticBarItem.BarName = "staticBarItem";
            this.staticBarItem.CategoryIndex = 3;
            this.staticBarItem.ID = "readyStaticBarItem";
            this.staticBarItem.ShowToolTipInPopUp = false;
            this.staticBarItem.SizeToFit = true;
            this.staticBarItem.Text = "Ready";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1115, 449);
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "HLA Utilities (Developed by the HLA Tech Club)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar mainToolbar;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem exitBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem uaToolBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem usersBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar statusBar;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem settingsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem staticBarItem;
    }
}