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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            labelTextDialogues.Text = File.ReadAllText(@"Text2.txt");
            labelRole.Text = "Рассказчик:";
        }

        private void buttonClickNext1_Click(object sender, EventArgs e)
        {
            if (labelTextDialogues.Text == File.ReadAllText(@"Text2.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ghost.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text3.txt");
                labelRole.Text = "Неизвестный:";
                buttonClickNext2.Visible = true;
                buttonClickNext3.Visible = true;
                buttonClickNext2.Text = "Не обращать внимание";
                buttonClickNext3.Text = "Выстрелить в сферу";
                buttonClickNext1.Text = "Остаться с ним";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text3.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ghost.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text4.txt");
                labelRole.Text = "Призрак:";
                buttonClickNext2.Visible = false;
                buttonClickNext3.Visible = false;
                buttonClickNext1.Text = "Хорошо (кивнуть головой)";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text4.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("gwardian.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text5.txt");
                labelRole.Text = "Страж:";
                buttonClickNext1.Text = "Продолжить";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text5.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ghost.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text6.txt");
                labelRole.Text = "Призрак:";
                buttonClickNext1.Text = "Вперёд!";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text6.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text7.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext1.Text = "Продолжит";
                this.BackgroundImage = Image.FromFile("cosmodrome2.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text7.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text8.txt");
                labelRole.Text = "Рассказчик:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text8.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text9.txt");
                labelRole.Text = "Рассказчик:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text9.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text10.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("menu.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text10.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ghost.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text11.txt");
                labelRole.Text = "Призрак:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text11.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text12.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext3.Visible = true;
                buttonClickNext1.Text = "Согласиться";
                buttonClickNext3.Text = "Отказаться";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text12.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text13.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext1.Text = "Продолжить";
                buttonClickNext3.Visible = false;
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text13.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text14.txt");
                labelRole.Text = "Рассказчик:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text14.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ghost.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text15.txt");
                labelRole.Text = "Призрак:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text15.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("uldransov.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text16.txt");
                labelRole.Text = "Ульдран Сов:";
                buttonClickNext1.Text = "Согласиться";
                buttonClickNext2.Text = "Взять хитростью";
                buttonClickNext3.Text = "Пригрозить";
                buttonClickNext2.Visible = true;
                buttonClickNext3.Visible = true;
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text16.txt") )
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text17.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext2.Visible = false;
                buttonClickNext3.Visible = false;
                buttonClickNext1.Text = "Продолжить";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text17.txt") || labelTextDialogues.Text == File.ReadAllText(@"TextAC.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text18.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("stranik.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text18.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text19.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("menu.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text19.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text20.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("dreadnaught.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text20.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("zavala.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text21.txt");
                labelRole.Text = "Завала:";
                this.BackgroundImage = Image.FromFile("menu.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text21.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text22.txt");
                labelRole.Text = "Рассказчик:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text22.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text23.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("stranik.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text23.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ghost.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text24.txt");
                labelRole.Text = "Призрак:";
                this.BackgroundImage = Image.FromFile("menu.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text24.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("zavala.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text25.txt");
                labelRole.Text = "Завала:";
                buttonClickNext3.Text = "Убежать";
                buttonClickNext3.Visible = true;
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text25.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text26.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext1.Text = "Отправиться за Друзьями";
                buttonClickNext2.Text = "Отправиться за Распутиным";
                buttonClickNext3.Visible = false;
                buttonClickNext2.Visible = true;
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text26.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text27.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext3.Visible = true;
                buttonClickNext2.Visible = false;
                buttonClickNext1.Text = "Пролететь незаметно";
                buttonClickNext3.Text = "В бой!";
                this.BackgroundImage = Image.FromFile("korabl.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text27.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text28.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext3.Visible = false;
                buttonClickNext1.Text = "Продолжить";
                this.BackgroundImage = Image.FromFile("io.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text28.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text29.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("infiniteex.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text29.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ikorarey.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text30.txt");
                labelRole.Text = "Икора Рей:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text30.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text31.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("forestin.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text31.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text32.txt");
                labelRole.Text = "Рассказчик:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text32.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ikorarey.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text33.txt");
                labelRole.Text = "Икора Рей:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text33.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("osiris.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text34.txt");
                labelRole.Text = "Осирис:";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text34.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text35.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("stranik.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text35.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text36.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("crota.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text36.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text37.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("drednoutin.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text37.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("osiris.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text38.txt");
                labelRole.Text = "Осирис:";
                this.BackgroundImage = Image.FromFile("orix.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text38.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("osiris.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text39.txt");
                labelRole.Text = "Осирис:";
                buttonClickNext3.Text = "Стратегия одиночек";
                buttonClickNext1.Text = "Командная стратегия";
                buttonClickNext3.Visible = true;
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text39.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text40.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext3.Visible = false;
                buttonClickNext1.Text = "Продолжить";
                this.BackgroundImage = Image.FromFile("korabl.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text40.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text41.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("gorod.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text41.txt") || labelTextDialogues.Text == File.ReadAllText(@"TextAC-EndGame5.txt"))
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text-EndGame1.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("darkwill.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text-EndGame1.txt") )
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text-End.txt");
                labelRole.Text = "Рассказчик:";
                this.BackgroundImage = Image.FromFile("svidetel.png");
                buttonClickNext1.Text = "Конец";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"Text-End.txt"))
            {
                MenuWindow window= new MenuWindow();
                window.Show();
                this.Hide();    
            }
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

        private void buttonClickNext2_Click(object sender, EventArgs e)
        {
            if (buttonClickNext2.Text== "Не обращать внимание")
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("ghost.png");
                labelTextDialogues.Text = File.ReadAllText(@"Text4.txt");
                labelRole.Text = "Призрак:";
                buttonClickNext1.Text = "Хорошо (кивнуть головой)";
                buttonClickNext2.Visible = false;
                buttonClickNext3.Visible = false;
            }
            else if (buttonClickNext2.Text == "Взять хитростью")
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"TextAC.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext1.Text = "Продолжить";
                buttonClickNext3.Visible = false;
                buttonClickNext2.Visible = false;
            }
            else if (buttonClickNext2.Text == "Отправиться за Распутиным")
            {
                pictureBoxRole.BackgroundImage = Image.FromFile("author.png");
                labelTextDialogues.Text = File.ReadAllText(@"TextAC-EndGame.txt");
                labelRole.Text = "Рассказчик:";
                buttonClickNext2.Text = "Продолжить";
                buttonClickNext1.Visible = false;
                this.BackgroundImage = Image.FromFile("korabl.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"TextAC-EndGame.txt"))
            {
                labelTextDialogues.Text = File.ReadAllText(@"TextAC-EndGame1.txt");
                this.BackgroundImage = Image.FromFile("bunker.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"TextAC-EndGame1.txt"))
            {
                labelTextDialogues.Text = File.ReadAllText(@"TextAC-EndGame2.txt");
                this.BackgroundImage = Image.FromFile("inrasputin.png");
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"TextAC-EndGame2.txt"))
            {
                labelTextDialogues.Text = File.ReadAllText(@"TextAC-EndGame3.txt");
                buttonClickNext3.Visible= true;
                buttonClickNext3.Text = "33515";
                buttonClickNext2.Text = "32515";
            }
            else if (buttonClickNext2.Text == "32515")
            {
                labelTextDialogues.Text = File.ReadAllText(@"TextAC-EndGame4.txt");
                buttonClickNext3.Visible = false;
                buttonClickNext2.Text = "Продолжить";
            }
            else if (labelTextDialogues.Text == File.ReadAllText(@"TextAC-EndGame4.txt"))
            {
                labelTextDialogues.Text = File.ReadAllText(@"TextAC-EndGame5.txt");
                this.BackgroundImage = Image.FromFile("gorod.png");
                buttonClickNext1.Visible = true;
                buttonClickNext2.Visible = false;
                buttonClickNext1.Text = "Продолжить";
            }
        }

        private void buttonClickNext3_Click(object sender, EventArgs e)
        {
            if (buttonClickNext3.Text == "Вернуться в меню")
            {
                MenuWindow window = new MenuWindow();
                window.Show();
                this.Hide();
            }
            else  if (buttonClickNext3.Text=="Выстрелить в сферу")
            {
                buttonClickNext1.Visible = false;
                buttonClickNext2.Visible = false;
                labelTextDialogues.Text = File.ReadAllText(@"text1EndGame.txt");
                labelRole.Text = "Рассказчик:";
                pictureBoxRole.BackgroundImage = Image.FromFile("deadghost.png");
                buttonClickNext3.Text = "Вернуться в меню";
            }
            else if (buttonClickNext3.Text == "Отказаться")
            {
                buttonClickNext1.Visible = false;
                buttonClickNext2.Visible = false;
                labelTextDialogues.Text = File.ReadAllText(@"text2EndGame.txt");
                labelRole.Text = "Рассказчик:";
                pictureBoxRole.BackgroundImage = Image.FromFile("deadghost.png");
                buttonClickNext3.Text = "Вернуться в меню";
            }
            else if (buttonClickNext3.Text == "Пригрозить")
            {
                buttonClickNext1.Visible = false;
                buttonClickNext2.Visible = false;
                labelTextDialogues.Text = File.ReadAllText(@"text3EndGame.txt");
                labelRole.Text = "Рассказчик:";
                pictureBoxRole.BackgroundImage = Image.FromFile("deadghost.png");
                buttonClickNext3.Text = "Вернуться в меню";
            }
            else if (buttonClickNext3.Text == "Убежать")
            {
                buttonClickNext1.Visible = false;
                buttonClickNext2.Visible = false;
                labelTextDialogues.Text = File.ReadAllText(@"text4EndGame.txt");
                labelRole.Text = "Рассказчик:";
                pictureBoxRole.BackgroundImage = Image.FromFile("deadghost.png");
                buttonClickNext3.Text = "Вернуться в меню";
                this.BackgroundImage = Image.FromFile("night.png");
            }
            else if (buttonClickNext3.Text == "В бой!")
            {
                buttonClickNext1.Visible = false;
                buttonClickNext2.Visible = false;
                labelTextDialogues.Text = File.ReadAllText(@"text5EndGame.txt");
                labelRole.Text = "Рассказчик:";
                pictureBoxRole.BackgroundImage = Image.FromFile("deadghost.png");
                buttonClickNext3.Text = "Вернуться в меню";
                this.BackgroundImage = Image.FromFile("night.png");
            }
            else if (buttonClickNext3.Text == "Стратегия одиночек")
            {
                buttonClickNext1.Visible = false;
                buttonClickNext2.Visible = false;
                labelTextDialogues.Text = File.ReadAllText(@"text6EndGame.txt");
                labelRole.Text = "Рассказчик:";
                pictureBoxRole.BackgroundImage = Image.FromFile("deadghost.png");
                buttonClickNext3.Text = "Вернуться в меню";
                this.BackgroundImage = Image.FromFile("night.png");
            }
            else if (buttonClickNext3.Text == "33515")
            {
                buttonClickNext1.Visible = false;
                buttonClickNext2.Visible = false;
                labelTextDialogues.Text = File.ReadAllText(@"text7EndGame.txt");
                labelRole.Text = "Рассказчик:";
                pictureBoxRole.BackgroundImage = Image.FromFile("deadghost.png");
                buttonClickNext3.Text = "Вернуться в меню";
                this.BackgroundImage = Image.FromFile("night.png");
            }
        }

        private void вернутьсяВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuWindow window = new MenuWindow();
            window.Show();
            this.Hide();
        }
    }
}
