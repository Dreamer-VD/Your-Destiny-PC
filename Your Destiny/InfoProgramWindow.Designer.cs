namespace Your_Destiny
{
    partial class InfoProgramWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoProgramWindow));
            this.labelTextInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageButtonClickGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextInfo
            // 
            this.labelTextInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.labelTextInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextInfo.ForeColor = System.Drawing.Color.Yellow;
            this.labelTextInfo.Location = new System.Drawing.Point(12, 9);
            this.labelTextInfo.Name = "labelTextInfo";
            this.labelTextInfo.Size = new System.Drawing.Size(572, 358);
            this.labelTextInfo.TabIndex = 0;
            this.labelTextInfo.Text = "Информация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Your_Destiny.Properties.Resources.destiny;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(121, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 208);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageButtonClickGoBack
            // 
            this.imageButtonClickGoBack.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonClickGoBack.BackgroundImage = global::Your_Destiny.Properties.Resources.Arrow;
            this.imageButtonClickGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButtonClickGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButtonClickGoBack.Location = new System.Drawing.Point(507, 575);
            this.imageButtonClickGoBack.Name = "imageButtonClickGoBack";
            this.imageButtonClickGoBack.Size = new System.Drawing.Size(65, 56);
            this.imageButtonClickGoBack.TabIndex = 14;
            this.imageButtonClickGoBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imageButtonClickGoBack.UseVisualStyleBackColor = false;
            this.imageButtonClickGoBack.Click += new System.EventHandler(this.imageButtonClickGoBack_Click);
            // 
            // InfoProgramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Your_Destiny.Properties.Resources.setting1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.imageButtonClickGoBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTextInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoProgramWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о программе";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoProgramWindow_FormClosed);
            this.Load += new System.EventHandler(this.InfoProgramWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTextInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button imageButtonClickGoBack;
    }
}