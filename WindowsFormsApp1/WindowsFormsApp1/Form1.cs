using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функции
        // is_standart() - проверка на число 1-9
        // is_non_standart() - проверка на число 10-19
        // is_tens() - проверка на десятки 20-90
        // check_next() - проверка, нет ли после корректно записанного числа в строке никаких других лишних записей
        // check_previous() - проверка, не записано ли число одинакового разряда два раза подряд
        // convert_to_roman() - перевод числа в римские цифры

        // Массив control [i] - хранит информацию о том, какие разряды чисел были записаны на каждом шаге
        // control[i] = 1 - предыдущее число 1-9
        // control[i] = 2 - предыдущее число десятки 20-90
        // control[i] = 3 - предыдущая запись hundred

        public int is_standart(string type)
        {
            switch (type)
            {
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                return -1;

            }
        }

        public int is_non_standart(string type)
        {
            switch (type)
            {
                case "ten":
                    return 10;
                case "eleven":
                    return 11;
                case "twelve":
                    return 12;
                case "thirteen":
                    return 13;
                case "fourteen":
                    return 14;
                case "fifteen":
                    return 15;
                case "sixteen":
                    return 16;
                case "seventeen":
                    return 17;
                case "eighteen":
                    return 18;
                case "nineteen":
                    return 19;
                 default:
                    return -1;
             }
        }

        public int is_tens(string type)
        {
            switch (type)
            {
                case "twenty":
                    return 2;
                case "thirty":
                    return 3;
                case "forty":
                    return 4;
                case "fifty":
                    return 5;
                case "sixty":
                    return 6;
                case "seventy":
                    return 7;
                case "eighty":
                    return 8;
                case "ninety":
                    return 9;
                default:
                    return -1;
            }
            }

        public void check_next(int i, ref string[] mas)
        {
            if (i < (mas.Length - 1))
                Text_errors.Text = "После " + "'"+mas[i]+"' не может быть введено никаких записей.";
        }

        public bool check_previous(int previous, string current)
        {
            if ((is_standart(current) != -1) && (previous == 1) ||
                (is_tens(current) != -1) && (previous == 2))
            {
                Text_errors.Text = "Не может быть введено подряд два числа одинакового разряда.";
                return true;
            }
            else if ((current == "hundred") && (previous == 3))
            {
                Text_errors.Text = "Cлово 'hundred' не может быть введено два раза подряд.";
                return true;
            }
            else return false;
        }

        public void convert_to_roman(int number)
        {
            int[] ar = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] ro = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            int i = 0;
            string result = "";
           
            while (number > 0)
            {
                if (ar[i] <= number)
                {
                    number = number - ar[i];
                    result += ro[i];
                }
                else i++;
            }
            Text_Roman.Text = result;
        }

        private void BTN_TRNSLT_Click(object sender, EventArgs e)
        {
            Text_string.Text = Text_string.Text.ToLower();
            Text_Numbers.Text = "";
            Text_Roman.Text = "";
            Text_errors.Text = "";

            int i = 0;
            bool cycle = true;
            bool hundred = false;
            string tmp = null;
            string[] check = Text_string.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] control = new int[check.Length];

            while (cycle)
            { cycle = false;

                if (check.Length == 0) // Начало шага 1
                {
                    Text_errors.Text = "Число не введено.";
                    return;
                }
                else if (check[i] == "zero")
                {
                    tmp = "0";
                    Text_Numbers.Text = tmp;
                    check_next(i, ref check);
                    return;
                }
                else if (is_standart(check[i]) != -1)
                {
                    tmp = is_standart(check[i]).ToString();
                    control[i] = 1;
                }
                else if (is_non_standart(check[i]) != -1)
                {
                    tmp = is_non_standart(check[i]).ToString();
                    Text_Numbers.Text = tmp;
                    check_next(i, ref check);
                    break;
                }
                else if (is_tens(check[i]) != -1)
                {
                    tmp = is_tens(check[i]).ToString();
                    control[i] = 2;
                }
                else
                {
                    Text_errors.Text = "Число " + "'" + check[i] + "' введено неправильно.";
                    return;
                }

                if (i < (check.Length - 1)) // Начало шага 2
                {
                    i++;
                    if (check_previous(control[i - 1], check[i])) return;
                    else if ((is_standart(check[i - 1]) != -1) && (is_tens(check[i]) != -1))
                    {
                        Text_errors.Text = "В записи после числа единичного формата не может быть числа десятичного формата.";
                        return;
                    }
                    else if ((is_tens(check[i - 1]) != -1) && (check[i] == "hundred"))
                    {
                        Text_errors.Text = "После числа десятичного формата не должно стоять слово 'hundred'.";
                        return;
                    }
                    else if (check[i] == "hundred")
                    {
                        hundred = true;
                        control[i] = 3;
                    }
                    else if (is_standart(check[i]) != -1)
                    {
                        tmp += is_standart(check[i]).ToString();
                        Text_Numbers.Text = tmp;
                        check_next(i, ref check);
                        break;
                    }
                    else
                    {
                        if (control[i - 1] == 1)
                        {
                            Text_errors.Text = "Число " + "'" + check[i] + "' введено неправильно. Если это трехзначное число, то после числа единичного формата должно стоять слово 'hundred'.";
                            return;
                        }
                        else if (control[i - 1] == 2)
                        {
                            Text_errors.Text = "Число " + "'" + check[i] + "' введено неправильно. Если это двузначное число, состоящее из двух слов, то после числа десятичного формата должно стоять число единичного формата.";
                            return;
                        }
                    }
                }
                else
                {
                    if (is_standart(check[i]) != -1)
                    {
                        Text_Numbers.Text = tmp;
                        break;
                    }
                    else if (is_tens(check[i]) != -1)
                    {
                        tmp += "0";
                        Text_Numbers.Text = tmp;
                        break;
                    }
                }

                if (i < (check.Length - 1)) // Начало шага 3
                {
                    i++;
                    if (check_previous(control[i - 1], check[i])) return;
                    else if (is_standart(check[i]) != -1)
                    {
                        tmp += "0";
                        tmp += is_standart(check[i]).ToString();
                        Text_Numbers.Text = tmp;
                        check_next(i, ref check);
                        break;
                    }
                    else if (is_non_standart(check[i]) != -1)
                    {
                        tmp += is_non_standart(check[i]).ToString();
                        Text_Numbers.Text = tmp;
                        check_next(i, ref check);
                        break;
                    }
                    else if (is_tens(check[i]) != -1)
                    {
                        tmp += is_tens(check[i]).ToString();
                        control[i] = 2;
                    }
                    else
                    {
                        Text_errors.Text = "Число" + "'" + check[i] + "' введено неправильно. Если это трехзначное число, состоящее из 3-ех или 4-ех слов, то после слова 'hundred' должно быть записано либо число единичного формата, либо число десятичного формата.";
                        return;
                    }
                }
                else
                {
                    if (hundred)
                    {
                        tmp += "00";
                        Text_Numbers.Text = tmp;
                        break;
                    }
                }

                if (i < (check.Length - 1)) // Начало шага 4
                {
                    i++;
                    if (check_previous(control[i - 1], check[i])) return;
                    else if (is_standart(check[i]) != -1)
                    {
                        tmp += is_standart(check[i]).ToString();
                        Text_Numbers.Text = tmp;
                        check_next(i, ref check);
                        break;
                    }
                    else
                    {
                        Text_errors.Text = "Число" + "'" + check[i] + "' введено неправильно. Если это трехзначное число, состоящее из четырех слов, то после числа десятичного формата должно быть записано число единичного формата.";
                        return;
                    }
                }
                else
                {
                    if (is_tens(check[i]) != -1)
                    {
                        tmp += "0";
                        Text_Numbers.Text = tmp;
                        break;
                    }
                }
            }

            convert_to_roman(Convert.ToInt32(tmp));
        }
    }
}
