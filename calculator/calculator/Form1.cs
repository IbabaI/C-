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
        public double num1 = 0;
        public double num2;
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

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void clean_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {

        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void plusMinus_Click(object sender, EventArgs e)
        {

        }
    }
}
