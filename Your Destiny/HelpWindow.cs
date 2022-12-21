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
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void buttonClickInfoIo_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoIo.txt");
        }

        private void buttonClickInfoGhost_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoGhost.txt");
        }

        private void buttonClickInfoFallen_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoFallen.txt");
        }

        private void buttonClickInfoHive_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoHive.txt");
        }

        private void buttonClickInfoGuardian_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoGuardians.txt");
        }

        private void buttonClickInfoCabal_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoCabal.txt");
        }

        private void buttonClickInfoTaken_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoTaken.txt");
        }

        private void buttonClickInfoCosmodrom_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoCosmodrom.txt");
        }

        private void buttonClickInfoVex_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoVex.txt");
        }

        private void buttonClickInfoExo_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoExo.txt");
        }

        private void buttonClickInfoMercure_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoMercury.txt");
        }

        private void buttonClickInfoRasputin_Click(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoRasputin.txt");
        }

        private void HelpWindow_Load(object sender, EventArgs e)
        {
            richTextBoxTextInfo.Text = File.ReadAllText(@"InfoCabal.txt");
        }

        private void imageButtonClickGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuWindow window= new MenuWindow();
            window.Show();
        }

        private void HelpWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void HelpWindow_FormClosed(object sender, FormClosedEventArgs e)
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
