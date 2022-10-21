using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            tBox_front.Text = text + "0";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tBox_front.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Length == 0)
            {
                tBox_front.Text = "";
            }
            else
            {
                tBox_front.Text = text.Substring(0, text.Length - 1);
            }

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            do
            {
                if (text.Length == 0)
                {
                    tBox_front.Text = "";
                }
                else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[0-9()]+$"))
                {
                    tBox_front.Text = text + "+";
                }
                else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[-]+$"))
                {
                    String new_text = text.Substring(0, text.Length - 1);
                    tBox_front.Text = new_text.Trim();
                    break;
                }
                else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[*+/]+$"))
                {
                    tBox_front.Text = text.Substring(0, text.Length - 1) + "+";
                }
            } while (false);
        }

        private void btn_less_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Length == 0)
            {
                tBox_front.Text = "-";
            }
            else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[+]+$"))
            {
                tBox_front.Text = text.Substring(0, text.Length - 1) + "-";

            }
            else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[*/-]+$"))
            {
                tBox_front.Text = text + "(-";

            }
            else
            {
                tBox_front.Text = text + "-";
            }


        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Length == 0)
            {
                tBox_front.Text = "";
            }
            else
            {
                if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[0-9)]+$"))
                {
                    tBox_front.Text = text + "*";
                }
                else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[*+/]+$"))
                {
                    tBox_front.Text = text.Substring(0, text.Length - 1) + "*";
                }
                else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[-]+$"))
                {
                    tBox_front.Text = text.Substring(0, text.Length - 1);
                }
            }


        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Length == 0)
            {
                tBox_front.Text = "";
            }
            else
            {
                if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[0-9)]+$"))
                {
                    tBox_front.Text = text + "/";
                }
                else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[*+/]+$"))
                {
                    tBox_front.Text = text.Substring(0, text.Length - 1) + "/";
                }
                else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[-]+$"))
                {
                    tBox_front.Text = text.Substring(0, text.Length - 1);
                }

            }
        }

        private void btn_parentheses_Click(object sender, EventArgs e)
        {

            String text = tBox_front.Text;
            if (text.Length == 0)
            {
                tBox_front.Text = "(";
            }
            else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[0-9]+$"))
            {
                tBox_front.Text = text + ")";
            }
            else if (Regex.IsMatch(text.Substring(text.Length - 1), pattern: @"^[*+\-/]+$"))
            {
                tBox_front.Text = text + "(";
            }
            else
            {
                tBox_front.Text = text.Substring(0, text.Length - 1) + "(";
            }

        }

        private void tBox_front_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            //   goal --> 23 + (4 * (-9 * (40 + 2334))) / 8

            String text = tBox_front.Text; //(14+8) or (1444444+81423423)

            //text = add_pharenteses(text);

            tBox_front.Text = add_pharenteses(text);

            //text = delete_pharenteses(text);

            //tBox_front.Text = solve(text);
        }

        // resuleve una ecuacion simple de suma de dos numeros ( 14+8 | 1444444+81423423 )
        public string solve(string text)
        {
            int num1;
            int num2;

            num1 = Convert.ToInt32(text.Substring(0, find_operator(text)));
            num2 = Convert.ToInt32(text.Substring(find_operator(text)));

            text = Convert.ToString(num1 + num2);

            return text;
        }

        // elimina parentesis al principio y al final del @string que se mande
        public string delete_pharenteses(string text)
        {
            return text.Substring(1, text.Length - 2);
        }

        // retorna el index del operador que este dentro del @string ( hecho solo con + ) 
        public int find_operator(string text)
        {
            return text.IndexOf('+');
        }


        // agrega parentesis al principio y al final del @string que se mande
        public string add_pharenteses(string text)
        {
            if (!text.Substring(0, 1).Equals("(") && !text.Substring(text.Length - 1).Equals(")"))
            {
                text = text.Insert(0, "(").Insert(text.Length + 1, ")");
            }
            else if (!text.Substring(0, 1).Equals("("))
            {
                text = text.Insert(0, "(");
            }
            else if (!text.Substring(text.Length - 1).Equals(")"))
            {
                text = text.Insert(text.Length, ")");
            }
            return text;
        }
    }
}
