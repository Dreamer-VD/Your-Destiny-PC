using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Your_Destiny
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }
        StreamReader endGame1 = new StreamReader("textDialogEndGame1.txt", Encoding.UTF8);
        StreamReader endGame2 = new StreamReader("textDialogEndGame2.txt", Encoding.UTF8);
        StreamReader endGame = new StreamReader("textDialogEndGame3-EndGame.txt", Encoding.UTF8);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            labelTextDialogues.Text = File.ReadAllText(@"Text1.txt");
        }

        private void NextText(string text, string role, Image image) 
        {
            labelTextDialogues.Text = text;
            labelRole.Text = role;
            pictureBoxRole.Image = image;
        }

        private void buttonClickNext1_Click(object sender, EventArgs e)
        {

        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы точно хотите выйти?", "Внимание",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
