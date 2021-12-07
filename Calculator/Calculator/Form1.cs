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
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || isOperationPerformed)
                textBoxResult.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + button.Text;
            }
            else
                textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button17.PerformClick();
                operationPerformed = button.Text;
                labelOperationPerformed.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(textBoxResult.Text);
                labelOperationPerformed.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void ResultButtonClick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBoxResult.Text);
            labelOperationPerformed.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
