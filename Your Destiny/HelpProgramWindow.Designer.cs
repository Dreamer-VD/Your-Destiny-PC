namespace Your_Destiny
{
    partial class HelpProgramWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpProgramWindow));
            this.richTextBoxForProgram = new System.Windows.Forms.RichTextBox();
            this.pictureBoxProgram = new System.Windows.Forms.PictureBox();
            this.imageButtonClickGoBack = new System.Windows.Forms.Button();
            this.buttonClickLoadingProgram = new System.Windows.Forms.Button();
            this.buttonClickMenu = new System.Windows.Forms.Button();
            this.buttonClickGameWindow = new System.Windows.Forms.Button();
            this.buttonClickHelp = new System.Windows.Forms.Button();
            this.buttonClickInfoProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxForProgram
            // 
            this.richTextBoxForProgram.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxForProgram.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxForProgram.Name = "richTextBoxForProgram";
            this.richTextBoxForProgram.ReadOnly = true;
            this.richTextBoxForProgram.Size = new System.Drawing.Size(608, 201);
            this.richTextBoxForProgram.TabIndex = 0;
            this.richTextBoxForProgram.Text = "";
            // 
            // pictureBoxProgram
            // 
            this.pictureBoxProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProgram.Location = new System.Drawing.Point(12, 219);
            this.pictureBoxProgram.Name = "pictureBoxProgram";
            this.pictureBoxProgram.Size = new System.Drawing.Size(608, 387);
            this.pictureBoxProgram.TabIndex = 1;
            this.pictureBoxProgram.TabStop = false;
            // 
            // imageButtonClickGoBack
            // 
            this.imageButtonClickGoBack.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonClickGoBack.BackgroundImage = global::Your_Destiny.Properties.Resources.Arrow;
            this.imageButtonClickGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButtonClickGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButtonClickGoBack.Location = new System.Drawing.Point(555, 612);
            this.imageButtonClickGoBack.Name = "imageButtonClickGoBack";
            this.imageButtonClickGoBack.Size = new System.Drawing.Size(65, 56);
            this.imageButtonClickGoBack.TabIndex = 14;
            this.imageButtonClickGoBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imageButtonClickGoBack.UseVisualStyleBackColor = false;
            this.imageButtonClickGoBack.Click += new System.EventHandler(this.imageButtonClickGoBack_Click);
            // 
            // buttonClickLoadingProgram
            // 
            this.buttonClickLoadingProgram.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickLoadingProgram.Location = new System.Drawing.Point(12, 612);
            this.buttonClickLoadingProgram.Name = "buttonClickLoadingProgram";
            this.buttonClickLoadingProgram.Size = new System.Drawing.Size(100, 50);
            this.buttonClickLoadingProgram.TabIndex = 15;
            this.buttonClickLoadingProgram.Text = "Загрузочный экран";
            this.buttonClickLoadingProgram.UseVisualStyleBackColor = true;
            this.buttonClickLoadingProgram.Click += new System.EventHandler(this.buttonClickLoadingProgram_Click);
            // 
            // buttonClickMenu
            // 
            this.buttonClickMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickMenu.Location = new System.Drawing.Point(118, 612);
            this.buttonClickMenu.Name = "buttonClickMenu";
            this.buttonClickMenu.Size = new System.Drawing.Size(100, 50);
            this.buttonClickMenu.TabIndex = 16;
            this.buttonClickMenu.Text = "Меню";
            this.buttonClickMenu.UseVisualStyleBackColor = true;
            this.buttonClickMenu.Click += new System.EventHandler(this.buttonClickMenu_Click);
            // 
            // buttonClickGameWindow
            // 
            this.buttonClickGameWindow.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickGameWindow.Location = new System.Drawing.Point(224, 612);
            this.buttonClickGameWindow.Name = "buttonClickGameWindow";
            this.buttonClickGameWindow.Size = new System.Drawing.Size(100, 50);
            this.buttonClickGameWindow.TabIndex = 17;
            this.buttonClickGameWindow.Text = "Экран игры";
            this.buttonClickGameWindow.UseVisualStyleBackColor = true;
            this.buttonClickGameWindow.Click += new System.EventHandler(this.buttonClickGameWindow_Click);
            // 
            // buttonClickHelp
            // 
            this.buttonClickHelp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickHelp.Location = new System.Drawing.Point(330, 612);
            this.buttonClickHelp.Name = "buttonClickHelp";
            this.buttonClickHelp.Size = new System.Drawing.Size(100, 50);
            this.buttonClickHelp.TabIndex = 18;
            this.buttonClickHelp.Text = "Информация о происходящем";
            this.buttonClickHelp.UseVisualStyleBackColor = true;
            this.buttonClickHelp.Click += new System.EventHandler(this.buttonClickHelp_Click);
            // 
            // buttonClickInfoProgram
            // 
            this.buttonClickInfoProgram.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickInfoProgram.Location = new System.Drawing.Point(436, 612);
            this.buttonClickInfoProgram.Name = "buttonClickInfoProgram";
            this.buttonClickInfoProgram.Size = new System.Drawing.Size(100, 50);
            this.buttonClickInfoProgram.TabIndex = 19;
            this.buttonClickInfoProgram.Text = "Информация о программе";
            this.buttonClickInfoProgram.UseVisualStyleBackColor = true;
            this.buttonClickInfoProgram.Click += new System.EventHandler(this.buttonClickInfoProgram_Click);
            // 
            // HelpProgramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 670);
            this.Controls.Add(this.buttonClickInfoProgram);
            this.Controls.Add(this.buttonClickHelp);
            this.Controls.Add(this.buttonClickGameWindow);
            this.Controls.Add(this.buttonClickMenu);
            this.Controls.Add(this.buttonClickLoadingProgram);
            this.Controls.Add(this.imageButtonClickGoBack);
            this.Controls.Add(this.pictureBoxProgram);
            this.Controls.Add(this.richTextBoxForProgram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpProgramWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка о использование программы";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpProgramWindow_FormClosed);
            this.Load += new System.EventHandler(this.HelpProgramWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxForProgram;
        private System.Windows.Forms.PictureBox pictureBoxProgram;
        private System.Windows.Forms.Button imageButtonClickGoBack;
        private System.Windows.Forms.Button buttonClickLoadingProgram;
        private System.Windows.Forms.Button buttonClickMenu;
        private System.Windows.Forms.Button buttonClickGameWindow;
        private System.Windows.Forms.Button buttonClickHelp;
        private System.Windows.Forms.Button buttonClickInfoProgram;
    }
}