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
    class ClassTariff
    {
        public string mobileOperator;
        public string name;
        public string money;
        public string gigi;
        public string minutes;
    }
    class logic
    {
        public const string Path = "..\\DataBase.txt";
        public static void Lv(TextBox box, string text)
        {
            if (box.Text == "")
            {
                box.Text = text;
                box.ForeColor = Color.Gray;
            }
        }
        public static void Ent(TextBox box, string text)
        {
            if (box.Text == text)
            {
                box.Text = "";
                box.ForeColor = Color.Black;
            }
        }
    }
}
