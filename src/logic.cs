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
        public string UnlimMessengers;
        public void setValueOf(ClassTariff tariff)
        {
            this.mobileOperator = tariff.mobileOperator;
            this.name = tariff.name;
            this.money = tariff.money;
            this.gigi = tariff.gigi;
            this.minutes = tariff.minutes;
            this.NumbersOfTV = tariff.NumbersOfTV;
            this.SMS = tariff.SMS;
            this.UnlimMessengers = tariff.UnlimMessengers;
        }
        public void setValueOf(string[] tariff)
        {
            this.mobileOperator = tariff[0];
            this.name = tariff[1];
            this.money = tariff[2];
            this.gigi = tariff[3];
            this.minutes = tariff[4];
            this.NumbersOfTV = tariff[5];
            this.SMS = tariff[5];
            this.UnlimMessengers = tariff[7];
        }
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
                                     + "Стоимость: " + strClass[2] + " руб/мес\n";
            if (strClass[3] == "999999")
                OutBox.Text += "Интернет: безлимит\n";
            else
                OutBox.Text += "Интернет: " + strClass[3] + " гиг/мес\n";
            OutBox.Text += "Звонки: " + strClass[4] + " мин/мес\n"
                + "ТВ каналы: " + strClass[5] + " штук\n"
                + "SMS: " + strClass[6] + "/месяц\n"
                 + "Безлимитные месенджеры: " + strClass[7] + "\n\n";
        }

        public static void OutTariff(RichTextBox OutBox, ClassTariff tariff)
        {
            OutBox.Text += "Оператор: " + tariff.mobileOperator + "\n"
                                     + "Тариф: " + tariff.name + "\n"
                                     + "Стоимость: " + tariff.money + " руб/мес\n";
            if (tariff.gigi == "999999")
                OutBox.Text += "Интернет: безлимит\n";
            else
                OutBox.Text += "Интернет: " + tariff.gigi + " гиг/мес\n";
            OutBox.Text += "Звонки: " + tariff.minutes + " мин/мес\n"
                + "ТВ каналы: " + tariff.NumbersOfTV + " штук\n"
                + "SMS: " + tariff.SMS + "/месяц\n"
                + "Безлимитные месенджеры: " + tariff.UnlimMessengers + "\n\n";
        }

        public static void UnlimitedCheckChanged(CheckBox cbox, TextBox tbox, string outStr)
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

        public static void TextBoxInit(TextBox box, string text)
        {
            box.Text = text;
            box.ForeColor = Color.Gray;
        }

        public static string[] ReadDBLine(string line)
        {
            string[] strClass = new string[8];
            int classUnit = 0;
            for (int i = 0; i < line.Length; ++i)
            {
                if (line[i] == ';')
                    classUnit++;
                else
                    strClass[classUnit] += line[i];
            }
            return strClass;
        }
    }
}
