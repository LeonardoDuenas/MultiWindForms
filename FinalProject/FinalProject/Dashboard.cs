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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LottoMax form = new LottoMax();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lotto649 form = new Lotto649();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MoneyEx form = new MoneyEx();
            form.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            IPValidator form = new IPValidator();
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Calculator form = new Calculator();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TempConv form = new TempConv();
            form.Show();
        }
    }
}
