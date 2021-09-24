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
                button1_Click(sender, e);
        }
    }
}
