using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_9_24_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ExpressionLine_MouseDown(object sender, MouseEventArgs e)
        {
            if (ExpressionLine.Text == "Error" || ExpressionLine.Text == "Enter Expression")
                ExpressionLine.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ExpressionLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button14_Click(sender, e);
            else
            {
                if(ExpressionLine.Text == "Error")
                    ExpressionLine.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '1';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '+';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '3';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '4';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '6';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '7';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '8';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '9';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '0';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ExpressionLine.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ExpressionCalculator expressionCalculator = new ExpressionCalculator();
            try
            {
                ExpressionLine.Text = expressionCalculator.CarculateEpression(ExpressionLine.Text).ToString();
            }
            catch (Exception ex)
            {
                ExpressionLine.Text = "Error";
            }
        }
        private void GetLineReady()
        {
            if (ExpressionLine.Text == "Error")
                ExpressionLine.Text = "";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '-';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GetLineReady();
            ExpressionLine.Text += '/';
        }
    }
}
