using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
        public enum Operators { sum, sub, multi, div, equal }
    public partial class Form1 : Form
    {
        
        public double Result = 0;
        public bool newNum = true;
        public Operators op = Operators.sum;
        public string opBtn = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void numButton_click(object sender, EventArgs e)
        {
            Button numBtn = (Button)sender;
            Num(numBtn.Text);
        }
        public void Num(string num)
        {
            if(newNum)
            {
                screen1.Text = num;
                newNum = false;
            }
            else if(screen1.Text == "0" )
            {
                screen1.Text = num;
            }
            else
            {
                screen1.Text = screen1.Text + num;
            }
        }

        private void Add_click(object sender, EventArgs e)
        {
            // 사칙연산자 저장
            Button opBtn = (Button)sender;
            if (opBtn.Text == "+")
            {
                op = Operators.sum;
                newNum = false;
            }
            else if (opBtn.Text == "-")
            {
                op = Operators.sub;
                newNum = false;
            }
            else if (opBtn.Text == "x")
            {
                op = Operators.multi;
                newNum = false;
            }
            else if (opBtn.Text == "÷")
            {
                op = Operators.div;
                newNum = false;
            }
            else if (opBtn.Text == "=")
            {
                op = Operators.equal;
            }

            // ***사칙연산: A (연산자) B = 결과 ***
            // 계산 + - * / = 
            // ResultExist = true;
            if (newNum == false)
            {
                double num = double.Parse(screen1.Text);
                if (op == Operators.sum)
                {
                    Result = Result + num;
                }
                else if (op == Operators.sub)
                {
                    Result = Result - num;
                }
                else if (op == Operators.multi)
                {
                    Result = Result * num;
                }
                else if (op == Operators.div)
                {
                    Result = Result / num;
                }
                screen1.Text = Result.ToString();
                newNum = true;
            }

            screen2.Text = opBtn.Text;
        }

        private void back_Click(object sender, EventArgs e)
        {
            screen1.Text = screen1.Text.Substring(0, screen1.Text.Length - 1);
        }

        private void clean_Click(object sender, EventArgs e)
        {
            Result = 0;
            newNum = true;
            op = Operators.sum;

            screen1.Text = "0";
            screen2.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            screen1.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (screen1.Text.Contains("."))
            {
                return;
            }
            else
            {
                screen1.Text = screen1.Text + ".";
            }
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            double pmBtn = double.Parse(screen1.Text);

            pmBtn = -pmBtn;
            Result = -Result;

            screen1.Text = pmBtn.ToString();
        }
    }
}
