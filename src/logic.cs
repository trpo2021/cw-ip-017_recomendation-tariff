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
        public static bool isNumber(string str)
        {
            for (int i = 0; i < str.Length; ++i)
                if (str[i] > '9' || str[i] < '0')
                    return false;
            return true;
        }
        public static bool strLenghtIsNorm(string str)
        {
            if (str.Length > 0 && str.Length < 6)
                return true;
            return false;
        }
        public static bool isEmpty(TextBox box, string text)
        {
            if (box.Text == text)
            {
                MessageBox.Show(text);
                return true;
            }
            return false;
        }
        public static bool isCorectly(TextBox box, string text)
        {
            if (isEmpty(box, text))
                return false;
            if (!strLenghtIsNorm(box.Text))
                return false;
            if (!isNumber(box.Text))
            {
                box.Text = "";
                MessageBox.Show(text);
                return false;
            }
            return true;
        }
    }
}
