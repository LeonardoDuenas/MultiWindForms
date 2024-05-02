/*Current problem with the calculator, only supports 2 numbers operand*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        ClassCalc calcObj = new ClassCalc();
        const string dir = @".\Calculator\";

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exti?", "Exit", MessageBoxButtons.YesNo).ToString().Equals("Yes"))
                this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            calcObj.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string result = "", textToPrint;
            string[] operation = textBox1.Text.Split(' ');

            try
            {
                calcObj.Operand1 = Convert.ToDecimal(operation[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                textBox1.Text = "";
                calcObj.Clear();
                return;
            }

            try
            {
                calcObj.Operand2 = Convert.ToDecimal(operation[2]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                textBox1.Text = "";
                calcObj.Clear();
            }

            switch (operation[1])
            {
                case "+":
                    result = calcObj.Addition().ToString("N2"); //N2
                    textBox1.Text = result;
                    break;
                case "-":
                    result = calcObj.Substraction().ToString("N2");
                    textBox1.Text = result;
                    break;
                case "*":
                    result = calcObj.Multiplication().ToString("N2");
                    textBox1.Text = result;
                    break;
                case "/":
                    result = calcObj.Division().ToString("N2");
                    textBox1.Text = result;
                    break;
                default:
                    MessageBox.Show("Operation not accepted", "Error");
                    break;
            }

            /*Write text*/
            textToPrint = $"{operation[0]} {operation[1]} {operation[2]} = {result}";

            FileStream fs = null;

            try
            {
                fs = new FileStream(dir + "Calculator.txt", FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);

                textOut.WriteLine(textToPrint);

                textOut.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IO Error");
            }
            finally { if (fs != null) fs.Close(); }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
