namespace Grabber {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspbFileProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pExtentionsChoose = new System.Windows.Forms.Panel();
            this.rbDontDownload = new System.Windows.Forms.RadioButton();
            this.rbDownload = new System.Windows.Forms.RadioButton();
            this.btDownload = new System.Windows.Forms.Button();
            this.tbExtentions = new System.Windows.Forms.TextBox();
            this.lbExtentionsInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLoadPages = new System.Windows.Forms.Button();
            this.nudPageTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPageFrom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvFilesList = new System.Windows.Forms.ListView();
            this.chForDownload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotalDownloads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsFilesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertCheckingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.removeCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pExtentionsChoose.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cmsFilesList.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbFileProgress,
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspbFileProgress
            // 
            this.tspbFileProgress.Name = "tspbFileProgress";
            this.tspbFileProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(38, 17);
            this.lbStatus.Text = "status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveListToolStripMenuItem,
            this.loadListToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saveListToolStripMenuItem.Text = "Save list";
            // 
            // loadListToolStripMenuItem
            // 
            this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
            this.loadListToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.loadListToolStripMenuItem.Text = "Load list";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(115, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pExtentionsChoose);
            this.groupBox5.Controls.Add(this.btDownload);
            this.groupBox5.Controls.Add(this.tbExtentions);
            this.groupBox5.Controls.Add(this.lbExtentionsInfo);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 180);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Download";
            // 
            // pExtentionsChoose
            // 
            this.pExtentionsChoose.Controls.Add(this.rbDontDownload);
            this.pExtentionsChoose.Controls.Add(this.rbDownload);
            this.pExtentionsChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pExtentionsChoose.Enabled = false;
            this.pExtentionsChoose.Location = new System.Drawing.Point(3, 16);
            this.pExtentionsChoose.Name = "pExtentionsChoose";
            this.pExtentionsChoose.Size = new System.Drawing.Size(171, 46);
            this.pExtentionsChoose.TabIndex = 5;
            // 
            // rbDontDownload
            // 
            this.rbDontDownload.AutoSize = true;
            this.rbDontDownload.Location = new System.Drawing.Point(7, 26);
            this.rbDontDownload.Name = "rbDontDownload";
            this.rbDontDownload.Size = new System.Drawing.Size(157, 17);
            this.rbDontDownload.TabIndex = 3;
            this.rbDontDownload.Text = "Do not download extentions";
            this.rbDontDownload.UseVisualStyleBackColor = true;
            this.rbDontDownload.CheckedChanged += new System.EventHandler(this.rbDontDownload_CheckedChanged);
            // 
            // rbDownload
            // 
            this.rbDownload.AutoSize = true;
            this.rbDownload.Checked = true;
            this.rbDownload.Location = new System.Drawing.Point(7, 3);
            this.rbDownload.Name = "rbDownload";
            this.rbDownload.Size = new System.Drawing.Size(124, 17);
            this.rbDownload.TabIndex = 2;
            this.rbDownload.TabStop = true;
            this.rbDownload.Text = "Download extentions";
            this.rbDownload.UseVisualStyleBackColor = true;
            this.rbDownload.CheckedChanged += new System.EventHandler(this.rbDownload_CheckedChanged);
            // 
            // btDownload
            // 
            this.btDownload.Location = new System.Drawing.Point(9, 149);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(161, 23);
            this.btDownload.TabIndex = 4;
            this.btDownload.Text = "Download";
            this.btDownload.UseVisualStyleBackColor = true;
            this.btDownload.Click += new System.EventHandler(this.BtDownload_Click);
            // 
            // tbExtentions
            // 
            this.tbExtentions.Location = new System.Drawing.Point(9, 123);
            this.tbExtentions.Name = "tbExtentions";
            this.tbExtentions.Size = new System.Drawing.Size(161, 20);
            this.tbExtentions.TabIndex = 3;
            this.tbExtentions.TextChanged += new System.EventHandler(this.TbExtentions_TextChanged);
            // 
            // lbExtentionsInfo
            // 
            this.lbExtentionsInfo.AutoSize = true;
            this.lbExtentionsInfo.Location = new System.Drawing.Point(9, 68);
            this.lbExtentionsInfo.Name = "lbExtentionsInfo";
            this.lbExtentionsInfo.Size = new System.Drawing.Size(105, 52);
            this.lbExtentionsInfo.TabIndex = 2;
            this.lbExtentionsInfo.Text = "Set extentions \r\n(empty if dont use)\r\n(separate by comma)\r\n(jpg,txt,zip)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLoadPages);
            this.groupBox2.Controls.Add(this.nudPageTo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudPageFrom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pages range";
            // 
            // btLoadPages
            // 
            this.btLoadPages.Location = new System.Drawing.Point(9, 42);
            this.btLoadPages.Name = "btLoadPages";
            this.btLoadPages.Size = new System.Drawing.Size(75, 23);
            this.btLoadPages.TabIndex = 4;
            this.btLoadPages.Text = "Load pages";
            this.btLoadPages.UseVisualStyleBackColor = true;
            this.btLoadPages.Click += new System.EventHandler(this.BtLoadPages_Click);
            // 
            // nudPageTo
            // 
            this.nudPageTo.Location = new System.Drawing.Point(125, 16);
            this.nudPageTo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPageTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPageTo.Name = "nudPageTo";
            this.nudPageTo.Size = new System.Drawing.Size(45, 20);
            this.nudPageTo.TabIndex = 3;
            this.nudPageTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // nudPageFrom
            // 
            this.nudPageFrom.Location = new System.Drawing.Point(49, 16);
            this.nudPageFrom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPageFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPageFrom.Name = "nudPageFrom";
            this.nudPageFrom.Size = new System.Drawing.Size(45, 20);
            this.nudPageFrom.TabIndex = 0;
            this.nudPageFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(183, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(401, 315);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvFilesList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 315);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File list";
            // 
            // lvFilesList
            // 
            this.lvFilesList.CheckBoxes = true;
            this.lvFilesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chForDownload,
            this.chFileName,
            this.chFileSize,
            this.chTotalDownloads,
            this.chUri});
            this.lvFilesList.ContextMenuStrip = this.cmsFilesList;
            this.lvFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFilesList.FullRowSelect = true;
            this.lvFilesList.GridLines = true;
            this.lvFilesList.HideSelection = false;
            this.lvFilesList.Location = new System.Drawing.Point(3, 16);
            this.lvFilesList.Name = "lvFilesList";
            this.lvFilesList.Size = new System.Drawing.Size(177, 296);
            this.lvFilesList.TabIndex = 1;
            this.lvFilesList.UseCompatibleStateImageBehavior = false;
            this.lvFilesList.View = System.Windows.Forms.View.Details;
            // 
            // chForDownload
            // 
            this.chForDownload.Text = "+";
            this.chForDownload.Width = 20;
            // 
            // chFileName
            // 
            this.chFileName.Text = "Name";
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "Size";
            // 
            // chTotalDownloads
            // 
            this.chTotalDownloads.Text = "Total downloads";
            // 
            // chUri
            // 
            this.chUri.Text = "URI";
            // 
            // cmsFilesList
            // 
            this.cmsFilesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckAllToolStripMenuItem,
            this.UncheckAllToolStripMenuItem,
            this.invertCheckingToolStripMenuItem,
            this.toolStripSeparator5,
            this.selectAllToolStripMenuItem,
            this.unselectAllToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.toolStripSeparator3,
            this.removeCheckedToolStripMenuItem,
            this.removeSelectedToolStripMenuItem,
            this.toolStripSeparator4,
            this.clearToolStripMenuItem});
            this.cmsFilesList.Name = "cmsFilesList";
            this.cmsFilesList.Size = new System.Drawing.Size(165, 220);
            this.cmsFilesList.Text = " ";
            // 
            // CheckAllToolStripMenuItem
            // 
            this.CheckAllToolStripMenuItem.Name = "CheckAllToolStripMenuItem";
            this.CheckAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CheckAllToolStripMenuItem.Text = "Check all";
            this.CheckAllToolStripMenuItem.Click += new System.EventHandler(this.CheckAllToolStripMenuItem_Click);
            // 
            // UncheckAllToolStripMenuItem
            // 
            this.UncheckAllToolStripMenuItem.Name = "UncheckAllToolStripMenuItem";
            this.UncheckAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.UncheckAllToolStripMenuItem.Text = "Unckeck all";
            this.UncheckAllToolStripMenuItem.Click += new System.EventHandler(this.UncheckAllToolStripMenuItem_Click);
            // 
            // invertCheckingToolStripMenuItem
            // 
            this.invertCheckingToolStripMenuItem.Name = "invertCheckingToolStripMenuItem";
            this.invertCheckingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.invertCheckingToolStripMenuItem.Text = "Invert checking";
            this.invertCheckingToolStripMenuItem.Click += new System.EventHandler(this.InvertCheckingToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // unselectAllToolStripMenuItem
            // 
            this.unselectAllToolStripMenuItem.Name = "unselectAllToolStripMenuItem";
            this.unselectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.unselectAllToolStripMenuItem.Text = "Unselect all";
            this.unselectAllToolStripMenuItem.Click += new System.EventHandler(this.UnselectAllToolStripMenuItem_Click);
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.invertSelectionToolStripMenuItem.Text = "Invert selection";
            this.invertSelectionToolStripMenuItem.Click += new System.EventHandler(this.InvertSelectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // removeCheckedToolStripMenuItem
            // 
            this.removeCheckedToolStripMenuItem.Name = "removeCheckedToolStripMenuItem";
            this.removeCheckedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeCheckedToolStripMenuItem.Text = "Remove checked";
            this.removeCheckedToolStripMenuItem.Click += new System.EventHandler(this.RemoveCheckedToolStripMenuItem_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.RemoveSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.logBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 315);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log";
            // 
            // logBox
            // 
            this.logBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(3, 16);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(204, 296);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grabber";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pExtentionsChoose.ResumeLayout(false);
            this.pExtentionsChoose.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageFrom)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.cmsFilesList.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tspbFileProgress;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvFilesList;
        private System.Windows.Forms.ColumnHeader chForDownload;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.ColumnHeader chTotalDownloads;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ColumnHeader chUri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudPageFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPageTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.TextBox tbExtentions;
        private System.Windows.Forms.Label lbExtentionsInfo;
        private System.Windows.Forms.Panel pExtentionsChoose;
        private System.Windows.Forms.RadioButton rbDontDownload;
        private System.Windows.Forms.RadioButton rbDownload;
        private System.Windows.Forms.Button btLoadPages;
        private System.Windows.Forms.ContextMenuStrip cmsFilesList;
        private System.Windows.Forms.ToolStripMenuItem CheckAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UncheckAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem removeCheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem invertCheckingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectAllToolStripMenuItem;
    }
}

