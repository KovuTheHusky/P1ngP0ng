namespace P1ngP0ng
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tab = new System.Windows.Forms.TabControl();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.groupFailure = new System.Windows.Forms.GroupBox();
            this.listFailure = new System.Windows.Forms.ListView();
            this.columnTime2 = new System.Windows.Forms.ColumnHeader();
            this.columnAddress2 = new System.Windows.Forms.ColumnHeader();
            this.columnWhy2 = new System.Windows.Forms.ColumnHeader();
            this.groupSuccess = new System.Windows.Forms.GroupBox();
            this.listSuccess = new System.Windows.Forms.ListView();
            this.columnTime1 = new System.Windows.Forms.ColumnHeader();
            this.columnAddress1 = new System.Windows.Forms.ColumnHeader();
            this.columnTtl1 = new System.Windows.Forms.ColumnHeader();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.pictureEasterEgg = new System.Windows.Forms.PictureBox();
            this.labelEasterEgg = new System.Windows.Forms.Label();
            this.groupGlossary = new System.Windows.Forms.GroupBox();
            this.labelIntervalDef = new System.Windows.Forms.Label();
            this.labelPingDef = new System.Windows.Forms.Label();
            this.groupAbout = new System.Windows.Forms.GroupBox();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.labelCredits = new System.Windows.Forms.Label();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.toolAddressLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolAddressCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolDivider1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolIntervalLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolIntervalCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolDivider2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStart = new System.Windows.Forms.ToolStripButton();
            this.toolStop = new System.Windows.Forms.ToolStripButton();
            this.toolDivider3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolClear = new System.Windows.Forms.ToolStripDropDownButton();
            this.clearAllHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSuccessHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFailureHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDivider4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tab.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.groupFailure.SuspendLayout();
            this.groupSuccess.SuspendLayout();
            this.tabHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEasterEgg)).BeginInit();
            this.groupGlossary.SuspendLayout();
            this.groupAbout.SuspendLayout();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabHistory);
            this.tab.Controls.Add(this.tabHelp);
            this.tab.Location = new System.Drawing.Point(0, 28);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(724, 336);
            this.tab.TabIndex = 2;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.groupFailure);
            this.tabHistory.Controls.Add(this.groupSuccess);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(716, 310);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // groupFailure
            // 
            this.groupFailure.Controls.Add(this.listFailure);
            this.groupFailure.Location = new System.Drawing.Point(363, 6);
            this.groupFailure.Name = "groupFailure";
            this.groupFailure.Size = new System.Drawing.Size(350, 296);
            this.groupFailure.TabIndex = 3;
            this.groupFailure.TabStop = false;
            this.groupFailure.Text = "Failure";
            // 
            // listFailure
            // 
            this.listFailure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime2,
            this.columnAddress2,
            this.columnWhy2});
            this.listFailure.FullRowSelect = true;
            this.listFailure.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listFailure.Location = new System.Drawing.Point(6, 19);
            this.listFailure.MultiSelect = false;
            this.listFailure.Name = "listFailure";
            this.listFailure.Size = new System.Drawing.Size(338, 271);
            this.listFailure.TabIndex = 1;
            this.listFailure.UseCompatibleStateImageBehavior = false;
            this.listFailure.View = System.Windows.Forms.View.Details;
            this.listFailure.DoubleClick += new System.EventHandler(this.listFailure_DoubleClick);
            this.listFailure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Failure_KeyDown);
            // 
            // columnTime2
            // 
            this.columnTime2.Text = "Time";
            this.columnTime2.Width = 130;
            // 
            // columnAddress2
            // 
            this.columnAddress2.Text = "Address";
            this.columnAddress2.Width = 130;
            // 
            // columnWhy2
            // 
            this.columnWhy2.Text = "?";
            this.columnWhy2.Width = 70;
            // 
            // groupSuccess
            // 
            this.groupSuccess.Controls.Add(this.listSuccess);
            this.groupSuccess.Location = new System.Drawing.Point(3, 6);
            this.groupSuccess.Name = "groupSuccess";
            this.groupSuccess.Size = new System.Drawing.Size(350, 296);
            this.groupSuccess.TabIndex = 2;
            this.groupSuccess.TabStop = false;
            this.groupSuccess.Text = "Success";
            // 
            // listSuccess
            // 
            this.listSuccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime1,
            this.columnAddress1,
            this.columnTtl1});
            this.listSuccess.FullRowSelect = true;
            this.listSuccess.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listSuccess.Location = new System.Drawing.Point(5, 19);
            this.listSuccess.MultiSelect = false;
            this.listSuccess.Name = "listSuccess";
            this.listSuccess.Size = new System.Drawing.Size(339, 271);
            this.listSuccess.TabIndex = 0;
            this.listSuccess.UseCompatibleStateImageBehavior = false;
            this.listSuccess.View = System.Windows.Forms.View.Details;
            this.listSuccess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Success_KeyDown);
            // 
            // columnTime1
            // 
            this.columnTime1.Text = "Time";
            this.columnTime1.Width = 130;
            // 
            // columnAddress1
            // 
            this.columnAddress1.Text = "Address";
            this.columnAddress1.Width = 130;
            // 
            // columnTtl1
            // 
            this.columnTtl1.Text = "TTL";
            this.columnTtl1.Width = 70;
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.pictureEasterEgg);
            this.tabHelp.Controls.Add(this.labelEasterEgg);
            this.tabHelp.Controls.Add(this.groupGlossary);
            this.tabHelp.Controls.Add(this.groupAbout);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(716, 310);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // pictureEasterEgg
            // 
            this.pictureEasterEgg.Image = global::P1ngP0ng.Properties.Resources.furry;
            this.pictureEasterEgg.InitialImage = global::P1ngP0ng.Properties.Resources.furry;
            this.pictureEasterEgg.Location = new System.Drawing.Point(309, 82);
            this.pictureEasterEgg.Name = "pictureEasterEgg";
            this.pictureEasterEgg.Size = new System.Drawing.Size(400, 220);
            this.pictureEasterEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureEasterEgg.TabIndex = 9;
            this.pictureEasterEgg.TabStop = false;
            this.pictureEasterEgg.Visible = false;
            // 
            // labelEasterEgg
            // 
            this.labelEasterEgg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEasterEgg.Location = new System.Drawing.Point(684, 277);
            this.labelEasterEgg.Name = "labelEasterEgg";
            this.labelEasterEgg.Size = new System.Drawing.Size(25, 25);
            this.labelEasterEgg.TabIndex = 8;
            this.labelEasterEgg.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelEasterEgg.Click += new System.EventHandler(this.labelEasterEgg_Click);
            // 
            // groupGlossary
            // 
            this.groupGlossary.Controls.Add(this.labelIntervalDef);
            this.groupGlossary.Controls.Add(this.labelPingDef);
            this.groupGlossary.Location = new System.Drawing.Point(309, 6);
            this.groupGlossary.Name = "groupGlossary";
            this.groupGlossary.Size = new System.Drawing.Size(400, 70);
            this.groupGlossary.TabIndex = 7;
            this.groupGlossary.TabStop = false;
            this.groupGlossary.Text = "Glossary";
            // 
            // labelIntervalDef
            // 
            this.labelIntervalDef.Location = new System.Drawing.Point(6, 51);
            this.labelIntervalDef.Name = "labelIntervalDef";
            this.labelIntervalDef.Size = new System.Drawing.Size(387, 13);
            this.labelIntervalDef.TabIndex = 1;
            this.labelIntervalDef.Text = "Interval: The amount of time to wait in between each ping.";
            // 
            // labelPingDef
            // 
            this.labelPingDef.Location = new System.Drawing.Point(6, 16);
            this.labelPingDef.Name = "labelPingDef";
            this.labelPingDef.Size = new System.Drawing.Size(387, 26);
            this.labelPingDef.TabIndex = 0;
            this.labelPingDef.Text = "Ping: A small packet of data that is sent round-trip from your computer, then to " +
                "a host, and then back to your computer. It measures connectivity and speed.";
            // 
            // groupAbout
            // 
            this.groupAbout.Controls.Add(this.linkWebsite);
            this.groupAbout.Controls.Add(this.labelCredits);
            this.groupAbout.Location = new System.Drawing.Point(3, 6);
            this.groupAbout.Name = "groupAbout";
            this.groupAbout.Size = new System.Drawing.Size(300, 296);
            this.groupAbout.TabIndex = 6;
            this.groupAbout.TabStop = false;
            this.groupAbout.Text = "About";
            // 
            // linkWebsite
            // 
            this.linkWebsite.AutoSize = true;
            this.linkWebsite.Location = new System.Drawing.Point(6, 104);
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.Size = new System.Drawing.Size(147, 13);
            this.linkWebsite.TabIndex = 1;
            this.linkWebsite.TabStop = true;
            this.linkWebsite.Text = "http://www.huskehlabs.com/";
            this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
            // 
            // labelCredits
            // 
            this.labelCredits.Location = new System.Drawing.Point(6, 16);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(288, 78);
            this.labelCredits.TabIndex = 0;
            this.labelCredits.Text = resources.GetString("labelCredits.Text");
            // 
            // tool
            // 
            this.tool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddressLabel,
            this.toolAddressCombo,
            this.toolDivider1,
            this.toolIntervalLabel,
            this.toolIntervalCombo,
            this.toolDivider2,
            this.toolStart,
            this.toolStop,
            this.toolDivider3,
            this.toolClear,
            this.toolDivider4,
            this.toolOptions});
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tool.Size = new System.Drawing.Size(724, 25);
            this.tool.TabIndex = 4;
            this.tool.Text = "tool";
            // 
            // toolAddressLabel
            // 
            this.toolAddressLabel.Name = "toolAddressLabel";
            this.toolAddressLabel.Size = new System.Drawing.Size(86, 22);
            this.toolAddressLabel.Text = "Address to ping:";
            // 
            // toolAddressCombo
            // 
            this.toolAddressCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolAddressCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolAddressCombo.Name = "toolAddressCombo";
            this.toolAddressCombo.Size = new System.Drawing.Size(170, 25);
            this.toolAddressCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_KeyDown);
            // 
            // toolDivider1
            // 
            this.toolDivider1.Name = "toolDivider1";
            this.toolDivider1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolIntervalLabel
            // 
            this.toolIntervalLabel.Name = "toolIntervalLabel";
            this.toolIntervalLabel.Size = new System.Drawing.Size(82, 22);
            this.toolIntervalLabel.Text = "Interval to use:";
            // 
            // toolIntervalCombo
            // 
            this.toolIntervalCombo.Name = "toolIntervalCombo";
            this.toolIntervalCombo.Size = new System.Drawing.Size(100, 25);
            this.toolIntervalCombo.Text = "1000";
            this.toolIntervalCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Interval_KeyDown);
            // 
            // toolDivider2
            // 
            this.toolDivider2.Name = "toolDivider2";
            this.toolDivider2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStart
            // 
            this.toolStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStart.Image = global::P1ngP0ng.Properties.Resources.media_play_green;
            this.toolStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStart.Name = "toolStart";
            this.toolStart.Size = new System.Drawing.Size(23, 22);
            this.toolStart.Text = "toolStripButton1";
            this.toolStart.ToolTipText = "Start";
            this.toolStart.Click += new System.EventHandler(this.toolStart_Click);
            // 
            // toolStop
            // 
            this.toolStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStop.Enabled = false;
            this.toolStop.Image = global::P1ngP0ng.Properties.Resources.media_stop_red;
            this.toolStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStop.Name = "toolStop";
            this.toolStop.Size = new System.Drawing.Size(23, 22);
            this.toolStop.Text = "toolStripButton2";
            this.toolStop.ToolTipText = "Stop";
            this.toolStop.Click += new System.EventHandler(this.toolStop_Click);
            // 
            // toolDivider3
            // 
            this.toolDivider3.Name = "toolDivider3";
            this.toolDivider3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolClear
            // 
            this.toolClear.AutoToolTip = false;
            this.toolClear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllHistory,
            this.clearSuccessHistory,
            this.clearFailureHistory});
            this.toolClear.Image = global::P1ngP0ng.Properties.Resources.delete2;
            this.toolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClear.Name = "toolClear";
            this.toolClear.Size = new System.Drawing.Size(61, 22);
            this.toolClear.Text = "Clear";
            // 
            // clearAllHistory
            // 
            this.clearAllHistory.Name = "clearAllHistory";
            this.clearAllHistory.Size = new System.Drawing.Size(188, 22);
            this.clearAllHistory.Text = "Clear All History";
            this.clearAllHistory.Click += new System.EventHandler(this.clearAllHistory_Click);
            // 
            // clearSuccessHistory
            // 
            this.clearSuccessHistory.Name = "clearSuccessHistory";
            this.clearSuccessHistory.Size = new System.Drawing.Size(188, 22);
            this.clearSuccessHistory.Text = "Clear Success History";
            this.clearSuccessHistory.Click += new System.EventHandler(this.clearSuccessHistory_Click);
            // 
            // clearFailureHistory
            // 
            this.clearFailureHistory.Name = "clearFailureHistory";
            this.clearFailureHistory.Size = new System.Drawing.Size(188, 22);
            this.clearFailureHistory.Text = "Clear Failure History";
            this.clearFailureHistory.Click += new System.EventHandler(this.clearFailureHistory_Click);
            // 
            // toolDivider4
            // 
            this.toolDivider4.Name = "toolDivider4";
            this.toolDivider4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolOptions
            // 
            this.toolOptions.AutoToolTip = false;
            this.toolOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolAbout});
            this.toolOptions.Image = global::P1ngP0ng.Properties.Resources.gear;
            this.toolOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(73, 22);
            this.toolOptions.Text = "Options";
            // 
            // toolSave
            // 
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(152, 22);
            this.toolSave.Text = "Save Records";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            this.saveFile.Filter = "Text Documents (*.txt)|*.txt";
            this.saveFile.SupportMultiDottedExtensions = true;
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // toolAbout
            // 
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(152, 22);
            this.toolAbout.Text = "About";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 364);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "P1ngP0ng";
            this.tab.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.groupFailure.ResumeLayout(false);
            this.groupSuccess.ResumeLayout(false);
            this.tabHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEasterEgg)).EndInit();
            this.groupGlossary.ResumeLayout(false);
            this.groupAbout.ResumeLayout(false);
            this.groupAbout.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.GroupBox groupAbout;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripLabel toolAddressLabel;
        private System.Windows.Forms.ToolStripComboBox toolAddressCombo;
        private System.Windows.Forms.ToolStripButton toolStart;
        private System.Windows.Forms.ToolStripButton toolStop;
        private System.Windows.Forms.ToolStripLabel toolIntervalLabel;
        private System.Windows.Forms.ToolStripComboBox toolIntervalCombo;
        private System.Windows.Forms.ToolStripDropDownButton toolClear;
        private System.Windows.Forms.ToolStripSeparator toolDivider1;
        private System.Windows.Forms.ToolStripSeparator toolDivider2;
        private System.Windows.Forms.ToolStripSeparator toolDivider3;
        private System.Windows.Forms.ListView listSuccess;
        private System.Windows.Forms.ColumnHeader columnTime1;
        private System.Windows.Forms.ColumnHeader columnAddress1;
        private System.Windows.Forms.ColumnHeader columnTtl1;
        private System.Windows.Forms.ListView listFailure;
        private System.Windows.Forms.ColumnHeader columnTime2;
        private System.Windows.Forms.ColumnHeader columnAddress2;
        private System.Windows.Forms.ColumnHeader columnWhy2;
        private System.Windows.Forms.ToolStripMenuItem clearAllHistory;
        private System.Windows.Forms.ToolStripMenuItem clearSuccessHistory;
        private System.Windows.Forms.ToolStripMenuItem clearFailureHistory;
        private System.Windows.Forms.GroupBox groupSuccess;
        private System.Windows.Forms.GroupBox groupFailure;
        private System.Windows.Forms.GroupBox groupGlossary;
        private System.Windows.Forms.Label labelPingDef;
        private System.Windows.Forms.Label labelIntervalDef;
        private System.Windows.Forms.Label labelEasterEgg;
        private System.Windows.Forms.PictureBox pictureEasterEgg;
        private System.Windows.Forms.ToolStripSeparator toolDivider4;
        private System.Windows.Forms.ToolStripDropDownButton toolOptions;
        private System.Windows.Forms.ToolStripMenuItem toolSave;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripMenuItem toolAbout;
    }
}

