namespace TMoS.R
{
    partial class tmos_r_ui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tmos_r_ui));
            this.output_button = new System.Windows.Forms.Button();
            this.original_location_field = new System.Windows.Forms.TextBox();
            this.output_location_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRC_Label = new System.Windows.Forms.Label();
            this.crc_field = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Gameplay = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Enemies = new System.Windows.Forms.TabPage();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.Misc = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.randomize_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.original_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flags_field = new System.Windows.Forms.TextBox();
            this.seed_field = new System.Windows.Forms.TextBox();
            this.seed_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Gameplay.SuspendLayout();
            this.Enemies.SuspendLayout();
            this.Misc.SuspendLayout();
            this.SuspendLayout();
            // 
            // output_button
            // 
            resources.ApplyResources(this.output_button, "output_button");
            this.output_button.Name = "output_button";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.output_button_click_1);
            // 
            // original_location_field
            // 
            resources.ApplyResources(this.original_location_field, "original_location_field");
            this.original_location_field.Name = "original_location_field";
            // 
            // output_location_field
            // 
            resources.ApplyResources(this.output_location_field, "output_location_field");
            this.output_location_field.Name = "output_location_field";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CRC_Label
            // 
            resources.ApplyResources(this.CRC_Label, "CRC_Label");
            this.CRC_Label.Name = "CRC_Label";
            this.CRC_Label.Click += new System.EventHandler(this.CRC_Label_Click);
            // 
            // crc_field
            // 
            resources.ApplyResources(this.crc_field, "crc_field");
            this.crc_field.Name = "crc_field";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Gameplay);
            this.tabControl1.Controls.Add(this.Enemies);
            this.tabControl1.Controls.Add(this.Misc);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Gameplay
            // 
            this.Gameplay.BackColor = System.Drawing.SystemColors.Control;
            this.Gameplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gameplay.Controls.Add(this.checkedListBox1);
            resources.ApplyResources(this.Gameplay, "Gameplay");
            this.Gameplay.Name = "Gameplay";
            this.Gameplay.Click += new System.EventHandler(this.Gameplay_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            resources.GetString("checkedListBox1.Items"),
            resources.GetString("checkedListBox1.Items1"),
            resources.GetString("checkedListBox1.Items2"),
            resources.GetString("checkedListBox1.Items3"),
            resources.GetString("checkedListBox1.Items4")});
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.TabStop = false;
            // 
            // Enemies
            // 
            this.Enemies.BackColor = System.Drawing.SystemColors.Control;
            this.Enemies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enemies.Controls.Add(this.checkedListBox2);
            resources.ApplyResources(this.Enemies, "Enemies");
            this.Enemies.Name = "Enemies";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.checkedListBox2, "checkedListBox2");
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            resources.GetString("checkedListBox2.Items"),
            resources.GetString("checkedListBox2.Items1"),
            resources.GetString("checkedListBox2.Items2"),
            resources.GetString("checkedListBox2.Items3"),
            resources.GetString("checkedListBox2.Items4"),
            resources.GetString("checkedListBox2.Items5")});
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.TabStop = false;
            // 
            // Misc
            // 
            this.Misc.BackColor = System.Drawing.SystemColors.Control;
            this.Misc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Misc.Controls.Add(this.label5);
            this.Misc.Controls.Add(this.comboBox1);
            this.Misc.Controls.Add(this.checkedListBox3);
            resources.ApplyResources(this.Misc, "Misc");
            this.Misc.Name = "Misc";
            this.Misc.Click += new System.EventHandler(this.Misc_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Sorted = true;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.checkedListBox3, "checkedListBox3");
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            resources.GetString("checkedListBox3.Items"),
            resources.GetString("checkedListBox3.Items1")});
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.TabStop = false;
            // 
            // randomize_button
            // 
            resources.ApplyResources(this.randomize_button, "randomize_button");
            this.randomize_button.Name = "randomize_button";
            this.randomize_button.UseVisualStyleBackColor = true;
            this.randomize_button.Click += new System.EventHandler(this.randomize_button_click);
            // 
            // about_button
            // 
            resources.ApplyResources(this.about_button, "about_button");
            this.about_button.Name = "about_button";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_click);
            // 
            // original_button
            // 
            resources.ApplyResources(this.original_button, "original_button");
            this.original_button.Name = "original_button";
            this.original_button.UseVisualStyleBackColor = true;
            this.original_button.Click += new System.EventHandler(this.original_button_click_1);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // flags_field
            // 
            resources.ApplyResources(this.flags_field, "flags_field");
            this.flags_field.Name = "flags_field";
            // 
            // seed_field
            // 
            resources.ApplyResources(this.seed_field, "seed_field");
            this.seed_field.Name = "seed_field";
            // 
            // seed_button
            // 
            resources.ApplyResources(this.seed_button, "seed_button");
            this.seed_button.Name = "seed_button";
            this.seed_button.UseVisualStyleBackColor = true;
            this.seed_button.Click += new System.EventHandler(this.seed_button_click);
            // 
            // tmos_r_ui
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seed_button);
            this.Controls.Add(this.seed_field);
            this.Controls.Add(this.flags_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.original_button);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.randomize_button);
            this.Controls.Add(this.crc_field);
            this.Controls.Add(this.CRC_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_location_field);
            this.Controls.Add(this.original_location_field);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tmos_r_ui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Gameplay.ResumeLayout(false);
            this.Enemies.ResumeLayout(false);
            this.Misc.ResumeLayout(false);
            this.Misc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.TextBox original_location_field;
        private System.Windows.Forms.TextBox output_location_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CRC_Label;
        private System.Windows.Forms.TextBox crc_field;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Gameplay;
        private System.Windows.Forms.TabPage Enemies;
        private System.Windows.Forms.TabPage Misc;
        private System.Windows.Forms.Button randomize_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button original_button;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flags_field;
        private System.Windows.Forms.TextBox seed_field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button seed_button;
    }
}

