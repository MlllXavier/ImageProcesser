namespace ImageProcesser
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.btnGray = new System.Windows.Forms.Button();
            this.picAfter = new System.Windows.Forms.PictureBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnRain = new System.Windows.Forms.Button();
            this.btnRelief = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.Location = new System.Drawing.Point(11, 11);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 22);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOriginal.Location = new System.Drawing.Point(11, 37);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(698, 723);
            this.picOriginal.TabIndex = 1;
            this.picOriginal.TabStop = false;
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(714, 11);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 2;
            this.btnGray.Text = "黑白";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // picAfter
            // 
            this.picAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAfter.Location = new System.Drawing.Point(714, 37);
            this.picAfter.Name = "picAfter";
            this.picAfter.Size = new System.Drawing.Size(698, 723);
            this.picAfter.TabIndex = 3;
            this.picAfter.TabStop = false;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(795, 11);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "底片";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnRain
            // 
            this.btnRain.Location = new System.Drawing.Point(876, 11);
            this.btnRain.Name = "btnRain";
            this.btnRain.Size = new System.Drawing.Size(75, 23);
            this.btnRain.TabIndex = 5;
            this.btnRain.Text = "模糊";
            this.btnRain.UseVisualStyleBackColor = true;
            this.btnRain.Click += new System.EventHandler(this.btnRain_Click);
            // 
            // btnRelief
            // 
            this.btnRelief.Location = new System.Drawing.Point(957, 11);
            this.btnRelief.Name = "btnRelief";
            this.btnRelief.Size = new System.Drawing.Size(75, 23);
            this.btnRelief.TabIndex = 6;
            this.btnRelief.Text = "浮雕";
            this.btnRelief.UseVisualStyleBackColor = true;
            this.btnRelief.Click += new System.EventHandler(this.btnRelief_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 831);
            this.Controls.Add(this.btnRelief);
            this.Controls.Add(this.btnRain);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.picAfter);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.picOriginal);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.PictureBox picAfter;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnRain;
        private System.Windows.Forms.Button btnRelief;
    }
}

