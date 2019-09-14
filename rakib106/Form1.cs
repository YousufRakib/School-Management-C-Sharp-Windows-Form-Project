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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacher te = new teacher();
            te.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            room ro = new room();
            ro.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            result re = new result();
            re.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            student st = new student();
            st.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            routine st = new routine();
            st.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
