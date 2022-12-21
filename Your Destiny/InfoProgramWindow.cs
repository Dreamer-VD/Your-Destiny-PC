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
    public partial class InfoProgramWindow : Form
    {
        public InfoProgramWindow()
        {
            InitializeComponent();
        }

        private void InfoProgramWindow_FormClosed(object sender, FormClosedEventArgs e)
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

        private void InfoProgramWindow_Load(object sender, EventArgs e)
        {
            labelTextInfo.Text = File.ReadAllText(@"InfoProgram.txt");
        }

        private void imageButtonClickGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuWindow window = new MenuWindow();
            window.Show();
        }
    }
}
