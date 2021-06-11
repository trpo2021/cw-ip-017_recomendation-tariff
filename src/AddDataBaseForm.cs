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
    public partial class AddDataBaseForm : Form
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
        public AddDataBaseForm()
        {
            InitializeComponent();
            Icon = new Icon("..\\images\\iconTariff.ico");
            IconPicture.Image = Image.FromFile("..\\images\\iconTariff.png");
            NewTariffMoney.Text = "Введите стоимость";
            NewTariffMoney.ForeColor = Color.Gray;
            NewTariffOperator.Text = "Введите оператора";
            NewTariffOperator.ForeColor = Color.Gray;
            NewTariffName.Text = "Введите название тарифа";
            NewTariffName.ForeColor = Color.Gray;
            NewTariffGigi.Text = "Введите кол-во гигов";
            NewTariffGigi.ForeColor = Color.Gray;
            NewTariffMinutes.Text = "Введите кол-во минут";
            NewTariffMinutes.ForeColor = Color.Gray;
        }

        private void CloseButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton2_Click(object sender, EventArgs e)
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

        private void NewTariffOperator_Enter(object sender, EventArgs e)
        {
            Ent(NewTariffOperator,"Введите оператора");
        }

        private void NewTariffOperator_Leave(object sender, EventArgs e)
        {
            Lv(NewTariffOperator, "Введите оператора");
        }

        private void NewTariffName_Enter(object sender, EventArgs e)
        {
            Ent(NewTariffName, "Введите название тарифа");
        }

        private void NewTariffName_Leave(object sender, EventArgs e)
        {
            Lv(NewTariffName, "Введите название тарифа");
        }

        private void NewTariffMoney_Enter(object sender, EventArgs e)
        {
            Ent(NewTariffMoney, "Введите стоимость");
        }

        private void NewTariffMoney_Leave(object sender, EventArgs e)
        {
            Lv(NewTariffMoney, "Введите стоимость");
        }

        private void NewTariffGigi_Enter(object sender, EventArgs e)
        {
            Ent(NewTariffGigi, "Введите кол-во гигов");
        }

        private void NewTariffGigi_Leave(object sender, EventArgs e)
        {
            Lv(NewTariffGigi, "Введите кол-во гигов");
        }

        private void NewTariffMinutes_Enter(object sender, EventArgs e)
        {
            Ent(NewTariffMinutes, "Введите кол-во минут");
        }

        private void NewTariffMinutes_Leave(object sender, EventArgs e)
        {
            Lv(NewTariffMinutes, "Введите кол-во минут");
        }

        private void CreateTariffButton_Click(object sender, EventArgs e)
        {
            if (NewTariffOperator.Text == "Введите оператора")
            {
                MessageBox.Show("Введите оператора");
                return;
            }
            if (NewTariffName.Text == "Введите название тарифа")
            {
                MessageBox.Show("Введите название тарифа");
                return;
            }
            if (NewTariffMoney.Text == "Введите стоимость")
            {
                MessageBox.Show("Введите стоимость");
                return;
            }
            if (NewTariffGigi.Text == "Введите кол-во гигов")
            {
                MessageBox.Show("Введите кол-во гигов");
                return;
            }
            if (NewTariffMinutes.Text == "Введите кол-во минут")
            {
                MessageBox.Show("Введите кол-во минут");
                return;
            }
            string NewTariff ="\n"+NewTariffOperator.Text + ";" + NewTariffName.Text + ";" + NewTariffMoney.Text + ";" + NewTariffGigi.Text + ";" + NewTariffMinutes.Text;
            File.AppendAllText(Path, NewTariff);
            MessageBox.Show("Тариф добавлен");
            this.Close();
        }
    }
}
