namespace TesterSample
{
    partial class Deploy
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
            this.button1 = new System.Windows.Forms.Button();
            this.Version_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SDL_Box = new System.Windows.Forms.TextBox();
            this.CompileSW_ListBox = new System.Windows.Forms.CheckedListBox();
            this.loadWeather_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Version_Box
            // 
            this.Version_Box.Location = new System.Drawing.Point(21, 26);
            this.Version_Box.Name = "Version_Box";
            this.Version_Box.Size = new System.Drawing.Size(305, 19);
            this.Version_Box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "SoftVertion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "個別番号";
            // 
            // SDL_Box
            // 
            this.SDL_Box.Location = new System.Drawing.Point(21, 108);
            this.SDL_Box.Name = "SDL_Box";
            this.SDL_Box.Size = new System.Drawing.Size(305, 19);
            this.SDL_Box.TabIndex = 5;
            // 
            // CompileSW_ListBox
            // 
            this.CompileSW_ListBox.FormattingEnabled = true;
            this.CompileSW_ListBox.Location = new System.Drawing.Point(485, 26);
            this.CompileSW_ListBox.Name = "CompileSW_ListBox";
            this.CompileSW_ListBox.Size = new System.Drawing.Size(172, 158);
            this.CompileSW_ListBox.TabIndex = 7;
            // 
            // loadWeather_Button
            // 
            this.loadWeather_Button.Location = new System.Drawing.Point(530, 383);
            this.loadWeather_Button.Name = "loadWeather_Button";
            this.loadWeather_Button.Size = new System.Drawing.Size(74, 46);
            this.loadWeather_Button.TabIndex = 8;
            this.loadWeather_Button.Text = "更新";
            this.loadWeather_Button.UseVisualStyleBackColor = true;
            this.loadWeather_Button.Click += new System.EventHandler(this.loadWeather_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "コンパイルSW情報";
            // 
            // Deploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadWeather_Button);
            this.Controls.Add(this.CompileSW_ListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SDL_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Version_Box);
            this.Controls.Add(this.button1);
            this.Name = "Deploy";
            this.Text = "Deploy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Version_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SDL_Box;
        private System.Windows.Forms.CheckedListBox CompileSW_ListBox;
        private System.Windows.Forms.Button loadWeather_Button;
        private System.Windows.Forms.Label label3;
    }
}
