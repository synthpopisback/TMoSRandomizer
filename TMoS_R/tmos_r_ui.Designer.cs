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
            this.checksum_copy_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRC_Label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Gameplay = new System.Windows.Forms.TabPage();
            this.Enemies = new System.Windows.Forms.TabPage();
            this.Misc = new System.Windows.Forms.TabPage();
            this.randomize_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.original_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output_button
            // 
            resources.ApplyResources(this.output_button, "output_button");
            this.output_button.Name = "output_button";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // checksum_copy_button
            // 
            resources.ApplyResources(this.checksum_copy_button, "checksum_copy_button");
            this.checksum_copy_button.Name = "checksum_copy_button";
            this.checksum_copy_button.UseVisualStyleBackColor = true;
            this.checksum_copy_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
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
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Gameplay);
            this.tabControl1.Controls.Add(this.Enemies);
            this.tabControl1.Controls.Add(this.Misc);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Gameplay
            // 
            resources.ApplyResources(this.Gameplay, "Gameplay");
            this.Gameplay.Name = "Gameplay";
            this.Gameplay.UseVisualStyleBackColor = true;
            this.Gameplay.Click += new System.EventHandler(this.Gameplay_Click);
            // 
            // Enemies
            // 
            resources.ApplyResources(this.Enemies, "Enemies");
            this.Enemies.Name = "Enemies";
            this.Enemies.UseVisualStyleBackColor = true;
            // 
            // Misc
            // 
            resources.ApplyResources(this.Misc, "Misc");
            this.Misc.Name = "Misc";
            this.Misc.UseVisualStyleBackColor = true;
            // 
            // randomize_button
            // 
            resources.ApplyResources(this.randomize_button, "randomize_button");
            this.randomize_button.Name = "randomize_button";
            this.randomize_button.UseVisualStyleBackColor = true;
            this.randomize_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // about_button
            // 
            resources.ApplyResources(this.about_button, "about_button");
            this.about_button.Name = "about_button";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.About_Click);
            // 
            // original_button
            // 
            resources.ApplyResources(this.original_button, "original_button");
            this.original_button.Name = "original_button";
            this.original_button.UseVisualStyleBackColor = true;
            this.original_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tmos_r_ui
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.original_button);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.randomize_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CRC_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checksum_copy_button);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tmos_r_ui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Button checksum_copy_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CRC_Label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Gameplay;
        private System.Windows.Forms.TabPage Enemies;
        private System.Windows.Forms.TabPage Misc;
        private System.Windows.Forms.Button randomize_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button original_button;
    }
}

