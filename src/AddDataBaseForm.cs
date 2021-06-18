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
        public AddDataBaseForm()
        {
            InitializeComponent();
            Icon = new Icon("..\\images\\iconTariff.ico");
            IconPicture.Image = Image.FromFile("..\\images\\iconTariff.png");
            logic.TextBoxInit(NewTariffMoney, "Введите стоимость");
            logic.TextBoxInit(NewTariffOperator, "Введите оператора");
            logic.TextBoxInit(NewTariffName, "Введите название тарифа");
            logic.TextBoxInit(NewTariffGigi, "Введите кол-во гигов");
            logic.TextBoxInit(NewTariffMinutes, "Введите кол-во минут");
            logic.TextBoxInit(NewTariffTV, "Введите кол-во ТВ каналов");
            logic.TextBoxInit(NewTariffSMS, "Введите кол-во СМС");
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
            logic.Ent(NewTariffOperator, "Введите оператора");
        }

        private void NewTariffOperator_Leave(object sender, EventArgs e)
        {
            logic.Lv(NewTariffOperator, "Введите оператора");
        }

        private void NewTariffName_Enter(object sender, EventArgs e)
        {
            logic.Ent(NewTariffName, "Введите название тарифа");
        }

        private void NewTariffName_Leave(object sender, EventArgs e)
        {
            logic.Lv(NewTariffName, "Введите название тарифа");
        }

        private void NewTariffMoney_Enter(object sender, EventArgs e)
        {
            logic.Ent(NewTariffMoney, "Введите стоимость");
        }

        private void NewTariffMoney_Leave(object sender, EventArgs e)
        {
            logic.Lv(NewTariffMoney, "Введите стоимость");
        }

        private void NewTariffGigi_Enter(object sender, EventArgs e)
        {
            logic.Ent(NewTariffGigi, "Введите кол-во гигов");
        }

        private void NewTariffGigi_Leave(object sender, EventArgs e)
        {
            logic.Lv(NewTariffGigi, "Введите кол-во гигов");
            logic.UnlimitedCheckLeave(UnlimitedCheckBox, NewTariffGigi);
        }

        private void NewTariffMinutes_Enter(object sender, EventArgs e)
        {
            logic.Ent(NewTariffMinutes, "Введите кол-во минут");
        }

        private void NewTariffMinutes_Leave(object sender, EventArgs e)
        {
            logic.Lv(NewTariffMinutes, "Введите кол-во минут");
        }
        private void NewUserTV_Enter(object sender, EventArgs e)
        {
            logic.Ent(NewTariffTV, "Введите кол-во ТВ каналов");
        }

        private void NewUserTV_Leave(object sender, EventArgs e)
        {
            logic.Lv(NewTariffTV, "Введите кол-во ТВ каналов");
        }

        private void NewUserSMS_Enter(object sender, EventArgs e)
        {
            logic.Ent(NewTariffSMS, "Введите кол-во СМС");
        }

        private void NewUserSMS_Leave(object sender, EventArgs e)
        {
            logic.Lv(NewTariffSMS, "Введите кол-во СМС");
        }

        private void CreateTariffButton_Click(object sender, EventArgs e)
        {
            if (!logic.isCorectly(NewTariffMoney, "Введите стоимость"))
                return;
            if (!logic.isCorectly(NewTariffGigi, "Введите кол-во гигов"))
                return;
            if (!logic.isCorectly(NewTariffMinutes, "Введите кол-во минут"))
                return;
            if (!logic.isCorectly(NewTariffTV, "Введите кол-во ТВ каналов"))
                return;
            if (!logic.isCorectly(NewTariffSMS, "Введите кол-во СМС"))
                return;

            string NewTariff = NewTariffOperator.Text + ";" + NewTariffName.Text + ";" + NewTariffMoney.Text + ";" + NewTariffGigi.Text + ";" + NewTariffMinutes.Text + ";" + NewTariffTV.Text + ";" + NewTariffSMS.Text;
            if (UnlimitedMessengersCheckBox.Checked == true)
                NewTariff += ";да\n";
            else
                NewTariff += ";нет\n";
            File.AppendAllText(logic.Path, NewTariff);
            MessageBox.Show("Тариф добавлен");
            this.Close();
        }

        private void UnlimitedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            logic.UnlimitedCheckChanged(UnlimitedCheckBox, NewTariffGigi, "Введите кол-во гигов");
        }
    }
}
