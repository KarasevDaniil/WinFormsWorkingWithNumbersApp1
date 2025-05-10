using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsWorkingWithNumbersApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _arithmeticOperator;
        double a;
        double b;
        int c;
        int d = 2;
        List<string> answ = new List<string>();
        int rez;
        string answ_s;
        string answ_string;
        double answer;
        bool erorrEnterA;
        bool erorrEnterB;
        bool erorrEnterC;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _arithmeticOperator = comboBox1.Text;
        }

        public void textBoxA_TextChanged(object sender, EventArgs e)
        {
            string _a = textBoxA.Text;
            if (textBoxA.Text != "")
            {
                try
                {
                    a = double.Parse(_a);
                    erorr_A.Text = "";
                    erorrEnterA = false;
                }
                catch { erorr_A.Text = "Введите число"; erorrEnterA = true; }
            }
        }

        private void textBoxA_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "введите число")
                textBoxA.Clear();
        }

        public void textBoxB_TextChanged(object sender, EventArgs e)
        {
            string _b = textBoxB.Text;
            if (textBoxB.Text != "")
            {
                try
                {
                    b = double.Parse(_b);
                    erorr_B.Text = "";
                    erorrEnterB = false;
                }
                catch { erorr_B.Text = "Введите число"; erorrEnterB = true; }
            }
        }

        private void textBoxB_Click(object sender, EventArgs e)
        {
            if (textBoxB.Text == "введите число")
                textBoxB.Clear();
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            // Для проверки на наличие чисел в полях
            if (textBoxA.Text == "введите число") { erorrEnterA = true; }
            if (textBoxB.Text == "введите число") { erorrEnterB = true; }

            // Проверка на наличие арифметического знака
            if (_arithmeticOperator == "  +" || _arithmeticOperator == "  −" ||
                _arithmeticOperator == "  ×" || _arithmeticOperator == "  ÷")
            {
                erorr_Answ.Text = "";

                // Проверка на наличие чисел в полях
                if (erorrEnterA != true && erorrEnterB != true)
                {
                    erorr_Answ.Text = "";

                    if (_arithmeticOperator == "  +")
                    {
                        answer = a + b;
                        textBoxAnsw.Text = answer.ToString();
                    }

                    if (_arithmeticOperator == "  −")
                    {
                        answer = a - b;
                        textBoxAnsw.Text = answer.ToString();
                    }

                    if (_arithmeticOperator == "  ×")
                    {
                        answer = a * b;
                        textBoxAnsw.Text = answer.ToString();
                    }

                    if (_arithmeticOperator == "  ÷")
                    {
                        answer = a / b;
                        textBoxAnsw.Text = answer.ToString();
                    }
                }

                else
                {
                    erorr_Answ.Text = "Введите числа";
                }
            }
            else
            {
                erorr_Answ.Text = "Выберите арифметическое действие";
            }

        }

        // Разложение на простые множители

        public void EnterForDecomposition_TextChanged(object sender, EventArgs e)
        {
            string _c = EnterForDecomposition.Text;
            if (EnterForDecomposition.Text != "")
            {
                try
                {
                    c = int.Parse(_c);
                    erorr_C.Text = "";
                    erorrEnterC = false;
                }
                catch { erorr_C.Text = "Введите число"; erorrEnterC = true; }
            }
        }

        private void EnterForDecomposition_Click(object sender, EventArgs e)
        {
            if (EnterForDecomposition.Text == "введите число")
                EnterForDecomposition.Clear();
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            label4.Text = $"Простые множители числа {c}";

            // Для проверки на наличие чисел в полях
            if (EnterForDecomposition.Text == "введите число") { erorrEnterC = true; }

            if (erorrEnterC != true)
            {
                erorr_Answ2.Text = "";

                rez = 0;
                answ_s = "";
                answ_string = "";
                answ.Clear();

                primeFactors.Clear();
                while (c > 1)
                {
                    if (c % d == 0)
                    {
                        rez = d;
                        answ.Add(rez.ToString());
                        c /= d;
                        d = 2;
                    }

                    else
                    {
                        d++;
                    }
                }

                for (int i = 0; i < answ.Count; i++)
                {
                    answ_s = answ[i];
                    answ_string = answ_string + answ_s + ";";
                }
                primeFactors.Text = answ_string;

                
            }

            else
            {
                erorr_Answ2.Text = "Введите число";
                label4.Text = "";
            }
        }
    }
}
