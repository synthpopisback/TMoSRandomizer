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

        private void Form1_Load(object sender, EventArgs e) // Set default values
        {
            string tmos_r_version = System.Windows.Forms.Application.ProductVersion;
            this.Text = String.Format("TMoS-R v.{0}", tmos_r_version);
            // string tmos_r_flags = "LOESEL";
            flags_field.Text = Properties.Settings.Default.DefaultFlags;
            checkedListBox1.SetItemChecked(2, true);
            checkedListBox1.SetItemChecked(3, true);
            checkedListBox2.SetItemChecked(0, true);
            comboBox1.SelectedIndex = 4;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gameplay_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Misc_Click(object sender, EventArgs e)
        {

        }

        private void CRC_Label_Click(object sender, EventArgs e)
        {

        }
        
        private void original_button_click_1(object sender, EventArgs e)
        {
            original_location_field.Text = "This should be your original ROM.";
        }

        private void output_button_click_1(object sender, EventArgs e)
        {
            output_location_field.Text = "This should be your output ROM.";
        }

        private void seed_button_click(object sender, EventArgs e)
        {
            seed_field.Text = "This should be a random number.";
        }

        private void randomize_button_click(object sender, EventArgs e)
        {
            crc_field.Text = "This should be a checksum.";
        }

        private void about_button_click(object sender, EventArgs e)
        {

        }
    }
}
