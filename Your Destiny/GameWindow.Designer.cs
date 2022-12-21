namespace Your_Destiny
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClickNext3 = new System.Windows.Forms.Button();
            this.buttonClickNext2 = new System.Windows.Forms.Button();
            this.buttonClickNext1 = new System.Windows.Forms.Button();
            this.labelTextDialogues = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureBoxRole = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRole)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.buttonClickNext3);
            this.panel1.Controls.Add(this.buttonClickNext2);
            this.panel1.Controls.Add(this.buttonClickNext1);
            this.panel1.Controls.Add(this.labelTextDialogues);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 242);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonClickNext3
            // 
            this.buttonClickNext3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.buttonClickNext3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClickNext3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClickNext3.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClickNext3.Location = new System.Drawing.Point(0, 146);
            this.buttonClickNext3.Name = "buttonClickNext3";
            this.buttonClickNext3.Size = new System.Drawing.Size(990, 32);
            this.buttonClickNext3.TabIndex = 3;
            this.buttonClickNext3.Text = "Выбор3";
            this.buttonClickNext3.UseVisualStyleBackColor = false;
            // 
            // buttonClickNext2
            // 
            this.buttonClickNext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.buttonClickNext2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClickNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClickNext2.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClickNext2.Location = new System.Drawing.Point(0, 178);
            this.buttonClickNext2.Name = "buttonClickNext2";
            this.buttonClickNext2.Size = new System.Drawing.Size(990, 32);
            this.buttonClickNext2.TabIndex = 2;
            this.buttonClickNext2.Text = "Выбор2";
            this.buttonClickNext2.UseVisualStyleBackColor = false;
            // 
            // buttonClickNext1
            // 
            this.buttonClickNext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.buttonClickNext1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClickNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClickNext1.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClickNext1.Location = new System.Drawing.Point(0, 210);
            this.buttonClickNext1.Name = "buttonClickNext1";
            this.buttonClickNext1.Size = new System.Drawing.Size(990, 32);
            this.buttonClickNext1.TabIndex = 1;
            this.buttonClickNext1.Text = "Выбор1";
            this.buttonClickNext1.UseVisualStyleBackColor = false;
            this.buttonClickNext1.Click += new System.EventHandler(this.buttonClickNext1_Click);
            // 
            // labelTextDialogues
            // 
            this.labelTextDialogues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextDialogues.ForeColor = System.Drawing.Color.Yellow;
            this.labelTextDialogues.Location = new System.Drawing.Point(0, 0);
            this.labelTextDialogues.Name = "labelTextDialogues";
            this.labelTextDialogues.Size = new System.Drawing.Size(990, 145);
            this.labelTextDialogues.TabIndex = 0;
            this.labelTextDialogues.Text = "Текст диалогов";
            // 
            // labelRole
            // 
            this.labelRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.ForeColor = System.Drawing.Color.Yellow;
            this.labelRole.Location = new System.Drawing.Point(-1, 358);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(170, 37);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Кто говорит";
            // 
            // pictureBoxRole
            // 
            this.pictureBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRole.BackgroundImage = global::Your_Destiny.Properties.Resources.author;
            this.pictureBoxRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRole.Location = new System.Drawing.Point(370, 39);
            this.pictureBoxRole.Name = "pictureBoxRole";
            this.pictureBoxRole.Size = new System.Drawing.Size(351, 356);
            this.pictureBoxRole.TabIndex = 2;
            this.pictureBoxRole.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Your_Destiny.Properties.Resources.cosmodrom1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 640);
            this.Controls.Add(this.pictureBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameWindow_FormClosed);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClickNext3;
        private System.Windows.Forms.Button buttonClickNext2;
        private System.Windows.Forms.Button buttonClickNext1;
        private System.Windows.Forms.Label labelTextDialogues;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.PictureBox pictureBoxRole;
    }
}