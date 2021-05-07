using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Progect_Tariff
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserMoney.Text = "Введите сумму денег";
            UserEthernet.Text = "Гиги";
            UserMinutes.Text = "Минуты";
            UserMoney.ForeColor = Color.Gray;
            UserEthernet.ForeColor = Color.Gray;
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
            if (UserEthernet.Text == "Гиги")
            {
                UserEthernet.Text = "";
                UserEthernet.ForeColor = Color.Black;
            }
        }

        private void UserEthernet_Leave(object sender, EventArgs e)
        {
            if (UserEthernet.Text == "")
            {
                UserEthernet.Text = "Гиги";
                UserEthernet.ForeColor = Color.Gray;
            }
        }

        private void UserMinutes_Enter(object sender, EventArgs e)
        {
            if (UserMinutes.Text == "Минуты")
            {
                UserMinutes.Text = "";
                UserMinutes.ForeColor = Color.Black;
            }
        }

        private void UserMinutes_Leave(object sender, EventArgs e)
        {
            if (UserMinutes.Text == "")
            {
                UserMinutes.Text = "Минуты";
                UserMinutes.ForeColor = Color.Gray;
            }
        }
    }
}
