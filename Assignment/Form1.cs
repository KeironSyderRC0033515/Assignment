using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                r3value.Hide();
                r3lbl.Hide();
                r4value.Hide();
                r4lbl.Hide();
                r5value.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                r3value.Show();
                r3lbl.Show();

                r4value.Hide();
                r4lbl.Hide();

                r5value.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                r3value.Show();
                r3lbl.Show();

                r4value.Show();
                r4lbl.Show();

                r5value.Hide();
                r5lbl.Hide();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                r3value.Show();
                r3lbl.Show();

                r4value.Show();
                r4lbl.Show();

                r5lbl.Show();
                r5value.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5;
            try
            {
                R3 = Convert.ToDouble(r3value.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(r4value.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(r5value.Text);
            }
            catch
            {
                R5 = 0;
            }
            R1 = Convert.ToDouble(r1value.Text);
            R2 = Convert.ToDouble(r2value.Text);

            double R = R1 + R2 + R3 + R4 + R5;
            seriesans.Text = "Answer = " + R;
        }
    }
}
