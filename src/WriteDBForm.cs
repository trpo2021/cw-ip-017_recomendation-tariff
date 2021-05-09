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
    public partial class WriteDBForm : Form
    {
        public WriteDBForm()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const string Path = @"C:\Users\saw27\Downloads\program\trpo\Kursach\New\cw-ip-017_recomendation-tariff\DataBase.txt";
        Point LastPoint2;
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint2 = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint2.X;
                this.Top += e.Y - LastPoint2.Y;
            }
        }

        private void CreateNewTariff_Click(object sender, EventArgs e)
        {
            ClassTariffs NewClassTariff = new ClassTariffs();
            NewClassTariff.money = "\n"+NewTariffMoney.Text;
            File.AppendAllText(Path, NewClassTariff.money);
            //File.AppendAllLines(Path, NewTariffMoney.Text);
            //File.WriteAllText(@"C:\Users\saw27\Downloads\program\trpo\Kursach\New\cw-ip-017_recomendation-tariff\DataBase.txt", NewTariffMoney.Text);
            MessageBox.Show("Запись в фаил произведена");
        }

        private void NewTariffMoney_Enter(object sender, EventArgs e)
        {
            if (NewTariffMoney.Text == "Введите стоимость")
            {
                NewTariffMoney.Text = "";
                NewTariffMoney.ForeColor = Color.Black;
            }
        }

        private void NewTariffMoney_Leave(object sender, EventArgs e)
        {
            if (NewTariffMoney.Text == "")
            {
                NewTariffMoney.Text = "Введите стоимость";
                NewTariffMoney.ForeColor = Color.Gray;
            }
        }

        private void NewTariffOperator_Enter(object sender, EventArgs e)
        {
            if (NewTariffOperator.Text == "Введите оператора")
            {
                NewTariffOperator.Text = "";
                NewTariffOperator.ForeColor = Color.Black;
            }
        }

        private void NewTariffOperator_Leave(object sender, EventArgs e)
        {
            if (NewTariffOperator.Text == "")
            {
                NewTariffOperator.Text = "Введите оператора";
                NewTariffOperator.ForeColor = Color.Gray;
            }
        }

        private void NewTariffName_Enter(object sender, EventArgs e)
        {
            if (NewTariffName.Text == "Введите название тарифа")
            {
                NewTariffName.Text = "";
                NewTariffName.ForeColor = Color.Black;
            }
        }

        private void NewTariffName_Leave(object sender, EventArgs e)
        {
            if (NewTariffName.Text == "")
            {
                NewTariffName.Text = "Введите название тарифа";
                NewTariffName.ForeColor = Color.Gray;
            }
        }

        private void NewTariffGigi_Enter(object sender, EventArgs e)
        {
            if (NewTariffGigi.Text == "Введите кол-во гигов")
            {
                NewTariffGigi.Text = "";
                NewTariffGigi.ForeColor = Color.Black;
            }
        }

        private void NewTariffGigi_Leave(object sender, EventArgs e)
        {
            if (NewTariffGigi.Text == "")
            {
                NewTariffGigi.Text = "Введите кол-во гигов";
                NewTariffGigi.ForeColor = Color.Gray;
            }
        }

        private void NewTariffMinutes_Enter(object sender, EventArgs e)
        {
            if (NewTariffMinutes.Text == "Введите кол-во минут")
            {
                NewTariffMinutes.Text = "";
                NewTariffMinutes.ForeColor = Color.Black;
            }
        }

        private void NewTariffMinutes_Leave(object sender, EventArgs e)
        {
            if (NewTariffMinutes.Text == "")
            {
                NewTariffMinutes.Text = "Введите кол-во минут";
                NewTariffMinutes.ForeColor = Color.Gray;
            }
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
            if(NewTariffMoney.Text == "Введите стоимость")
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
            string NewTariff ="\n" + NewTariffOperator.Text + ";" + NewTariffName.Text + ";" + NewTariffMoney.Text + ";" + NewTariffGigi.Text + ";" + NewTariffMinutes.Text;
            File.AppendAllText(Path, NewTariff);
            MessageBox.Show("Тариф добавлен");
            this.Close();
        }
    }
}
