using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            timer1.Start();
            BackgroundImage = Image.FromFile("..\\images\\IconTariff.png");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Opacity += 0.1d;
            }
        }
    }
}
