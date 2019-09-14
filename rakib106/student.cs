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
    public partial class student : Form
    {
        int[] OneResult = new int[4] { 335, 480,425, 365};
        int[] TwoResult = new int[4] { 475, 380, 278, 280};
        int[] ThreeResult = new int[4] { 485, 420, 297, 188 };
        int[] FourResult = new int[4] { 475, 390,238,200};
        int[] FiveResult = new int[3] { 500, 470, 400 };
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Studentinfo stu = new Studentinfo(OneResult, TwoResult, ThreeResult, FourResult, FiveResult);
            label1.Text = (stu.class1info() + "\n" + stu.class1_student_1() + "\n" + stu.class1_student_2() + "\n" + stu.class1_student_3() + "\n" + stu.class1_student_4());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Studentinfo stu = new Studentinfo(OneResult, TwoResult, ThreeResult, FourResult, FiveResult);
            label1.Text = (stu.class2info() + "\n" + stu.class2_student_1() + "\n" + stu.class2_student_2() + "\n" + stu.class2_student_3() + "\n" + stu.class2_student_4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Studentinfo stu = new Studentinfo(OneResult, TwoResult, ThreeResult, FourResult, FiveResult);
            label1.Text = (stu.class3info() + "\n" + stu.class3_student_1() + "\n" + stu.class3_student_2() + "\n" + stu.class3_student_3() + "\n" + stu.class3_student_4());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Studentinfo stu = new Studentinfo(OneResult, TwoResult, ThreeResult, FourResult, FiveResult);
            label1.Text = (stu.class4info() + "\n" + stu.class4_student_1() + "\n" + stu.class4_student_2() + "\n" + stu.class4_student_3() + "\n" + stu.class4_student_4());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Studentinfo stu = new Studentinfo(OneResult, TwoResult, ThreeResult, FourResult, FiveResult);
            label1.Text = (stu.class5info() + "\n" + stu.class5_student_1() + "\n" + stu.class5_student_2() + "\n" + stu.class5_student_3());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo = new Form1();
            fo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
