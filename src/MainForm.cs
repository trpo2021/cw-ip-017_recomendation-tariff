using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vs_Progect_Tariff
{
    public partial class MainForm : Form
    {
        public const string Path = @"C:\Users\saw27\Downloads\program\trpo\Kursach\New\cw-ip-017_recomendation-tariff\DataBase.txt";
        public MainForm()
        {
            InitializeComponent();
            UserMoney.Text = "Введите сумму денег";
            UserGigi.Text = "Введите гиги";
            UserMinutes.Text = "Введите минуты";
            UserMoney.ForeColor = Color.Gray;
            UserGigi.ForeColor = Color.Gray;
            UserMinutes.ForeColor = Color.Gray;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UserMoney_Enter(object sender, EventArgs e)
        {
            if (UserMoney.Text == "Введите сумму денег")
            {
                UserMoney.Text = "";
                UserMoney.ForeColor = Color.Black;
            }
        }

        private void UserMoney_Leave(object sender, EventArgs e)
        {
            if (UserMoney.Text == "")
            {
                UserMoney.Text = "Введите сумму денег";
                UserMoney.ForeColor = Color.Gray;
            }
        }

        private void UserEthernet_Enter(object sender, EventArgs e)
        {
            if (UserGigi.Text == "Введите гиги")
            {
                UserGigi.Text = "";
                UserGigi.ForeColor = Color.Black;
            }
        }

        private void UserEthernet_Leave(object sender, EventArgs e)
        {
            if (UserGigi.Text == "")
            {
                UserGigi.Text = "Введите гиги";
                UserGigi.ForeColor = Color.Gray;
            }
        }

        private void UserMinutes_Enter(object sender, EventArgs e)
        {
            if (UserMinutes.Text == "Введите минуты")
            {
                UserMinutes.Text = "";
                UserMinutes.ForeColor = Color.Black;
            }
        }

        private void UserMinutes_Leave(object sender, EventArgs e)
        {
            if (UserMinutes.Text == "")
            {
                UserMinutes.Text = "Введите минуты";
                UserMinutes.ForeColor = Color.Gray;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (UserMinutes.Text == "Введите минуты")
            {
                MessageBox.Show("Ведите минуты");
                return;
            }
            if (UserGigi.Text == "Введиде гиги")
            {
                MessageBox.Show("Введиде гиги");
                return;
            }
            if (UserMoney.Text == "Введите сумму денег")
            {
                MessageBox.Show("Введите сумму денег");
                return;
            }
            int Thisgigi, ThisMinutes, ThisMoney, Money, Gigi, Minutes, OptimalMoney, OptimalGigi, OptimalMinutes;
            bool flag = false;

            using (StreamReader sr = new StreamReader(Path))
            {
                ClassTariffs optimalTariff = new ClassTariffs
                {
                    money = "1000000",
                    gigi = "0",
                    minutes = "0"
                };
                ClassTariffs thisTariff = new ClassTariffs();
                string[] strClass = new string[5];
                string line;
                Money = Convert.ToInt32(UserMoney.Text);
                Gigi = Convert.ToInt32(UserGigi.Text);
                Minutes = Convert.ToInt32(UserMinutes.Text);
                while ((line = sr.ReadLine()) != null)
                {
                    int classUnit = 0;
                    for (int i = 0; i < line.Length; ++i)
                    {
                        if (line[i] == ';')
                            classUnit++;
                        else
                            strClass[classUnit] += line[i];
                    }
                    thisTariff.mobileOperator = strClass[0];
                    thisTariff.name = strClass[1];
                    thisTariff.money = strClass[2];
                    thisTariff.gigi = strClass[3];
                    thisTariff.minutes = strClass[4];

                    for (int i = 0; i < 5; ++i)
                        strClass[i] = "";

                    ThisMoney = Convert.ToInt32(thisTariff.money);
                    Thisgigi = Convert.ToInt32(thisTariff.gigi);
                    ThisMinutes = Convert.ToInt32(thisTariff.minutes);
                    OptimalMoney = Convert.ToInt32(optimalTariff.money);
                    OptimalGigi = Convert.ToInt32(optimalTariff.gigi);
                    OptimalMinutes = Convert.ToInt32(optimalTariff.minutes);
                    
                    if ( ThisMoney <= Money && ThisMoney <= OptimalMoney  &&
                         Thisgigi >= Gigi && ThisMinutes >= Minutes )
                    {
                        if (Thisgigi + ThisMinutes >= OptimalMinutes + OptimalGigi)
                        {
                            optimalTariff.mobileOperator = thisTariff.mobileOperator;
                            optimalTariff.name = thisTariff.name;
                            optimalTariff.money = thisTariff.money;
                            optimalTariff.gigi = thisTariff.gigi;
                            optimalTariff.minutes = thisTariff.minutes;
                            flag = true;
                            OutTextBox.Visible = true;
                        }
                    }
                }
                if(flag==true)
                {
                    OutTextBox.Text  = "\n"+optimalTariff.mobileOperator + "\n"
                                     + optimalTariff.name + "\n"
                                     + optimalTariff.money + " руб/мес\n"
                                     + optimalTariff.gigi + " гиг/мес\n"
                                     + optimalTariff.minutes + " мин/мес";
                    OutTextBox.Visible = true;
                    MessageBox.Show("Тариф подобран");
                }
                else
                    MessageBox.Show("К сожалению, такой тариф подобрать не удалось");
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            WriteDBForm writeDB = new WriteDBForm();
            writeDB.Show();
        }

        private void ShowAllTariffs_Click(object sender, EventArgs e)
        {
            OutTextBox.Text = File.ReadAllText(Path);
            OutTextBox.Visible = true;
        }
    }
}
