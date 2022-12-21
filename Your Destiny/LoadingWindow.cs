using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_Destiny
{
    public partial class LoadingWindow : Form
    {
        SoundPlayer music = new SoundPlayer(@"music.wav");
        public LoadingWindow()
        {
            InitializeComponent();
            music.PlayLooping();
        }

        private void LoadingWindow_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timerLoad.Enabled = false;
                this.Hide();
                MenuWindow MW = new MenuWindow();
                MW.Show();
            }
            else if (progressBar1.Value != 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
        }
    }
}
