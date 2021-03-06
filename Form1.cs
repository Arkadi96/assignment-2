﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if(textBox_Result.Text=="0")
                textBox_Result.Clear();

            Button button=(Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button=(Button)sender;
            operationPerformed = button.Text;
            resultValue = double.Parse(textBox_Result.Text);
            textBox_Result.Clear();
        }

        private void CleanClick(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void ClearClick(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void EqualClick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
                  
                  
            }
        }
    }
}
