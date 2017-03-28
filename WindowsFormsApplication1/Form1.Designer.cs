namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DMM_GetValueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.selectModeButton = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.DMM_ModeSelectBox = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.DMM_OutputBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.XlsxFilePath = new System.Windows.Forms.TextBox();
            this.OpenXlsxFile = new System.Windows.Forms.Button();
            this.xlsx_label = new System.Windows.Forms.Label();
            this.DeployFormShow_Button = new System.Windows.Forms.Button();
            this.DMM_ModeSelectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DMM_GetValueButton
            // 
            this.DMM_GetValueButton.Location = new System.Drawing.Point(275, 102);
            this.DMM_GetValueButton.Name = "DMM_GetValueButton";
            this.DMM_GetValueButton.Size = new System.Drawing.Size(80, 38);
            this.DMM_GetValueButton.TabIndex = 0;
            this.DMM_GetValueButton.Text = "値取得";
            this.DMM_GetValueButton.UseVisualStyleBackColor = true;
            this.DMM_GetValueButton.UseWaitCursor = true;
            this.DMM_GetValueButton.Click += new System.EventHandler(this.DMM_GetValueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keysight 34410A";
            this.label1.UseWaitCursor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DCV";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.UseWaitCursor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ACV";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.UseWaitCursor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "DCI";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.UseWaitCursor = true;
            // 
            // selectModeButton
            // 
            this.selectModeButton.Location = new System.Drawing.Point(170, 102);
            this.selectModeButton.Name = "selectModeButton";
            this.selectModeButton.Size = new System.Drawing.Size(60, 39);
            this.selectModeButton.TabIndex = 3;
            this.selectModeButton.Text = "切替";
            this.selectModeButton.UseVisualStyleBackColor = true;
            this.selectModeButton.UseWaitCursor = true;
            this.selectModeButton.Click += new System.EventHandler(this.selectModeButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 84);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 16);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ACI";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.UseWaitCursor = true;
            // 
            // DMM_ModeSelectBox
            // 
            this.DMM_ModeSelectBox.Controls.Add(this.radioButton5);
            this.DMM_ModeSelectBox.Controls.Add(this.radioButton4);
            this.DMM_ModeSelectBox.Controls.Add(this.radioButton1);
            this.DMM_ModeSelectBox.Controls.Add(this.radioButton3);
            this.DMM_ModeSelectBox.Controls.Add(this.radioButton2);
            this.DMM_ModeSelectBox.Location = new System.Drawing.Point(27, 40);
            this.DMM_ModeSelectBox.Name = "DMM_ModeSelectBox";
            this.DMM_ModeSelectBox.Size = new System.Drawing.Size(123, 133);
            this.DMM_ModeSelectBox.TabIndex = 3;
            this.DMM_ModeSelectBox.TabStop = false;
            this.DMM_ModeSelectBox.Text = "DMM_モードセレクト";
            this.DMM_ModeSelectBox.UseWaitCursor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(13, 106);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 16);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "OHM";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.UseWaitCursor = true;
            // 
            // DMM_OutputBox
            // 
            this.DMM_OutputBox.Location = new System.Drawing.Point(361, 121);
            this.DMM_OutputBox.Name = "DMM_OutputBox";
            this.DMM_OutputBox.Size = new System.Drawing.Size(124, 19);
            this.DMM_OutputBox.TabIndex = 4;
            this.DMM_OutputBox.Text = "出力値";
            this.DMM_OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DMM_OutputBox.UseWaitCursor = true;
            // 
            // XlsxFilePath
            // 
            this.XlsxFilePath.Location = new System.Drawing.Point(29, 255);
            this.XlsxFilePath.Name = "XlsxFilePath";
            this.XlsxFilePath.Size = new System.Drawing.Size(284, 19);
            this.XlsxFilePath.TabIndex = 5;
            this.XlsxFilePath.UseWaitCursor = true;
            // 
            // OpenXlsxFile
            // 
            this.OpenXlsxFile.Location = new System.Drawing.Point(323, 252);
            this.OpenXlsxFile.Name = "OpenXlsxFile";
            this.OpenXlsxFile.Size = new System.Drawing.Size(92, 27);
            this.OpenXlsxFile.TabIndex = 6;
            this.OpenXlsxFile.Text = "xlsx選択";
            this.OpenXlsxFile.UseVisualStyleBackColor = true;
            this.OpenXlsxFile.UseWaitCursor = true;
            this.OpenXlsxFile.Click += new System.EventHandler(this.OpenXlsxFile_Click);
            // 
            // xlsx_label
            // 
            this.xlsx_label.AutoSize = true;
            this.xlsx_label.Location = new System.Drawing.Point(35, 281);
            this.xlsx_label.Name = "xlsx_label";
            this.xlsx_label.Size = new System.Drawing.Size(226, 12);
            this.xlsx_label.TabIndex = 7;
            this.xlsx_label.Text = "※xlsxファイルの一番左のタブに書き込まれます";
            this.xlsx_label.UseWaitCursor = true;
            // 
            // DeployFormShow_Button
            // 
            this.DeployFormShow_Button.Location = new System.Drawing.Point(581, 11);
            this.DeployFormShow_Button.Name = "DeployFormShow_Button";
            this.DeployFormShow_Button.Size = new System.Drawing.Size(87, 39);
            this.DeployFormShow_Button.TabIndex = 8;
            this.DeployFormShow_Button.Text = "Deploy";
            this.DeployFormShow_Button.UseMnemonic = false;
            this.DeployFormShow_Button.UseVisualStyleBackColor = true;
            this.DeployFormShow_Button.Click += new System.EventHandler(this.DeployFormShow_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 312);
            this.Controls.Add(this.DeployFormShow_Button);
            this.Controls.Add(this.xlsx_label);
            this.Controls.Add(this.OpenXlsxFile);
            this.Controls.Add(this.XlsxFilePath);
            this.Controls.Add(this.DMM_OutputBox);
            this.Controls.Add(this.selectModeButton);
            this.Controls.Add(this.DMM_ModeSelectBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DMM_GetValueButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.UseWaitCursor = true;
            this.DMM_ModeSelectBox.ResumeLayout(false);
            this.DMM_ModeSelectBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DMM_GetValueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectModeButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox DMM_ModeSelectBox;
        private System.Windows.Forms.TextBox DMM_OutputBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox XlsxFilePath;
        private System.Windows.Forms.Button OpenXlsxFile;
        private System.Windows.Forms.Label xlsx_label;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button DeployFormShow_Button;
    }
}

