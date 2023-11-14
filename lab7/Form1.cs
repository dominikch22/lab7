using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        private ComplexNumber a;
        private ComplexNumber b;
        public Form1()
        {
            InitializeComponent();
        }

        private void updateAAndBNumbers() {
            if (aImaginaryTextBox.Text == "")
                a = double.Parse(aRealTextBox.Text);
            else
                a = new ComplexNumber(double.Parse(aRealTextBox.Text), double.Parse(aImaginaryTextBox.Text));
            if (bImaginaryTextBox.Text == "")
                b = double.Parse(bRealTextBox.Text);
            else
                b = new ComplexNumber(double.Parse(bRealTextBox.Text), double.Parse(bImaginaryTextBox.Text));
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a + b).ToString();
                errorLabel.Text = "";
                operationLabel.Text = "+";
            }
            catch (Exception ex) 
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a - b).ToString();
                errorLabel.Text = "";
                operationLabel.Text = "-";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a * b).ToString();
                errorLabel.Text = "";
                operationLabel.Text = "*";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a / b).ToString();
                errorLabel.Text = "";
                operationLabel.Text = "/";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void equelsButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a == b).ToString();
                operationLabel.Text = "=";
                errorLabel.Text = "";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void hashButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a.GetHashCode()).ToString();
                operationLabel.Text = "#";
                errorLabel.Text = "";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            a = null;
            b = null;
            aRealTextBox.Text = "";
            bRealTextBox.Text = "";

            aImaginaryTextBox.Text = "";
            bImaginaryTextBox.Text = "";

            operationLabel.Text = "";

            resultTextBox.Text = "";
        }

        private void biggerDistanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a > b).ToString();
                errorLabel.Text = "";
                operationLabel.Text = ">";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void samallerDistanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateAAndBNumbers();
                resultTextBox.Text = (a < b).ToString();
                errorLabel.Text = "";
                operationLabel.Text = "<";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}
