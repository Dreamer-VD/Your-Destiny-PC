namespace Your_Destiny
{
    partial class MenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.buttonClickPlay = new System.Windows.Forms.Button();
            this.buttonClickReference = new System.Windows.Forms.Button();
            this.buttonCLickInfo = new System.Windows.Forms.Button();
            this.buttonCLickExit = new System.Windows.Forms.Button();
            this.labelTextNameGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClickPlay
            // 
            this.buttonClickPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClickPlay.BackgroundImage = global::Your_Destiny.Properties.Resources.playgame;
            this.buttonClickPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClickPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClickPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickPlay.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClickPlay.Location = new System.Drawing.Point(268, 92);
            this.buttonClickPlay.Name = "buttonClickPlay";
            this.buttonClickPlay.Size = new System.Drawing.Size(202, 122);
            this.buttonClickPlay.TabIndex = 0;
            this.buttonClickPlay.Text = "Играть";
            this.buttonClickPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClickPlay.UseVisualStyleBackColor = true;
            this.buttonClickPlay.Click += new System.EventHandler(this.buttonClickPlay_Click);
            // 
            // buttonClickReference
            // 
            this.buttonClickReference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClickReference.BackgroundImage = global::Your_Destiny.Properties.Resources.info;
            this.buttonClickReference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClickReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClickReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickReference.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClickReference.Location = new System.Drawing.Point(268, 220);
            this.buttonClickReference.Name = "buttonClickReference";
            this.buttonClickReference.Size = new System.Drawing.Size(202, 122);
            this.buttonClickReference.TabIndex = 1;
            this.buttonClickReference.Text = "Справка";
            this.buttonClickReference.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClickReference.UseVisualStyleBackColor = true;
            this.buttonClickReference.Click += new System.EventHandler(this.buttonClickReference_Click);
            // 
            // buttonCLickInfo
            // 
            this.buttonCLickInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCLickInfo.BackgroundImage = global::Your_Destiny.Properties.Resources.infoprogram;
            this.buttonCLickInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCLickInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLickInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCLickInfo.ForeColor = System.Drawing.Color.Yellow;
            this.buttonCLickInfo.Location = new System.Drawing.Point(268, 348);
            this.buttonCLickInfo.Name = "buttonCLickInfo";
            this.buttonCLickInfo.Size = new System.Drawing.Size(202, 122);
            this.buttonCLickInfo.TabIndex = 2;
            this.buttonCLickInfo.Text = "О программе";
            this.buttonCLickInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCLickInfo.UseVisualStyleBackColor = true;
            this.buttonCLickInfo.Click += new System.EventHandler(this.buttonCLickInfo_Click);
            // 
            // buttonCLickExit
            // 
            this.buttonCLickExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCLickExit.BackgroundImage = global::Your_Destiny.Properties.Resources.exit;
            this.buttonCLickExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCLickExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLickExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCLickExit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonCLickExit.Location = new System.Drawing.Point(268, 477);
            this.buttonCLickExit.Name = "buttonCLickExit";
            this.buttonCLickExit.Size = new System.Drawing.Size(202, 122);
            this.buttonCLickExit.TabIndex = 3;
            this.buttonCLickExit.Text = "Выход";
            this.buttonCLickExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCLickExit.UseVisualStyleBackColor = true;
            this.buttonCLickExit.Click += new System.EventHandler(this.buttonCLickExit_Click);
            // 
            // labelTextNameGame
            // 
            this.labelTextNameGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextNameGame.AutoSize = true;
            this.labelTextNameGame.BackColor = System.Drawing.Color.Transparent;
            this.labelTextNameGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextNameGame.ForeColor = System.Drawing.Color.White;
            this.labelTextNameGame.Location = new System.Drawing.Point(221, 9);
            this.labelTextNameGame.Name = "labelTextNameGame";
            this.labelTextNameGame.Size = new System.Drawing.Size(299, 55);
            this.labelTextNameGame.TabIndex = 4;
            this.labelTextNameGame.Text = "Your Destiny";
            this.labelTextNameGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Your_Destiny.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 671);
            this.Controls.Add(this.labelTextNameGame);
            this.Controls.Add(this.buttonCLickExit);
            this.Controls.Add(this.buttonClickPlay);
            this.Controls.Add(this.buttonCLickInfo);
            this.Controls.Add(this.buttonClickReference);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню игры";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuWindow_FormClosed);
            this.Load += new System.EventHandler(this.MenuWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClickPlay;
        private System.Windows.Forms.Button buttonClickReference;
        private System.Windows.Forms.Button buttonCLickInfo;
        private System.Windows.Forms.Button buttonCLickExit;
        private System.Windows.Forms.Label labelTextNameGame;
    }
}