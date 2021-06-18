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
        public string NumbersOfTV;
        public string SMS;


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
            if (str.Length <= 6)
                return true;
            return false;
        }
        public static bool isEmpty(string boxText, string text)
        {
            if (boxText == text)
                return true;
            return false;
        }
        public static bool isCorectly(TextBox box, string text)
        {
            if (isEmpty(box.Text, text))
            {
                box.Text = "";
                MessageBox.Show("Не все поля заполнены");
                return false;
            }
            if (!strLenghtIsNorm(box.Text))
            {
                box.Text = "999999";
                MessageBox.Show("Входные данные не могут быть больше 999999");
                return false;
            }
            if (!isNumber(box.Text))
            {
                box.Text = "";
                MessageBox.Show("Вводите только числа");
                return false;
            }
            return true;
        }
        public static void OutTariff(RichTextBox OutBox, string[] strClass)
        {
            OutBox.Text += "Оператор: " + strClass[0] + "\n"
                                     + "Тариф: " + strClass[1] + "\n"
                                     + "Стоимотсь: " + strClass[2] + " руб/мес\n";
            if (strClass[3] == "999999")
                OutBox.Text += "Интернет: безлимит\n";
            else
                OutBox.Text += "Интернет: " + strClass[3] + " гиг/мес\n";
            OutBox.Text += "Звонки: " + strClass[4] + " мин/мес\n\n";
        }
        public static void OutTariff(RichTextBox OutBox, ClassTariff tariff)
        {
            OutBox.Text += "Оператор: " + tariff.mobileOperator + "\n"
                                     + "Тариф: " + tariff.name + "\n"
                                     + "Стоимотсь: " + tariff.money + " руб/мес\n";
            if (tariff.gigi == "999999")
                OutBox.Text += "Интернет: безлимит\n";
            else
                OutBox.Text += "Интернет: " + tariff.gigi + " гиг/мес\n";
            OutBox.Text += "Звонки: " + tariff.minutes + " мин/мес\n\n";
        }
        public static void UnlimitedCheckChanged(CheckBox cbox,TextBox tbox, string outStr)
        {
            if (cbox.Checked == true)
            {
                tbox.Text = "999999";
                tbox.ForeColor = Color.Black;
            }
            else
            {
                tbox.Text = outStr;
                tbox.ForeColor = Color.Gray;
            }
        }
        public static void UnlimitedCheckLeave(CheckBox cbox, TextBox tbox)
        {
            if (tbox.Text == "999999")
                cbox.Checked = true;
            else
                cbox.Checked = false;
        }
    }
}
