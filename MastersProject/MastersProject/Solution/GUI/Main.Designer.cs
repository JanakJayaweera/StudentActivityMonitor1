namespace MastersProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnPause = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.tabPaneMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainerControlApplications = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlApplications = new DevExpress.XtraGrid.GridControl();
            this.gridViewApplications = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSession = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMain)).BeginInit();
            this.tabPaneMain.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlApplications)).BeginInit();
            this.splitContainerControlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabPaneMain);
            this.splitContainerMain.Size = new System.Drawing.Size(1052, 429);
            this.splitContainerMain.SplitterDistance = 40;
            this.splitContainerMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.ImageOptions.Image")));
            this.btnStop.Location = new System.Drawing.Point(1023, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(24, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.ImageOptions.Image")));
            this.btnPause.Location = new System.Drawing.Point(993, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(24, 23);
            this.btnPause.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.Location = new System.Drawing.Point(963, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(24, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabPaneMain
            // 
            this.tabPaneMain.Controls.Add(this.tabNavigationPage1);
            this.tabPaneMain.Controls.Add(this.tabNavigationPage2);
            this.tabPaneMain.Location = new System.Drawing.Point(0, 3);
            this.tabPaneMain.Name = "tabPaneMain";
            this.tabPaneMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPaneMain.RegularSize = new System.Drawing.Size(1052, 365);
            this.tabPaneMain.SelectedPage = this.tabNavigationPage1;
            this.tabPaneMain.Size = new System.Drawing.Size(1052, 365);
            this.tabPaneMain.TabIndex = 1;
            this.tabPaneMain.Text = "tabPaneName";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Applications";
            this.tabNavigationPage1.Controls.Add(this.splitContainerControlApplications);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1052, 338);
            // 
            // splitContainerControlApplications
            // 
            this.splitContainerControlApplications.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerControlApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlApplications.IsSplitterFixed = true;
            this.splitContainerControlApplications.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlApplications.Name = "splitContainerControlApplications";
            this.splitContainerControlApplications.Panel1.Controls.Add(this.gridControlApplications);
            this.splitContainerControlApplications.Panel1.Text = "Panel1";
            this.splitContainerControlApplications.Panel2.Text = "Panel2";
            this.splitContainerControlApplications.Size = new System.Drawing.Size(1052, 338);
            this.splitContainerControlApplications.SplitterPosition = 413;
            this.splitContainerControlApplications.TabIndex = 0;
            // 
            // gridControlApplications
            // 
            this.gridControlApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlApplications.Location = new System.Drawing.Point(0, 0);
            this.gridControlApplications.MainView = this.gridViewApplications;
            this.gridControlApplications.Name = "gridControlApplications";
            this.gridControlApplications.Size = new System.Drawing.Size(413, 338);
            this.gridControlApplications.TabIndex = 0;
            this.gridControlApplications.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewApplications});
            // 
            // gridViewApplications
            // 
            this.gridViewApplications.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnTime,
            this.gridColumnSession});
            this.gridViewApplications.GridControl = this.gridControlApplications;
            this.gridViewApplications.Name = "gridViewApplications";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 185;
            // 
            // gridColumnTime
            // 
            this.gridColumnTime.Caption = "Time";
            this.gridColumnTime.FieldName = "Time";
            this.gridColumnTime.Name = "gridColumnTime";
            this.gridColumnTime.Visible = true;
            this.gridColumnTime.VisibleIndex = 1;
            this.gridColumnTime.Width = 154;
            // 
            // gridColumnSession
            // 
            this.gridColumnSession.Caption = "Session";
            this.gridColumnSession.FieldName = "Session";
            this.gridColumnSession.Name = "gridColumnSession";
            this.gridColumnSession.Visible = true;
            this.gridColumnSession.VisibleIndex = 2;
            this.gridColumnSession.Width = 56;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(300, 150);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 429);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMain)).EndInit();
            this.tabPaneMain.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlApplications)).EndInit();
            this.splitContainerControlApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlApplications;
        private DevExpress.XtraGrid.GridControl gridControlApplications;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewApplications;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTime;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnPause;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSession;
    }
}

