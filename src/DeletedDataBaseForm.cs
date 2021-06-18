using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class DeletedDataBaseForm : Form
    {
        public DeletedDataBaseForm()
        {
            InitializeComponent();
            Icon = new Icon("..\\images\\iconTariff.ico");
            IconPicture.Image = Image.FromFile("..\\images\\iconTariff.png");
            logic.TextBoxInit(DeletedOperator, "Введите оператора");
            logic.TextBoxInit(DeletedTariff, "Введите название тарифа");
        }

        Point LastPoint;

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MinimizeButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeletedOperator_Enter(object sender, EventArgs e)
        {
            logic.Ent(DeletedOperator, "Введите оператора");
        }

        private void DeletedOperator_Leave(object sender, EventArgs e)
        {
            logic.Lv(DeletedOperator, "Введите оператора");
        }

        private void DeletedTariff_Enter(object sender, EventArgs e)
        {
            logic.Ent(DeletedTariff, "Введите название тарифа");
        }

        private void DeletedTariff_Leave(object sender, EventArgs e)
        {
            logic.Lv(DeletedTariff, "Введите название тарифа");
        }

        private void StartDeletingButton_Click(object sender, EventArgs e)
        {
            if (DeletedOperator.Text == "Введите оператора")
            {
                MessageBox.Show("Введите оператора");
                return;
            }
            if (DeletedTariff.Text == "Введите название тарифа")
            {
                MessageBox.Show("Введите название тарифа");
                return;
            }
            Queue<string> localDB = new Queue<string>();
            using (StreamReader sr = new StreamReader(logic.Path))
            {
                string[] strClass = new string[8];
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    strClass = logic.ReadDBLine(line);
                    if (strClass[0] != DeletedOperator.Text && strClass[1] != DeletedTariff.Text)
                        localDB.Enqueue(strClass[0] + ";" + strClass[1] + ";" + strClass[2] + ";" + strClass[3] + ";" + strClass[4] + ";" + strClass[5] + ";" + strClass[6] + ";" + strClass[7]);

                    for (int i = 0; i < strClass.Length; ++i)
                        strClass[i] = "";
                }
            }

            using (StreamWriter sr = new StreamWriter(logic.Path, false))
            {
                while (localDB.Count != 0)
                    sr.WriteLine(localDB.Dequeue());
            }
            this.Close();
        }
    }
}
