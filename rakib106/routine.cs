using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rakib106
{
    public partial class routine : Form
    {
        public routine()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString("Date-  1st -  2nd -  3rd -  4th  \nSaturday-Math-Bengali-English-Islam\nSunday-Bengali-Math-English-General Knowledge\nMonday-English-Math-Bengali-General Science\nTuesday-English-Math-Bengali-General Science\nWednesday-Islam-Math-Bengali-General Science\nThurseday-English-Math-Bengali-English");
            label1.Text = a.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string b = Convert.ToString("Date-1st-2nd-3rd-4th\nSatorday-Math-Bengali-English-Islam\nBengalihMath-English-General Knowledge\nMonday-English-Math-Bengali-General Science\nTuesday-English-Math-Bengali-General Science\nWednesday-Islam-Math-Bengali-General Science\nThurseday-English-Math-Bengali-English");
            label1.Text = b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string c = Convert.ToString("Date-1st-2nd-3rd-4th\nSatorday-Math-Bengali-English-Islam\nSunday-Bengali-Math-English-General Knowledge\nMonday-English-Math-Bengali-General Science\nTuesday-English-Math-Bengali-General Science\nWednesday-Islam-Math-Bengali-General Science\nThurseday-English-Math-Bengali-English");
            label1.Text = c.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string d = Convert.ToString("Date-1st-2nd-3rd-4th\nSatorday-Mat-Bengal-English-Islam\nSunday-Bengali-Math-English-Social science\nMonday-English-Math-Bengali-General Science\nTuesday-English-Math-Bengali-General Science\nWednesday-Islam-Math-Bengali=General Science\nThurseday-English-Math-Bengali-English" );
            label1.Text = d.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string f = Convert.ToString("Date-1st-2nd-3rd-4th\nSatorday-Math-Bengali-English-Islam\nSunday-Bengala-Math-English-Social science\nMonday-English-Math-Bengali-General Science\nTuesday-English-Math-Bengali-General Science\nWednesday-Islam-Math-Bengali-General Science\nThurseday-English-Math-Bengali-English");
            label1.Text = f.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo = new Form1();
            fo.Show();
        }

        private void routine_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
