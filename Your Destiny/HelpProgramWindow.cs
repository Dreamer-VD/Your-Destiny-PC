using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_Destiny
{
    public partial class HelpProgramWindow : Form
    {
        public HelpProgramWindow()
        {
            InitializeComponent();
        }

        private void imageButtonClickGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HelpProgramWindow_FormClosed(object sender, FormClosedEventArgs e)
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

        private void HelpProgramWindow_Load(object sender, EventArgs e)
        {
            richTextBoxForProgram.Text = File.ReadAllText(@"Text1IHelp.txt");
            pictureBoxProgram.BackgroundImage = Image.FromFile("Loading.png");
        }

        private void buttonClickLoadingProgram_Click(object sender, EventArgs e)
        {
            richTextBoxForProgram.Text = File.ReadAllText(@"Text1IHelp.txt");
            pictureBoxProgram.BackgroundImage = Image.FromFile("Loading.png");
        }

        private void buttonClickMenu_Click(object sender, EventArgs e)
        {
            richTextBoxForProgram.Text = File.ReadAllText(@"Text2IHelp.txt");
            pictureBoxProgram.BackgroundImage = Image.FromFile("MenuForHelp.png");
        }

        private void buttonClickGameWindow_Click(object sender, EventArgs e)
        {
            richTextBoxForProgram.Text = File.ReadAllText(@"Text3IHelp.txt");
            pictureBoxProgram.BackgroundImage = Image.FromFile("GameInfo.png");
        }

        private void buttonClickHelp_Click(object sender, EventArgs e)
        {
            richTextBoxForProgram.Text = File.ReadAllText(@"Text4IHelp.txt");
            pictureBoxProgram.BackgroundImage = Image.FromFile("InfoPers.png");
        }

        private void buttonClickInfoProgram_Click(object sender, EventArgs e)
        {
            richTextBoxForProgram.Text = File.ReadAllText(@"Text5IHelp.txt");
            pictureBoxProgram.BackgroundImage = Image.FromFile("InfoProgram.png");
        }
    }
}
