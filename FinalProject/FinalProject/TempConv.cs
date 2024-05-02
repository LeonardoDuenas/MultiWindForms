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
    public partial class TempConv : Form
    {
        public TempConv()
        {
            InitializeComponent();
        }

        string path = @".\TempConv\";

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().Equals("Yes"))
                this.Close();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            decimal temperature = Convert.ToDecimal(textBox1.Text), celsiusTemp = 0, fahrenheitTemp = 0;
            int roundedCelTemp = 0;

            textBox3.Text = "";
            
            if (btn_Cel_to_Far.Checked)
            {
                label_left.Text = "C°";
                label_right.Text = "F°";

                celsiusTemp = temperature;

                roundedCelTemp = (int)celsiusTemp;

                fahrenheitTemp = (temperature * 1.8m) + 32m;

                textBox2.Text = fahrenheitTemp.ToString("N1");
            }
            else
            {
                label_left.Text = "F°";
                label_right.Text = "C°";

                fahrenheitTemp = temperature;

                celsiusTemp = (temperature - 32) * (5m/9m);

                roundedCelTemp = (int)celsiusTemp;

                textBox2.Text = celsiusTemp.ToString("N1");
            }

            //This is necessary so that the font color changes in a ReadOnly textbox
            textBox3.BackColor = textBox3.BackColor;

            switch (roundedCelTemp)
            {
                case 100:  
                    textBox3.ForeColor = Color.Red;
                    textBox3.Text = "Water boils";
                    break;
                case 40:
                    textBox3.ForeColor = Color.Red;
                    textBox3.Text = "Hot bath";
                    break;
                case 37:
                    textBox3.ForeColor = Color.Green;
                    textBox3.Text = "Body temperature";
                    break;
                case 30:
                    textBox3.ForeColor = Color.Green;
                    textBox3.Text = "Beach weather";
                    break;
                case var i when (i >= 11 && i <= 29):
                    textBox3.ForeColor = Color.Green;
                    textBox3.Text = "Room temperature";
                    break;
                case 10:
                    textBox3.ForeColor = Color.Blue;
                    textBox3.Text = "Cool day";
                    break;
                case 0:
                    textBox3.ForeColor = Color.Blue;
                    textBox3.Text = "Freezing point of water";
                    break;
                case var i when (i >= -39 && i <= -1):
                    textBox3.ForeColor = Color.Blue;
                    textBox3.Text = "Very cold day";
                    break;
                case -40:
                    textBox3.ForeColor = Color.Blue;
                    textBox3.Text = "Extremely cold temperature (and the same number!)";
                    break;
                default:
                    textBox3.Text = "";
                    break;
            }

            //Write file

            FileStream fs = null;

            try
            {
                fs = new FileStream(path + "tempNum.txt", FileMode.Append, FileAccess.Write);

                StreamWriter textOut = new StreamWriter(fs);

                textOut.WriteLine($"{textBox1.Text} {label_left.Text} = {textBox2.Text} {label_right.Text}, {DateTime.Now} {textBox3.Text}");

                textOut.Close();
            } 
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IO Error");
            }
            finally { if (fs != null) fs.Close(); }
        }

        private void TempConv_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            string textToPrint = "";
            FileStream fs = null;

            try
            {
                fs = new FileStream(path + "tempNum.txt", FileMode.OpenOrCreate, FileAccess.Read);
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

        private void btn_Far_to_Cel_CheckedChanged(object sender, EventArgs e)
        {
            label_left.Text = "F°";
            label_right.Text = "C°";
        }

        private void btn_Cel_to_Far_CheckedChanged(object sender, EventArgs e)
        {
            label_left.Text = "C°";
            label_right.Text = "F°";
        }
    }
}
