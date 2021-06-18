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
        public MainForm()
        {
            InitializeComponent();
            Icon = new Icon("..\\images\\iconTariff.ico");
            IconPicture.Image = Image.FromFile("..\\images\\iconTariff.png");
            logic.TextBoxInit(UserMoney, "Введите сумму денег");
            logic.TextBoxInit(UserGigi, "Введите гиги");
            logic.TextBoxInit(UserMinutes, "Введите минуты");
            logic.TextBoxInit(UserTV, "Введите ТВ каналы");
            logic.TextBoxInit(UserSMS, "Введите SMS");
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
            logic.Ent(UserMoney, "Введите сумму денег");
        }

        private void UserMoney_Leave(object sender, EventArgs e)
        {
            logic.Lv(UserMoney, "Введите сумму денег");
        }

        private void UserGigi_Enter(object sender, EventArgs e)
        {
            logic.Ent(UserGigi, "Введите гиги");
        }

        private void UserGigi_Leave(object sender, EventArgs e)
        {
            logic.Lv(UserGigi, "Введите гиги");
            logic.UnlimitedCheckLeave(UnlimitedCheckBox, UserGigi);

        }

        private void UserMinutes_Enter(object sender, EventArgs e)
        {
            logic.Ent(UserMinutes, "Введите минуты");
        }

        private void UserMinutes_Leave(object sender, EventArgs e)
        {
            logic.Lv(UserMinutes, "Введите минуты");
        }

        private void UserTV_Enter(object sender, EventArgs e)
        {
            logic.Ent(UserTV, "Введите ТВ каналы");
        }

        private void UserTV_Leave(object sender, EventArgs e)
        {
            logic.Lv(UserTV, "Введите ТВ каналы");
        }

        private void UserSMS_Enter(object sender, EventArgs e)
        {
            logic.Ent(UserSMS, "Введите SMS");
        }

        private void UserSMS_Leave(object sender, EventArgs e)
        {
            logic.Lv(UserSMS, "Введите SMS");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!logic.isCorectly(UserMoney, "Введите сумму денег"))
                return;
            if (!logic.isCorectly(UserGigi, "Введите гиги"))
                return;
            if (!logic.isCorectly(UserMinutes, "Введите минуты"))
                return;
            if (!logic.isCorectly(UserTV, "Введите ТВ каналы"))
                return;
            if (!logic.isCorectly(UserSMS, "Введите SMS"))
                return;
            bool IsHaveOptimalTariff = false;
            using (StreamReader sr = new StreamReader(logic.Path))
            {
                ClassTariff thisTariff = new ClassTariff();
                ClassTariff optimalTariff = new ClassTariff
                {
                    money = "1000000",
                    gigi = "0",
                    minutes = "0",
                    NumbersOfTV = "0",
                    SMS = "0"
                };
                string[] strClass = new string[8];
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    strClass = logic.ReadDBLine(line);

                    thisTariff.setValueOf(strClass);
                    //обнуляем все строки класса
                    for (int i = 0; i < strClass.Length; ++i)
                        strClass[i] = "";

                    if (UnlimitedMessengersCheckBox.Checked == true && thisTariff.UnlimMessengers == "нет")
                        continue;

                    if (Convert.ToInt32(thisTariff.money) <= Convert.ToInt32(UserMoney.Text) &&
                        Convert.ToInt32(thisTariff.money) <= Convert.ToInt32(optimalTariff.money) &&
                         Convert.ToInt32(thisTariff.gigi) >= Convert.ToInt32(UserGigi.Text) &&
                         Convert.ToInt32(thisTariff.minutes) >= Convert.ToInt32(UserMinutes.Text) &&
                         Convert.ToInt32(thisTariff.gigi) + Convert.ToInt32(thisTariff.minutes) + Convert.ToInt32(thisTariff.NumbersOfTV) > Convert.ToInt32(optimalTariff.gigi) + Convert.ToInt32(optimalTariff.minutes) + Convert.ToInt32(optimalTariff.NumbersOfTV) &&
                          Convert.ToInt32(thisTariff.NumbersOfTV) >= Convert.ToInt32(optimalTariff.NumbersOfTV) &&
                          Convert.ToInt32(thisTariff.NumbersOfTV) >= Convert.ToInt32(UserTV.Text) &&
                          Convert.ToInt32(thisTariff.SMS) >= Convert.ToInt32(optimalTariff.SMS) &&
                          Convert.ToInt32(thisTariff.SMS) >= Convert.ToInt32(UserSMS.Text))
                    {
                        optimalTariff.setValueOf(thisTariff);
                        IsHaveOptimalTariff = true;
                        OutTextBox.Visible = true;
                    }
                }
                if (IsHaveOptimalTariff == true)
                {
                    OutTextBox.Text = "";
                    logic.OutTariff(OutTextBox, optimalTariff);
                    MessageBox.Show("Тариф подобран");
                }
                else
                    MessageBox.Show("К сожалению, такой тариф подобрать не удалось");
            }
        }
        private void ShowAllTariffs_Click(object sender, EventArgs e)
        {
            OutTextBox.Text = "";
            using (StreamReader sr = new StreamReader(logic.Path))
            {
                string[] strClass = new string[8];
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    strClass = logic.ReadDBLine(line);

                    logic.OutTariff(OutTextBox, strClass);

                    for (int i = 0; i < strClass.Length; ++i)
                        strClass[i] = "";
                }
            }
            OutTextBox.Visible = true;
        }
        private void WriteButton_Click(object sender, EventArgs e)
        {
            AddDataBaseForm writeDB = new AddDataBaseForm();
            writeDB.Show();
        }

        private void UnlimitedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            logic.UnlimitedCheckChanged(UnlimitedCheckBox, UserGigi, "Введите гиги");
        }

        private void DeletedTariffButton_Click(object sender, EventArgs e)
        {
            DeletedDataBaseForm DeleteDB = new DeletedDataBaseForm();
            DeleteDB.Show();
        }
    }
}
