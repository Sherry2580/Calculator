using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小算盤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sum = "0";
        string op = "";    // 目前的運算符號
        bool isNew = true;    // 下一個數字要不要重新開始

        private void number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;
            if (isNew)
            {
                textBox1.Text = num;
                isNew = false;
            }
            else
            {
                textBox1.Text += num;
            }

        }

        private void symbol_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string symbol = btn.Text;

            if (symbol == ".")
            {
                if (isNew)
                {
                    textBox1.Text = "0.";
                    isNew = false;
                }
                else
                {
                    textBox1.Text += ".";
                }
            }
            else if (symbol == "C")
            {
                sum = "0";
                op = "";
                isNew = true;
                label1.Text = "";
                textBox1.Text = "0";
            }
            else if (symbol == "+" || symbol == "-" || symbol == "x" || symbol == "/")
            {
                Calculate();
                label1.Text = sum + " " + symbol + " ";
                textBox1.Text = sum.ToString();
                op = symbol;
                isNew = true;
            }
            else if (symbol == "=")
            {
                string last = textBox1.Text;     // 先記住最後輸入的數字

                Calculate();

                label1.Text = label1.Text + last + " = ";
                textBox1.Text = sum.ToString();
                op = "";
                isNew = true;
            }

        }

        private void Calculate()
        {
            Calc calc = new Calc();
            calc.Number = sum;  // sum 是string
            calc.Number2 = textBox1.Text;
            calc.op = op;
            sum = calc.Calculation();
        }

    }
}
