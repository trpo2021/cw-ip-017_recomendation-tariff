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


namespace Project
{
    
    public partial class MainForm : Form
    {
        public const string Path = "..\\DataBase.txt";
        public void Lv(TextBox box, string text)
        {
            if (box.Text == "")
            {
                box.Text = text;
                box.ForeColor = Color.Gray;
            }
        }
        public void Ent(TextBox box, string text)
        {
            if (box.Text == text)
            {
                box.Text = "";
                box.ForeColor = Color.Black;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Icon = new Icon("..\\images\\iconTariff.ico");
            IconPicture.Image = Image.FromFile("..\\images\\iconTariff.png");
            UserMoney.Text = "Введите сумму денег";
            UserGigi.Text = "Введите гиги";
            UserMinutes.Text = "Введите минуты";
            UserMoney.ForeColor = Color.Gray;
            UserGigi.ForeColor = Color.Gray;
            UserMinutes.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void UserMoney_Enter(object sender, EventArgs e)
        {
            Ent(UserMoney, "Введите сумму денег");
        }
        private void UserMoney_Leave(object sender, EventArgs e)
        {
            Lv(UserMoney, "Введите сумму денег");
        }

        private void UserGigi_Enter(object sender, EventArgs e)
        {
            Ent(UserGigi, "Введите гиги");
        }

        private void UserGigi_Leave(object sender, EventArgs e)
        {
            Lv(UserGigi, "Введите гиги");
        }

        private void UserMinutes_Enter(object sender, EventArgs e)
        {
            Ent(UserMinutes, "Введите минуты");
        }

        private void UserMinutes_Leave(object sender, EventArgs e)
        {
            Lv(UserMinutes, "Введите минуты");
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
                MessageBox.Show("Введите гиги");
                return;
            }
            if (UserMoney.Text == "Введите сумму денег")
            {
                MessageBox.Show("Введите сумму денег");
                return;
            }
            bool flag = false;
            using (StreamReader sr = new StreamReader(Path))
            {
                ClassTariff thisTariff = new ClassTariff();
                ClassTariff optimalTariff = new ClassTariff
                {
                    money = "1000000",
                    gigi = "0",
                    minutes = "0"
                };
                string[] strClass = new string[5];
                string line;
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

                    if (Convert.ToInt32(thisTariff.money) <= Convert.ToInt32(UserMoney.Text) &&
                        Convert.ToInt32(thisTariff.money) <= Convert.ToInt32(optimalTariff.money) &&
                         Convert.ToInt32(thisTariff.gigi) >= Convert.ToInt32(UserGigi.Text) &&
                         Convert.ToInt32(thisTariff.minutes) >= Convert.ToInt32(UserMinutes.Text) &&
                         Convert.ToInt32(thisTariff.gigi)+ Convert.ToInt32(thisTariff.minutes)> Convert.ToInt32(optimalTariff.gigi) + Convert.ToInt32(optimalTariff.minutes))
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
                if (flag == true)
                {
                    OutTextBox.Text = "\n" + optimalTariff.mobileOperator + "\n"
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

        private void ShowAllTariffs_Click(object sender, EventArgs e)
        {
            OutTextBox.Text = File.ReadAllText(Path);
            OutTextBox.Visible = true;
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            AddDataBaseForm writeDB = new AddDataBaseForm();
            writeDB.Show();
        }
    }
}
