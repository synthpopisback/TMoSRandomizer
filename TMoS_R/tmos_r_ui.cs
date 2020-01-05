using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

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
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, true);
            checkedListBox1.SetItemChecked(3, true);
            checkedListBox1.SetItemChecked(4, false);
            checkedListBox2.SetItemChecked(0, true);
            checkedListBox2.SetItemChecked(1, false);
            checkedListBox2.SetItemChecked(2, false);
            checkedListBox2.SetItemChecked(3, false);
            checkedListBox2.SetItemChecked(4, false);
            checkedListBox2.SetItemChecked(5, false);
            checkedListBox3.SetItemChecked(0, false);
            checkedListBox3.SetItemChecked(1, false);
            comboBox1.SelectedIndex = 4;
            flags_field.Text = Properties.Settings.Default.DefaultFlags;
            original_location_field.Text = Properties.Settings.Default.OriginalRom;
            output_location_field.Text = Properties.Settings.Default.OutputRom;
        }

        private void original_button_click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                original_location_field.Text = openFileDialog1.FileName;
            }
        }
    
        private void output_button_click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                output_location_field.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes) result += b.ToString("x2");
            return result;
        }

        private void seed_button_click(object sender, EventArgs e)
        {
            Random seed_generator = new Random();
            int newseed = seed_generator.Next(0, 1000000000);
            seed_field.Text = newseed.ToString();
        }

        private void randomize_button_click(object sender, EventArgs e)
        {
            if (original_location_field.Text == "")
            {

            }
            else
            {
                using (MD5 output_file_checksum = MD5.Create())
                {
                    using (FileStream stream = File.OpenRead(original_location_field.Text))
                    {
                        crc_field.Text = BytesToString(output_file_checksum.ComputeHash(stream));
                    }
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox send_box = sender as CheckedListBox;
            int flags_count = Properties.Settings.Default.FlagsCount;
            string[] default_flags_string = new string[13] { "SP", "SH", "LO", "ES", "LR", "EL", "EH", "EX", "2X", "HE", "LE", "FR", "RP" };
            string new_flags_string = "";
            bool[] flag_index = new bool[13]
            {
                checkedListBox1.GetItemChecked(0),
                checkedListBox1.GetItemChecked(1),
                checkedListBox1.GetItemChecked(2),
                checkedListBox1.GetItemChecked(3),
                checkedListBox1.GetItemChecked(4),
                checkedListBox2.GetItemChecked(0),
                checkedListBox2.GetItemChecked(1),
                checkedListBox2.GetItemChecked(2),
                checkedListBox2.GetItemChecked(3),
                checkedListBox2.GetItemChecked(4),
                checkedListBox2.GetItemChecked(5),
                checkedListBox3.GetItemChecked(0),
                checkedListBox3.GetItemChecked(1)
            };

            if(send_box.Name == "checkedListBox1")
            {
                if (e.NewValue == CheckState.Checked)
                {
                    flag_index[e.Index] = true;
                }
                else
                {
                    flag_index[e.Index] = false;
                }
            }

            if (send_box.Name == "checkedListBox2")
            {
                if (e.NewValue == CheckState.Checked)
                {
                    flag_index[e.Index + 5] = true;
                }
                else
                {
                    flag_index[e.Index + 5] = false;
                }
            }

            if (send_box.Name == "checkedListBox3")
            {
                if (e.NewValue == CheckState.Checked)
                {
                    flag_index[e.Index + 11] = true;
                }
                else
                {
                    flag_index[e.Index + 11] = false;
                }
            }

            for (int x = 0; x < flags_count; x++)
            {
                if (flag_index[x] == true)
                {
                    new_flags_string = String.Concat(new_flags_string, default_flags_string[x]);
                }
            }
            flags_field.Text = new_flags_string;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void tmos_r_ui_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OriginalRom = original_location_field.Text;
            Properties.Settings.Default.OutputRom = output_location_field.Text;
            Properties.Settings.Default.Save();
        }
    }
}
