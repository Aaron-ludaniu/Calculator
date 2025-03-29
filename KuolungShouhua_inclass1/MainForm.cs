/*
 * Project Name: KuolungShouhua_InClass1
 * Purpose: Build a calculator app
 * Students: Kuolung Cheng, Shouhua Lu - Section 3
 * Revision History:
 *   v1.0.0, 2024-05-13: First release
 *   v1.0.1, 2024-05-14: Check the divide by zero error
 *   v2.0, 2024-05-15: Increase program robustness
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuolungShouhua_inclass1
{
    public partial class MainForm : Form
    {
        private double x = 0;
        private string pendingOperation = "";
        private bool isNewNumber = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void operandClick(object sender, EventArgs e)
        {
            if (isNewNumber == true)
            {
                txtResult.Text = "";
                lblProcess.Text = "";
                isNewNumber = false;
            }

            string operand = ((Button)sender).Text;

            if (txtResult.Text == "" && operand == ".")
            {
                txtResult.Text = "0.";
            }
            else if (txtResult.Text.Contains(".") && operand == ".")
            {
                txtResult.Text = txtResult.Text;
            }
            else if (txtResult.Text == "0" && operand == "0")
            {
                txtResult.Text = txtResult.Text;
            }
            else if (txtResult.Text == "0" && operand != ".")
            {
                txtResult.Text = operand;
            }
            else
            {
                txtResult.Text = txtResult.Text + operand;
            }
        }

        private void operatorClick(object sender, EventArgs e)
        {
            string pendingOperation = ((Button)sender).Text;

            if (this.pendingOperation == "" && txtResult.Text != "")
            {
                this.pendingOperation = pendingOperation;
                this.x = Convert.ToDouble(txtResult.Text);
                txtResult.Text = "";
                lblProcess.Text = this.x + " " + pendingOperation;
            }
            else if (this.pendingOperation != "" && txtResult.Text == "") 
            {
                this.pendingOperation = pendingOperation;
                lblProcess.Text = this.x + " " + pendingOperation;
            }
            else if (this.pendingOperation != "" && txtResult.Text != "")
            {
                double result = GetCalculateResult();

                this.pendingOperation = pendingOperation;
                this.x = result;

                txtResult.Text = "";
                lblProcess.Text = result + " " + pendingOperation;
            }
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            if ((this.pendingOperation == "/") && (txtResult.Text == "0")) 
            {
                lblProcess.Text = this.x + " " + this.pendingOperation + " " + txtResult.Text + " = ";

                txtResult.Text = "The divisor cannot be 0";

                this.x = 0;
                this.pendingOperation = "";
                this.isNewNumber = true;
            }
            else if ((this.pendingOperation != "") && (txtResult.Text != ""))
            {
                double result = GetCalculateResult();

                lblProcess.Text = this.x + " " + this.pendingOperation + " " + txtResult.Text + " = " + result;

                txtResult.Text = result.ToString();

                this.x = 0;
                this.pendingOperation = "";
                this.isNewNumber = true;
            }
            else 
            {
                MessageBox.Show("Stupid! Please enter the correct format");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblProcess.Text = "";
            this.x = 0;
            this.pendingOperation = "";
            this.isNewNumber = true;
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            if (this.isNewNumber == true)
            {
                clearBtn_Click(sender, e);
            }
            else 
            {
                txtResult.Text = "0";
            }
        }

        private double GetCalculateResult()
        {
            double result = 0;
            switch (this.pendingOperation)
            {
                case "+":
                    result = this.x + Convert.ToDouble(txtResult.Text);
                    break;
                case "-":
                    result = this.x - Convert.ToDouble(txtResult.Text);
                    break;
                case "*":
                    result = this.x * Convert.ToDouble(txtResult.Text);
                    break;
                case "/":
                    result = this.x / Convert.ToDouble(txtResult.Text);
                    break;
            }
            return result;
        }
    }
}
