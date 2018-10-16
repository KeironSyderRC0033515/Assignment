namespace Assignment
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.r1value = new System.Windows.Forms.TextBox();
            this.r4value = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.r2value = new System.Windows.Forms.TextBox();
            this.r3value = new System.Windows.Forms.TextBox();
            this.r1lbl = new System.Windows.Forms.Label();
            this.r2lbl = new System.Windows.Forms.Label();
            this.r3lbl = new System.Windows.Forms.Label();
            this.r4lbl = new System.Windows.Forms.Label();
            this.r5lbl = new System.Windows.Forms.Label();
            this.r5value = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.seriesans = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.seriesans);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.r5value);
            this.tabPage1.Controls.Add(this.r5lbl);
            this.tabPage1.Controls.Add(this.r4lbl);
            this.tabPage1.Controls.Add(this.r3lbl);
            this.tabPage1.Controls.Add(this.r2lbl);
            this.tabPage1.Controls.Add(this.r1lbl);
            this.tabPage1.Controls.Add(this.r3value);
            this.tabPage1.Controls.Add(this.r2value);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.r4value);
            this.tabPage1.Controls.Add(this.r1value);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Series ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // r1value
            // 
            this.r1value.Location = new System.Drawing.Point(202, 66);
            this.r1value.Name = "r1value";
            this.r1value.Size = new System.Drawing.Size(79, 20);
            this.r1value.TabIndex = 0;
            // 
            // r4value
            // 
            this.r4value.Location = new System.Drawing.Point(202, 172);
            this.r4value.Name = "r4value";
            this.r4value.Size = new System.Drawing.Size(79, 20);
            this.r4value.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2 Resistors ",
            "3 Resistors",
            "4 Resistors",
            "5 Resistors"});
            this.comboBox1.Location = new System.Drawing.Point(36, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // r2value
            // 
            this.r2value.Location = new System.Drawing.Point(202, 99);
            this.r2value.Name = "r2value";
            this.r2value.Size = new System.Drawing.Size(79, 20);
            this.r2value.TabIndex = 3;
            // 
            // r3value
            // 
            this.r3value.Location = new System.Drawing.Point(202, 134);
            this.r3value.Name = "r3value";
            this.r3value.Size = new System.Drawing.Size(79, 20);
            this.r3value.TabIndex = 4;
            // 
            // r1lbl
            // 
            this.r1lbl.AutoSize = true;
            this.r1lbl.Location = new System.Drawing.Point(164, 66);
            this.r1lbl.Name = "r1lbl";
            this.r1lbl.Size = new System.Drawing.Size(21, 13);
            this.r1lbl.TabIndex = 5;
            this.r1lbl.Text = "R1";
            // 
            // r2lbl
            // 
            this.r2lbl.AutoSize = true;
            this.r2lbl.Location = new System.Drawing.Point(164, 102);
            this.r2lbl.Name = "r2lbl";
            this.r2lbl.Size = new System.Drawing.Size(21, 13);
            this.r2lbl.TabIndex = 6;
            this.r2lbl.Text = "R2";
            // 
            // r3lbl
            // 
            this.r3lbl.AutoSize = true;
            this.r3lbl.Location = new System.Drawing.Point(164, 137);
            this.r3lbl.Name = "r3lbl";
            this.r3lbl.Size = new System.Drawing.Size(21, 13);
            this.r3lbl.TabIndex = 7;
            this.r3lbl.Text = "R3";
            // 
            // r4lbl
            // 
            this.r4lbl.AutoSize = true;
            this.r4lbl.Location = new System.Drawing.Point(164, 175);
            this.r4lbl.Name = "r4lbl";
            this.r4lbl.Size = new System.Drawing.Size(21, 13);
            this.r4lbl.TabIndex = 8;
            this.r4lbl.Text = "R4";
            // 
            // r5lbl
            // 
            this.r5lbl.AutoSize = true;
            this.r5lbl.Location = new System.Drawing.Point(164, 209);
            this.r5lbl.Name = "r5lbl";
            this.r5lbl.Size = new System.Drawing.Size(21, 13);
            this.r5lbl.TabIndex = 9;
            this.r5lbl.Text = "R5";
            // 
            // r5value
            // 
            this.r5value.Location = new System.Drawing.Point(202, 206);
            this.r5value.Name = "r5value";
            this.r5value.Size = new System.Drawing.Size(79, 20);
            this.r5value.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seriesans
            // 
            this.seriesans.AutoSize = true;
            this.seriesans.Location = new System.Drawing.Point(354, 140);
            this.seriesans.Name = "seriesans";
            this.seriesans.Size = new System.Drawing.Size(42, 13);
            this.seriesans.TabIndex = 12;
            this.seriesans.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "000";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox r4value;
        private System.Windows.Forms.TextBox r1value;
        private System.Windows.Forms.Label r4lbl;
        private System.Windows.Forms.Label r3lbl;
        private System.Windows.Forms.Label r2lbl;
        private System.Windows.Forms.Label r1lbl;
        private System.Windows.Forms.TextBox r3value;
        private System.Windows.Forms.TextBox r2value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox r5value;
        private System.Windows.Forms.Label r5lbl;
        private System.Windows.Forms.Label seriesans;
    }
}

