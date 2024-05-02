using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System.IO;

namespace FinalProject
{
    public partial class IPValidator : Form
    {
        public IPValidator()
        {
            InitializeComponent();
        }

        const string dir = @".\IPdir\";

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().Equals("Yes"))
                this.Close();
        }

        private void IPValidator_Load(object sender, EventArgs e)
        {
            labelDate.Text = $"Today: {DateTime.Now.ToString()}";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_Validate_Click(object sender, EventArgs e)
        {
            /*IP validation regex*/
            Regex pattern = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");

            string adress = textBox1.Text;

            if (!pattern.IsMatch(adress))
            {
                MessageBox.Show($"{adress}\n This IP is not valid\n" +
                    $"IP must have 4 bytes\n" +
                    $"integer number between 0 to 255\n" +
                    $"Separated by '.'", "Validation");

                return;
            }

            MessageBox.Show($"{adress}\n This IP is correct", "Validation");

            /*binary writting*/
            FileStream fs = null;
            try
            {
                fs = new FileStream(dir + "IpFile.txt", FileMode.Append, FileAccess.Write);
                BinaryWriter binaryOut = new BinaryWriter(fs);

                binaryOut.Write(textBox1.Text.Trim());

                binaryOut.Close();
            } 
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IO Error");
            }
            finally { if (fs != null) fs.Close(); }
        }
    }
}
