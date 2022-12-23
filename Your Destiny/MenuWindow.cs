using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_Destiny
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void MenuWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonCLickExit_Click(object sender, EventArgs e)
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

        private void buttonClickPlay_Click(object sender, EventArgs e)
        {
            GameWindow window= new GameWindow();
            window.Show();
            this.Hide();
        }

        private void buttonClickReference_Click(object sender, EventArgs e)
        {
            HelpWindow window = new HelpWindow();
            window.Show();
            this.Hide();
        }

        private void buttonCLickInfo_Click(object sender, EventArgs e)
        {
            InfoProgramWindow window = new InfoProgramWindow();
            window.Show();
            this.Hide();
        }

        private void MenuWindow_FormClosed(object sender, FormClosedEventArgs e)
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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpProgramWindow windowwindow = new HelpProgramWindow();
            windowwindow.Show();
        }

        private void играToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameWindow windowwindow = new GameWindow();
            windowwindow.Show();
            this.Hide();
        }

        private void информацияОПроисходящемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow window = new HelpWindow();
            window.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoProgramWindow window = new InfoProgramWindow();
            window.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
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