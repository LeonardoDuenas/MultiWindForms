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
    public partial class MoneyEx : Form
    {
        public MoneyEx()
        {
            InitializeComponent();
        }

        const string dir = @".\MoneyEx\";

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().Equals("Yes"))
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exchange rate: 

            string fromCurrency = "", toCurrency = "";
            decimal amountToConvert = 0, exchangeRate = 0, convertedAmount;

            try
            {
                amountToConvert = Convert.ToDecimal(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            if (fromCAD.Checked && toCAD.Checked || fromUSD.Checked && toUSD.Checked || fromEUR.Checked && toEUR.Checked || fromGBP.Checked && toGBP.Checked || fromPEN.Checked && toPEN.Checked)
            {
                exchangeRate = 1;
            }
            else
            {
                if (fromCAD.Checked)
                {
                    fromCurrency = "CAD";

                    if (toUSD.Checked)
                    {
                        exchangeRate = 0.74m;
                        toCurrency = "USD";
                    }
                    else if (toEUR.Checked)
                    {
                        exchangeRate = 0.68m;
                        toCurrency = "EUR";
                    }
                    else if (toGBP.Checked)
                    {
                        exchangeRate = 0.60m;
                        toCurrency = "GBP";
                    }
                    else if (toPEN.Checked)
                    {
                        exchangeRate = 2.78m;
                        toCurrency = "PEN";
                    }
                }
                else if (fromUSD.Checked)
                {
                    fromCurrency = "USD";
                    
                    if (toCAD.Checked)
                    {
                        exchangeRate = 1.35m;
                        toCurrency = "CAD";
                    }
                    else if (toEUR.Checked)
                    {
                        exchangeRate = 0.92m;
                        toCurrency = "EUR";
                    }
                    else if (toGBP.Checked)
                    {
                        exchangeRate = 0.80m;
                        toCurrency = "GBP";
                    }
                    else if (toPEN.Checked)
                    {
                        exchangeRate = 3.75m;
                        toCurrency = "PEN";
                    }
                }
                else if (fromEUR.Checked)
                {
                    fromCurrency = "EUR";
                    
                    if (toCAD.Checked)
                    {
                        exchangeRate = 1.47m;
                        toCurrency = "CAD";
                    }
                    else if (toUSD.Checked)
                    {
                        exchangeRate = 1.09m;
                        toCurrency = "USD";
                    }
                    else if (toGBP.Checked)
                    {
                        exchangeRate = 0.88m;
                        toCurrency = "GBP";
                    }
                    else if (toPEN.Checked)
                    {
                        exchangeRate = 4.09m;
                        toCurrency = "PEN";
                    }
                }
                else if (fromGBP.Checked)
                {
                    fromCurrency = "GBP";
                    
                    if (toCAD.Checked)
                    {
                        exchangeRate = 1.68m;
                        toCurrency = "CAD";
                    }
                    else if (toUSD.Checked)
                    {
                        exchangeRate = 1.24m;
                        toCurrency = "USD";
                    }
                    else if (toEUR.Checked)
                    {
                        exchangeRate = 1.14m;
                        toCurrency = "EUR";
                    }
                    else if (toPEN.Checked)
                    {
                        exchangeRate = 4.66m;
                        toCurrency = "PEN";
                    }
                }
                else if (fromPEN.Checked)
                {
                    fromCurrency = "PEN";
                    
                    if (toCAD.Checked)
                    {
                        exchangeRate = 0.36m;
                        toCurrency = "CAD";
                    }
                    else if (toUSD.Checked)
                    {
                        exchangeRate = 0.26m;
                        toCurrency = "USD";
                    }
                    else if (toEUR.Checked)
                    {
                        exchangeRate = 0.24m;
                        toCurrency = "EUR";
                    }
                    else if (toGBP.Checked)
                    {
                        exchangeRate = 0.21m;
                        toCurrency = "GBP";
                    }
                }
            }

            convertedAmount = amountToConvert * exchangeRate;

            textBox2.Text = convertedAmount.ToString();

            //Write file
            FileStream fs = null;

            try
            {
                fs = new FileStream(dir + "MoneyEx.txt", FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);

                if (textBox1.Text == textBox2.Text)
                {
                    textOut.WriteLine($"{textBox2.Text}, {DateTime.Now}");
                }
                else
                {
                    textOut.WriteLine($"{textBox1.Text} {fromCurrency} = {textBox2.Text} {toCurrency}, {DateTime.Now}");
                }

                textOut.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IO Error");
            }
            finally { if (fs != null) fs.Close(); }

        }

        private void MoneyEx_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textToPrint = "";

            FileStream fs = null;

            try
            {
                fs = new FileStream(dir + "MoneyEx.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                //Reading
                while (textIn.Peek() != -1)
                {
                    textToPrint += textIn.ReadLine() + "\n";
                }

                MessageBox.Show(textToPrint);

                //Closing everything
                textIn.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IO Error");
            }
            finally { if (fs != null) fs.Close(); }
        }
    }
}
