namespace TMOS_Romhack
{
	partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_load_rom = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_output = new System.Windows.Forms.RichTextBox();
            this.btn_save_rom = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tb_seed = new System.Windows.Forms.TextBox();
            this.lbl_seed = new System.Windows.Forms.Label();
            this.btn_viewData = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.num_worldToView = new System.Windows.Forms.NumericUpDown();
            this.lbl_rom_status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_load_default_rom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_autogen = new System.Windows.Forms.Button();
            this.tb_autogen_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_autogen_choosepath = new System.Windows.Forms.Button();
            this.tb_autogen_folder = new System.Windows.Forms.TextBox();
            this.autogen_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_worldToView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_load_rom
            // 
            this.btn_load_rom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_rom.Location = new System.Drawing.Point(6, 12);
            this.btn_load_rom.Name = "btn_load_rom";
            this.btn_load_rom.Size = new System.Drawing.Size(133, 23);
            this.btn_load_rom.TabIndex = 0;
            this.btn_load_rom.Text = "Load ROM";
            this.btn_load_rom.UseVisualStyleBackColor = true;
            this.btn_load_rom.Click += new System.EventHandler(this.btn_load_rom_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(3, 287);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(262, 159);
            this.tb_output.TabIndex = 4;
            this.tb_output.Text = "";
            // 
            // btn_save_rom
            // 
            this.btn_save_rom.Enabled = false;
            this.btn_save_rom.Location = new System.Drawing.Point(146, 40);
            this.btn_save_rom.Name = "btn_save_rom";
            this.btn_save_rom.Size = new System.Drawing.Size(108, 23);
            this.btn_save_rom.TabIndex = 9;
            this.btn_save_rom.Text = "Patch ROM";
            this.btn_save_rom.UseVisualStyleBackColor = true;
            this.btn_save_rom.Click += new System.EventHandler(this.btn_save_rom_Click);
            // 
            // tb_seed
            // 
            this.tb_seed.Location = new System.Drawing.Point(108, 32);
            this.tb_seed.MaxLength = 5;
            this.tb_seed.Name = "tb_seed";
            this.tb_seed.Size = new System.Drawing.Size(65, 20);
            this.tb_seed.TabIndex = 10;
            // 
            // lbl_seed
            // 
            this.lbl_seed.AutoSize = true;
            this.lbl_seed.Location = new System.Drawing.Point(122, 16);
            this.lbl_seed.Name = "lbl_seed";
            this.lbl_seed.Size = new System.Drawing.Size(32, 13);
            this.lbl_seed.TabIndex = 11;
            this.lbl_seed.Text = "Seed";
            // 
            // btn_viewData
            // 
            this.btn_viewData.Location = new System.Drawing.Point(85, 10);
            this.btn_viewData.Name = "btn_viewData";
            this.btn_viewData.Size = new System.Drawing.Size(75, 23);
            this.btn_viewData.TabIndex = 12;
            this.btn_viewData.Text = "View Data";
            this.btn_viewData.UseVisualStyleBackColor = true;
            this.btn_viewData.Click += new System.EventHandler(this.btn_viewData_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(6, 29);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(96, 23);
            this.btn_modify.TabIndex = 13;
            this.btn_modify.Text = "Randomize ROM";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // num_worldToView
            // 
            this.num_worldToView.Location = new System.Drawing.Point(41, 11);
            this.num_worldToView.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_worldToView.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_worldToView.Name = "num_worldToView";
            this.num_worldToView.Size = new System.Drawing.Size(40, 20);
            this.num_worldToView.TabIndex = 14;
            this.num_worldToView.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_rom_status
            // 
            this.lbl_rom_status.AutoSize = true;
            this.lbl_rom_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_rom_status.Location = new System.Drawing.Point(145, 17);
            this.lbl_rom_status.Name = "lbl_rom_status";
            this.lbl_rom_status.Size = new System.Drawing.Size(91, 13);
            this.lbl_rom_status.TabIndex = 15;
            this.lbl_rom_status.Text = "ROM Not Loaded";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_load_default_rom);
            this.groupBox1.Controls.Add(this.btn_save_rom);
            this.groupBox1.Controls.Add(this.lbl_rom_status);
            this.groupBox1.Controls.Add(this.btn_load_rom);
            this.groupBox1.Location = new System.Drawing.Point(3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 69);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btn_load_default_rom
            // 
            this.btn_load_default_rom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_default_rom.Location = new System.Drawing.Point(7, 40);
            this.btn_load_default_rom.Name = "btn_load_default_rom";
            this.btn_load_default_rom.Size = new System.Drawing.Size(132, 23);
            this.btn_load_default_rom.TabIndex = 19;
            this.btn_load_default_rom.Text = "Load Default ROM";
            this.btn_load_default_rom.UseVisualStyleBackColor = true;
            this.btn_load_default_rom.Click += new System.EventHandler(this.btn_load_default_rom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_viewData);
            this.groupBox2.Controls.Add(this.num_worldToView);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(4, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 38);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "World";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_seed);
            this.groupBox3.Controls.Add(this.lbl_seed);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(36, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 57);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randomize Mod";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_autogen
            // 
            this.btn_autogen.Location = new System.Drawing.Point(79, 35);
            this.btn_autogen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_autogen.Name = "btn_autogen";
            this.btn_autogen.Size = new System.Drawing.Size(106, 20);
            this.btn_autogen.TabIndex = 19;
            this.btn_autogen.Text = "Generate Seeds";
            this.btn_autogen.UseVisualStyleBackColor = true;
            this.btn_autogen.Click += new System.EventHandler(this.btn_autogen_Click);
            // 
            // tb_autogen_amount
            // 
            this.tb_autogen_amount.Location = new System.Drawing.Point(34, 35);
            this.tb_autogen_amount.MaxLength = 5;
            this.tb_autogen_amount.Name = "tb_autogen_amount";
            this.tb_autogen_amount.Size = new System.Drawing.Size(41, 20);
            this.tb_autogen_amount.TabIndex = 14;
            this.tb_autogen_amount.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Amt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_autogen_choosepath);
            this.groupBox4.Controls.Add(this.tb_autogen_folder);
            this.groupBox4.Controls.Add(this.tb_autogen_amount);
            this.groupBox4.Controls.Add(this.btn_autogen);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 130);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(253, 89);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AutoGenerate Seeds";
            // 
            // btn_autogen_choosepath
            // 
            this.btn_autogen_choosepath.Location = new System.Drawing.Point(215, 16);
            this.btn_autogen_choosepath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_autogen_choosepath.Name = "btn_autogen_choosepath";
            this.btn_autogen_choosepath.Size = new System.Drawing.Size(33, 20);
            this.btn_autogen_choosepath.TabIndex = 21;
            this.btn_autogen_choosepath.Text = "...";
            this.btn_autogen_choosepath.UseVisualStyleBackColor = true;
            this.btn_autogen_choosepath.Click += new System.EventHandler(this.btn_autogen_choosepath_Click);
            // 
            // tb_autogen_folder
            // 
            this.tb_autogen_folder.Location = new System.Drawing.Point(8, 16);
            this.tb_autogen_folder.MaxLength = 5;
            this.tb_autogen_folder.Name = "tb_autogen_folder";
            this.tb_autogen_folder.Size = new System.Drawing.Size(207, 20);
            this.tb_autogen_folder.TabIndex = 20;
            // 
            // autogen_timer
            // 
            this.autogen_timer.Interval = 1000;
            this.autogen_timer.Tick += new System.EventHandler(this.autogen_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 443);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_worldToView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_load_rom;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.RichTextBox tb_output;
		private System.Windows.Forms.Button btn_load_enemygroups;
		private System.Windows.Forms.Button btn_save_rom;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox tb_seed;
		private System.Windows.Forms.Label lbl_seed;
        private System.Windows.Forms.Button btn_viewData;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.NumericUpDown num_worldToView;
        private System.Windows.Forms.Label lbl_rom_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_load_default_rom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_autogen;
        private System.Windows.Forms.TextBox tb_autogen_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_autogen_choosepath;
        private System.Windows.Forms.TextBox tb_autogen_folder;
        private System.Windows.Forms.Timer autogen_timer;
    }
}

