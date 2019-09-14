using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rakib106
{
    public partial class result : Form
    {
        int[] R2016 = new int[3] { 500, 470, 400 };
        int[] R2015 = new int[3] { 390, 530, 400 };
        int[] R2014 = new int[3] { 400, 460, 450 };
        public result()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = new StreamWriter("2016.txt"))
            {
                resultinfo re = new resultinfo(R2016, R2015, R2014);

                w.WriteLine(re.R_2016() + "\n" + re.R_2016_student_1() + "\n" + re.R_2016_student_2() + "\n" + re.R_2016_student_3());
                MessageBox.Show("Click Go Button");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = new StreamWriter("2015.txt"))
            {
                resultinfo re = new resultinfo(R2016, R2015, R2014);
                w.WriteLine(re.R_2015() + "\n" + re.R_2015_student_1() + "\n" + re.R_2015_student_2() + "\n" + re.R_2015_student_3());
                MessageBox.Show("Click Go Button");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = new StreamWriter("2014.txt"))
            {
                resultinfo re = new resultinfo(R2016, R2015, R2014);
                w.WriteLine(re.R_2014() + "\n" + re.R_2014_student_1() + "\n" + re.R_2014_student_2() + "\n" + re.R_2014_student_3());
                MessageBox.Show("Click Go Button");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo = new Form1();
            fo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader w = new StreamReader("2016.txt"))
                {
                    string read;
                    while ((read = w.ReadLine()) != null)
                    {
                        textBox1.AppendText(read);
                        textBox1.AppendText(Environment.NewLine);
                    }
                    w.Close();
                }

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader w = new StreamReader("2015.txt"))
                {
                    string read;
                    while ((read = w.ReadLine()) != null)
                    {
                        textBox1.AppendText(read);
                        textBox1.AppendText(Environment.NewLine);
                    }
                    w.Close();
                }

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader w = new StreamReader("2014.txt"))
                {
                    string read;
                    while ((read = w.ReadLine()) != null)
                    {
                        textBox1.AppendText(read);
                        textBox1.AppendText(Environment.NewLine);
                    }
                    w.Close();
                }

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
