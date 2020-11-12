namespace Grabber {
    partial class FormPreferences {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btDefaults = new System.Windows.Forms.Button();
            this.btDiscard = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudRequestTimeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDownloadAttempts = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRequestAttemts = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btChooseSavePath = new System.Windows.Forms.Button();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.cbSaveOnExit = new System.Windows.Forms.CheckBox();
            this.nudDownloadDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRequestDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownloadAttempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestAttemts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownloadDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btDefaults
            // 
            this.btDefaults.Location = new System.Drawing.Point(93, 299);
            this.btDefaults.Name = "btDefaults";
            this.btDefaults.Size = new System.Drawing.Size(75, 23);
            this.btDefaults.TabIndex = 9;
            this.btDefaults.Text = "По умолч";
            this.btDefaults.UseVisualStyleBackColor = true;
            // 
            // btDiscard
            // 
            this.btDiscard.Location = new System.Drawing.Point(12, 299);
            this.btDiscard.Name = "btDiscard";
            this.btDiscard.Size = new System.Drawing.Size(75, 23);
            this.btDiscard.TabIndex = 8;
            this.btDiscard.Text = "Отмена";
            this.btDiscard.UseVisualStyleBackColor = true;
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(207, 299);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(75, 23);
            this.btAccept.TabIndex = 7;
            this.btAccept.Text = "Применить";
            this.btAccept.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudRequestTimeout);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudDownloadAttempts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudRequestAttemts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btChooseSavePath);
            this.groupBox1.Controls.Add(this.tbSavePath);
            this.groupBox1.Controls.Add(this.cbSaveOnExit);
            this.groupBox1.Controls.Add(this.nudDownloadDelay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudRequestDelay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 281);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки программы";
            // 
            // nudRequestTimeout
            // 
            this.nudRequestTimeout.Location = new System.Drawing.Point(9, 71);
            this.nudRequestTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRequestTimeout.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRequestTimeout.Name = "nudRequestTimeout";
            this.nudRequestTimeout.Size = new System.Drawing.Size(67, 20);
            this.nudRequestTimeout.TabIndex = 13;
            this.nudRequestTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Таймаут зпроса (мс):";
            // 
            // nudDownloadAttempts
            // 
            this.nudDownloadAttempts.Location = new System.Drawing.Point(9, 250);
            this.nudDownloadAttempts.Name = "nudDownloadAttempts";
            this.nudDownloadAttempts.Size = new System.Drawing.Size(67, 20);
            this.nudDownloadAttempts.TabIndex = 11;
            this.nudDownloadAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Попыток при неудачной загрузке:";
            // 
            // nudRequestAttemts
            // 
            this.nudRequestAttemts.Location = new System.Drawing.Point(9, 211);
            this.nudRequestAttemts.Name = "nudRequestAttemts";
            this.nudRequestAttemts.Size = new System.Drawing.Size(67, 20);
            this.nudRequestAttemts.TabIndex = 9;
            this.nudRequestAttemts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Попыток при неудачном запросе:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Папка для загрузок:";
            // 
            // btChooseSavePath
            // 
            this.btChooseSavePath.Location = new System.Drawing.Point(236, 172);
            this.btChooseSavePath.Name = "btChooseSavePath";
            this.btChooseSavePath.Size = new System.Drawing.Size(28, 21);
            this.btChooseSavePath.TabIndex = 6;
            this.btChooseSavePath.Text = "...";
            this.btChooseSavePath.UseVisualStyleBackColor = true;
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(9, 172);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(226, 20);
            this.tbSavePath.TabIndex = 5;
            // 
            // cbSaveOnExit
            // 
            this.cbSaveOnExit.AutoSize = true;
            this.cbSaveOnExit.Checked = true;
            this.cbSaveOnExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaveOnExit.Location = new System.Drawing.Point(9, 136);
            this.cbSaveOnExit.Name = "cbSaveOnExit";
            this.cbSaveOnExit.Size = new System.Drawing.Size(179, 17);
            this.cbSaveOnExit.TabIndex = 4;
            this.cbSaveOnExit.Text = "Сохранять список при выходе";
            this.cbSaveOnExit.UseVisualStyleBackColor = true;
            // 
            // nudDownloadDelay
            // 
            this.nudDownloadDelay.Location = new System.Drawing.Point(9, 110);
            this.nudDownloadDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDownloadDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDownloadDelay.Name = "nudDownloadDelay";
            this.nudDownloadDelay.Size = new System.Drawing.Size(67, 20);
            this.nudDownloadDelay.TabIndex = 3;
            this.nudDownloadDelay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задержка между загрузками (мс):";
            // 
            // nudRequestDelay
            // 
            this.nudRequestDelay.Location = new System.Drawing.Point(9, 32);
            this.nudRequestDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRequestDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRequestDelay.Name = "nudRequestDelay";
            this.nudRequestDelay.Size = new System.Drawing.Size(67, 20);
            this.nudRequestDelay.TabIndex = 1;
            this.nudRequestDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задержка между запросами (мс):";
            // 
            // FormPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 323);
            this.Controls.Add(this.btDefaults);
            this.Controls.Add(this.btDiscard);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPreferences";
            this.Text = "FomrPreferencer";
            this.Load += new System.EventHandler(this.FomrPreferencer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownloadAttempts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestAttemts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownloadDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDefaults;
        private System.Windows.Forms.Button btDiscard;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudRequestTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDownloadAttempts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRequestAttemts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btChooseSavePath;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.CheckBox cbSaveOnExit;
        private System.Windows.Forms.NumericUpDown nudDownloadDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRequestDelay;
        private System.Windows.Forms.Label label1;
    }
}