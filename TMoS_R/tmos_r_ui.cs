using System;
using System.Windows.Forms;

namespace TMoS.R
{
    public partial class tmos_r_ui : Form
    {
        public tmos_r_ui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tmos_r_version = System.Windows.Forms.Application.ProductVersion;
            this.Text = String.Format("TMoS-R v.{0}", tmos_r_version);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Gameplay_Click(object sender, EventArgs e)
        {

        }
    }
}
