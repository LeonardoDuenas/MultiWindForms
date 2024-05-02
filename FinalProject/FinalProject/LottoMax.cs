using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        //directory declared globally
        string dir = @".\LottoFolder\", path = @".\LottoFolder\LottoNbrs.txt";

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo).ToString().Equals("Yes"))
            {
                this.Close();
            }
        }

        private void btn_GenerateNum_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            bool isDuplicate;
            int counter = 0, num, bonus;
            int[] numArray = new int[8];

            //Errasing the previous winning numbers
            label2.Text = "";

            //For random numbers
            for (int j = 0; j < numArray.Length; j++)
            {
                label2.Text += random.Next(1, 9);
            }

            //For unique numbers
            //using a flag
            while (counter < 8)
            {
                //Generate random numbers
                num = random.Next(1, 50);
                isDuplicate = false;

                //check the array
                for (int i = 0; i < counter; i++)
                {
                    if (num == numArray[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                //Add only if isDuplicate is false
                if (!isDuplicate)
                {
                    numArray[counter] = num;

                    //bonus number
                    if(counter == 8)
                    {
                        bonus = num;
                    }

                    counter++;
                }

                //Show the array with string.join
                textBox1.Text = String.Join("\t", numArray);
            }
            /*Writting the numbers in a textfile*/

            //Creating stream obj
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            //Creating a streamwrite obj
            StreamWriter textOut = new StreamWriter(fs);

            textOut.WriteLine($"Max, {DateTime.Now}, {String.Join(",", numArray)}  Bonus: {numArray[7]}");

            //closing streamwrite
            textOut.Close();
            fs.Close();
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            //For now, only shows last gen number
            string textToPrint = "";

            //Creating stream obj
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

            //Creating streamreader obj
            StreamReader textIn = new StreamReader(fs);

            //Reading
            while (textIn.Peek() != -1)
            {
                textToPrint += textIn.ReadLine() + "\n";
            }

            MessageBox.Show(textToPrint);

            //Closing everything
            textIn.Close();
            fs.Close();
        }

        private void LottoMax_Load(object sender, EventArgs e)
        {
            //Create directory on the same level as exe file
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
