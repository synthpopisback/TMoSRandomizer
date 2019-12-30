namespace TMoSRandomizerTracker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ch1tab = new System.Windows.Forms.TabPage();
            this.ch2tab = new System.Windows.Forms.TabPage();
            this.ch3tab = new System.Windows.Forms.TabPage();
            this.ch4tab = new System.Windows.Forms.TabPage();
            this.ch5tab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ch1tab);
            this.tabControl1.Controls.Add(this.ch2tab);
            this.tabControl1.Controls.Add(this.ch3tab);
            this.tabControl1.Controls.Add(this.ch4tab);
            this.tabControl1.Controls.Add(this.ch5tab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 764);
            this.tabControl1.TabIndex = 0;
            // 
            // ch1tab
            // 
            this.ch1tab.BackColor = System.Drawing.SystemColors.Control;
            this.ch1tab.Location = new System.Drawing.Point(4, 22);
            this.ch1tab.Name = "ch1tab";
            this.ch1tab.Padding = new System.Windows.Forms.Padding(3);
            this.ch1tab.Size = new System.Drawing.Size(776, 738);
            this.ch1tab.TabIndex = 0;
            this.ch1tab.Text = "Chapter 1";
            this.ch1tab.Click += new System.EventHandler(this.ch1tab_Click);
            // 
            // ch2tab
            // 
            this.ch2tab.BackColor = System.Drawing.SystemColors.Control;
            this.ch2tab.Location = new System.Drawing.Point(4, 22);
            this.ch2tab.Name = "ch2tab";
            this.ch2tab.Padding = new System.Windows.Forms.Padding(3);
            this.ch2tab.Size = new System.Drawing.Size(776, 713);
            this.ch2tab.TabIndex = 1;
            this.ch2tab.Text = "Chapter 2";
            // 
            // ch3tab
            // 
            this.ch3tab.BackColor = System.Drawing.SystemColors.Control;
            this.ch3tab.Location = new System.Drawing.Point(4, 22);
            this.ch3tab.Name = "ch3tab";
            this.ch3tab.Size = new System.Drawing.Size(776, 713);
            this.ch3tab.TabIndex = 2;
            this.ch3tab.Text = "Chapter 3";
            // 
            // ch4tab
            // 
            this.ch4tab.BackColor = System.Drawing.SystemColors.Control;
            this.ch4tab.Location = new System.Drawing.Point(4, 22);
            this.ch4tab.Name = "ch4tab";
            this.ch4tab.Size = new System.Drawing.Size(776, 713);
            this.ch4tab.TabIndex = 3;
            this.ch4tab.Text = "Chapter 4";
            // 
            // ch5tab
            // 
            this.ch5tab.BackColor = System.Drawing.SystemColors.Control;
            this.ch5tab.Location = new System.Drawing.Point(4, 22);
            this.ch5tab.Name = "ch5tab";
            this.ch5tab.Size = new System.Drawing.Size(776, 713);
            this.ch5tab.TabIndex = 4;
            this.ch5tab.Text = "Chapter 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TMoS-R Tracker";
            this.Load += new System.EventHandler(this.Tracker_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ch1tab;
        private System.Windows.Forms.TabPage ch2tab;
        private System.Windows.Forms.TabPage ch3tab;
        private System.Windows.Forms.TabPage ch4tab;
        private System.Windows.Forms.TabPage ch5tab;
    }
}

