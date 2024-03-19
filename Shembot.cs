using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shembot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "1";
            this.txtoutput.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "2";
            this.txtoutput.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "9";
            this.txtoutput.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
        
             string temp= txtoutput.Text;
             if (temp.Length != 0)
             {
                 txtoutput.Text = temp.Substring(1);
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "3";
            this.txtoutput.Text += input;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                txtoutput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtoutput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtoutput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtoutput.Text = result.ToString();
                }
                else
                {
                    txtoutput.Text = "DIV/Zero!";
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "4";
            this.txtoutput.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "5";
            this.txtoutput.Text += input;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "6";
            this.txtoutput.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "7";
            this.txtoutput.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "8";
            this.txtoutput.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            input += "0";
            this.txtoutput.Text += input;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            txtoutput.Text += ".";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
            
        }

        private void buttonOpenP_Click(object sender, EventArgs e)
        {
            txtoutput.Text += "(";
        }

        private void buttonCloseP_Click(object sender, EventArgs e)
        {
            txtoutput.Text += ")";
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            this.txtoutput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
