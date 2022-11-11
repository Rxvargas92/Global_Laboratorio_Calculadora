using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        string ERROR_MSG = "Sintax Error";
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";



            tBox_front.Text = text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

            tBox_front.Text = text + "0";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tBox_front.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                text = "";

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
            if (text.Equals(ERROR_MSG))
                text = "";

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
            if (text.Equals(ERROR_MSG))
                tBox_front.Text = "";

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
                tBox_front.Text = text + "-";

            }
            else
            {
                tBox_front.Text = text + "-";
            }


        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            String text = tBox_front.Text;
            if (text.Equals(ERROR_MSG))
                tBox_front.Text = "";

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
            if (text.Equals(ERROR_MSG))
                tBox_front.Text = "";

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
            if (text.Equals(ERROR_MSG))
                tBox_front.Text = "";

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
            //   goal --> 23 + (4 * (9 * (40 + 2334))) / 8 === 10706
            //   goal --> 5(7 + 6 / (18 / 9) + 10 / 2

            tBox_front.Text = init(tBox_front.Text);

        }

        public string init(string text)
        {
            try
            {

                if (text.Equals(ERROR_MSG))
                    tBox_front.Text = "";


                text = add_pharenteses(text);
                while (text.IndexOf("(") != -1)
                {
                    text = delete_pharenteses(text);

                    if (Regex.IsMatch(text, pattern: @"^\d*$") || Regex.IsMatch(text, pattern: @"^[a-zA-Z\s]"))
                    {
                        break;
                    }
                    if (Regex.IsMatch(text, pattern: @"^-\d*$") && text.StartsWith("-"))
                    {
                        break;
                    }
                    if (text.Contains(")"))
                    {
                        if (!Regex.IsMatch(text.Substring(text.IndexOf(")") + 1, 1), pattern: @"^[-*/+]*$"))
                        {
                            text = ERROR_MSG;
                            break;
                        }
                    }
                    if (text.EndsWith("-") || text.EndsWith("+") || text.EndsWith("*") || text.EndsWith("/") || text.EndsWith("(")) { text = ERROR_MSG; break; }



                    if (text.Contains("("))
                    {
                        if (text.Substring(text.IndexOf("(") - 1,1) != "*")
                        {
                            text = text.Insert(text.IndexOf("("), "*");
                        }
                    }

                    text = add_pharenteses(text);
                    string calculo_aux = find_pharenteses(text);

                    if (calculo_aux.StartsWith("-") && Regex.IsMatch(calculo_aux, pattern: @"^[-\d]*$"))
                    {
                        calculo_aux = delete_pharenteses(calculo_aux);
                        text = text.Replace(add_pharenteses(calculo_aux), calculo_aux);
                        calculo_aux = find_pharenteses(add_pharenteses(text));
                    }

                    calculo_aux = add_pharenteses(calculo_aux);
                    calculo_aux = delete_pharenteses(calculo_aux);
                    if (calculo_aux.Contains(")") && calculo_aux.IndexOf(")") < calculo_aux.IndexOf("(") || amount_pharenteses_left(calculo_aux) == 0 && calculo_aux.Contains(")"))
                    {
                        calculo_aux = calculo_aux.Remove(calculo_aux.IndexOf(")"), 1);
                    }
                    if ((calculo_aux.Contains("(") && calculo_aux.IndexOf("(") < calculo_aux.IndexOf(")") || amount_pharenteses_right(calculo_aux) == 0 && calculo_aux.Contains("(")))
                    {
                        calculo_aux = calculo_aux.Remove(calculo_aux.IndexOf("("), 1);
                    }

                    string pre_calculo = calculo_aux;

                    calculo_aux = add_pharenteses(calculo_aux);

                    calculo_aux = find_operators(calculo_aux); // comparar operadores

                    string calculo_resulto = solve(calculo_aux);


                    if (amount_operators(pre_calculo) > 1) { calculo_aux = delete_pharenteses(calculo_aux); }


                    text = text.Replace(calculo_aux, calculo_resulto);

                    text = delete_pharenteses(text);
                    if (text.Contains(")") && text.IndexOf(")") < text.IndexOf("(") || amount_pharenteses_left(text) == 0 && text.Contains(")"))
                    {
                        text = text.Remove(text.IndexOf(")"), 1);
                    }
                    if (text.Contains("(") && text.IndexOf("(") < text.IndexOf(")") || amount_pharenteses_right(text) == 0 && text.Contains("("))
                    {
                        text = text.Remove(text.IndexOf("("), 1);
                    }

                    text = add_pharenteses(text);

                    if (amount_pharenteses_left(calculo_aux) == 1 && amount_pharenteses_right(calculo_aux) == 1)
                    {
                        calculo_aux = delete_pharenteses(calculo_aux);
                    }

                    text = text.Replace(calculo_aux, calculo_resulto);

                }

                text = add_pharenteses(text);
                text = delete_pharenteses(text);
                return text;
            }
            catch (Exception e)
            {
                return "coming soon";
            }
        }
        public int amount_operators(string text)
        {
            int amount = 0;

            if (text.IndexOf("-") != -1) { amount++; }
            if (text.IndexOf("+") != -1) { amount++; }
            if (text.IndexOf("*") != -1) { amount++; }
            if (text.IndexOf("/") != -1) { amount++; }

            return amount;
        }

        public string find_operators(string text)
        {

            //  ( 2 + 3 - 4 * 5 / 6)

            if (text.IndexOf("+") < text.IndexOf("*") || text.IndexOf("+") < text.IndexOf("/"))
            {
                text = text.Substring(text.IndexOf("+") + 1);
            }

            if (text.IndexOf("/") < text.IndexOf("*"))
            {
                text = text.Substring(text.IndexOf("/") + 1);
            }
            if (text.IndexOf("*") < text.IndexOf("/"))
            {
                text = text.Substring(text.IndexOf("*") + 1);
            }

            if (text.IndexOf("+") < text.IndexOf("-"))
            {
                text = text.Substring(text.IndexOf("+") + 1);
            }

            if (text.IndexOf("*") != -1) { text = delete_multiplication(text); }
            if (text.IndexOf("-") != -1) { text = delete_less(text); }
            if (text.IndexOf("/") != -1) { text = delete_div(text); }
            if (text.IndexOf("+") != -1) { text = delete_sum(text); }

            if (text.IndexOf("*") < text.IndexOf("+") || text.IndexOf("*") < text.IndexOf("-"))
            {
                if (text.IndexOf("*") == -1) { return text; }
                if (text.IndexOf("+") != -1) { text = text.Substring(0, text.IndexOf("+")); }
                if (text.IndexOf("*") + 1 == text.IndexOf("-")) { return text; }
                if (text.IndexOf("-") != -1)
                {
                    text = add_pharenteses(text);
                    text = delete_pharenteses(text);
                    if (!text.StartsWith("-"))
                    {
                        text = text.Substring(0, text.IndexOf("-"));
                    }

                }

            }
            if (text.IndexOf("/") < text.IndexOf("+") || text.IndexOf("/") < text.IndexOf("-"))
            {
                if (text.IndexOf("/") == -1) { return text; }
                if (text.IndexOf("+") != -1) { text = text.Substring(0, text.IndexOf("+")); }
                if (text.IndexOf("-") != -1) { text = text.Substring(0, text.IndexOf("-")); }

            }

            if (text.StartsWith("-")) { return text; }

            if (text.IndexOf("-") < text.IndexOf("+"))
            {
                text = text.Substring(text.IndexOf("-") + 1);
            }

            if (text.IndexOf("-") < text.IndexOf("*") || text.IndexOf("-") < text.IndexOf("/"))
            {
                text = text.Substring(text.IndexOf("-") + 1);
            }

            text = add_pharenteses(text);
            return text;
        }

        public string delete_multiplication(string text)
        {
            string pre = text;
            string aux = "";
            while (pre.IndexOf("*") != -1)
            {
                if (pre.IndexOf("*") != -1)
                {
                    aux = pre;
                }
                pre = pre.Substring(pre.IndexOf("*") + 1);
            }
            if (aux.IndexOf("*") != -1)
            {
                return add_pharenteses(aux);
            }
            return pre;
        }

        public string delete_sum(string text)
        {
            string pre = text;
            string aux = "";
            while (pre.IndexOf("+") != -1)
            {
                if (pre.IndexOf("+") != -1)
                {
                    aux = pre;
                }
                pre = pre.Substring(pre.IndexOf("+") + 1);
            }
            if (aux.IndexOf("+") != -1)
            {
                return add_pharenteses(aux);
            }
            return pre;
        }

        public string delete_less(string text)
        {
            string pre = text;
            string aux = "";
            while (pre.IndexOf("-") != -1)
            {
                if (pre.IndexOf("-") != -1)
                {
                    aux = pre;
                }
                pre = pre.Substring(pre.IndexOf("-") + 1);
            }
            if (aux.IndexOf("-") != -1)
            {
                return add_pharenteses(aux);
            }
            return pre;
        }

        public string delete_div(string text)
        {
            string pre = text;
            string aux = "";
            while (pre.IndexOf("/") != -1)
            {
                if (pre.IndexOf("/") != -1)
                {
                    aux = pre;
                }
                pre = pre.Substring(pre.IndexOf("/") + 1);
            }
            if (aux.IndexOf("/") != -1)
            {
                return add_pharenteses(aux);
            }
            return pre;
        }

        // retorna el parentensis mas interno       //!// (9)
        public string find_pharenteses(string text)
        {
            string aux = text.Substring(text.IndexOf("(") + 1, text.IndexOf(")") - 1);

            if (Regex.IsMatch(aux, pattern: @"^\d*$"))
            {
                string number_alone = "";
                number_alone = aux;
                number_alone = number_alone + text.Substring(text.IndexOf(")") + 1);
                return number_alone;
            }
            if (text.IndexOf("(") == -1) { return text; }

            while (text.IndexOf("(") != -1)
            {
                text = text.Substring(text.IndexOf("(") + 1);
            }

            text = text.Substring(0, text.IndexOf(")"));

            return text;
        }

        public int amount_pharenteses_left(string text)
        {
            int amount = 0;
            while (text.IndexOf("(") != -1)
            {
                text = text.Substring(text.IndexOf("(") + 1);
                amount++;
            }
            return amount;
        }

        public int amount_pharenteses_right(string text)
        {
            int amount = 0;
            while (text.IndexOf(")") != -1)
            {
                text = text.Substring(text.IndexOf(")") + 1);
                amount++;
            }
            return amount;
        }


        // resuleve una ecuacion simple de suma de dos numeros ( 14+8 | 1444444+81423423 )
        public string solve(string text)
        {

            text = add_pharenteses(text);
            text = delete_pharenteses(text);

            if (Regex.IsMatch(text, pattern: @"^\d*$"))
            {
                return text;
            }
            if (text.StartsWith("+") || text.StartsWith("*") || text.StartsWith("/")) { return ERROR_MSG; }

            if (amount_pharenteses_left(text) == 0 && text.Contains(")"))
            {
                text = text.Remove(text.IndexOf(")"), 1);
            }

            if (amount_pharenteses_right(text) == 0 && text.Contains("("))
            {
                text = text.Remove(text.IndexOf("("), 1);
            }

            int num1;
            int num2;
            string operador = char_operator(text);
            if (operador == ERROR_MSG) { return ERROR_MSG; }
            int index = index_operator(text);

            num1 = Convert.ToInt32(text.Substring(0, index));

            num2 = Convert.ToInt32(text.Substring(index + 1));



            do
            {
                if (operador.Contains("+"))
                {
                    text = Convert.ToString(num1 + num2);
                }
                else if (operador.Contains("-"))
                {
                    text = Convert.ToString(num1 - num2);
                }
                else if (operador.Contains("*"))
                {
                    text = Convert.ToString(num1 * num2);
                }
                else if (operador.Contains("/"))
                {
                    if (num2 < 1)
                    {
                        text = ERROR_MSG;
                        break;
                    }
                    text = Convert.ToString(num1 / num2);
                }
            } while (false);



            return text;
        }

        // elimina parentesis al principio y al final del @string que se mande
        public string delete_pharenteses(string text)
        {
            if (text.StartsWith("(") && text.EndsWith(")"))
            {
                return text.Substring(1, text.Length - 2);
            }

            return text;
        }

        // retorna el index del operador que este dentro del @string ( hecho solo con + ) // (9)+7
        public int index_operator(string text)
        {
            bool aux_less = false;
            if (text.StartsWith("-"))
            {
                aux_less = true;
                text = text.Substring(1);
            }

            string[] list = { "*", "/", "+", "-" };
            int index = -1;

            if (text.Contains(")"))
            {
                if (text.Substring(text.IndexOf(")") + 1, 1) != "-" && text.Substring(text.IndexOf(")") + 1, 1) != "+" && text.Substring(text.IndexOf(")") + 1, 1) != "/" && text.Substring(text.IndexOf(")") + 1, 1) != "*") { return -2; }

            }

            for (int i = 0; i < text.Length + 1; i++)
            {
                if (index != -1)
                { break; }
                index = text.IndexOf(list[i]);
            }
            if (aux_less)
            {
                text = "-" + text;
                return index + 1;
            }
            return index;
        }

        // retorna un char con el operador
        public string char_operator(string text)
        {
            int index = index_operator(text);
            if (index == -2) { return ERROR_MSG; }
            return text.Substring(index, 1);
        }


        // agrega parentesis al principio y al final del @string que se mande
        public string add_pharenteses(string text)
        {
            if (!text.StartsWith("(") && !text.EndsWith(")"))
            {
                text = text.Insert(0, "(").Insert(text.Length + 1, ")");
            }
            else if (!text.StartsWith("("))
            {
                text = text.Insert(0, "(");
            }
            else if (!text.EndsWith(")"))
            {
                text = text.Insert(text.Length, ")");
            }
            return text;
        }
    }
}
