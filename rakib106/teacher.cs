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
    public partial class teacher : Form
    {
        string[] Teacher_Name = new string[3] { "Mr.Kalam", "Mr.Rana", "Mrs.Nasima" };
        string[] T_degree = new string[3] { "B.B.A", "B.Sc", "H.S.C" };
        string[] T_phoneNumber = new string[3] { "01714567888", "10953456754", "01819876590" };
        string[] T_address = new string[3] { "Noakhali", "Khulna", "Luxmipur" };
        string[] T_salary = new string[3] { "23000 Tk", "24000 Tk", "15000 Tk" };

        public teacher()
        {
            InitializeComponent();
        }
        private void teacher_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            teacherinfo tea = new teacherinfo(Teacher_Name, T_degree, T_phoneNumber, T_address, T_salary);
            label1.Text = tea.Teacher1().ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            teacherinfo tea = new teacherinfo(Teacher_Name, T_degree, T_phoneNumber, T_address, T_salary);
            label1.Text = tea.Teacher2().ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            teacherinfo tea = new teacherinfo(Teacher_Name, T_degree, T_phoneNumber, T_address, T_salary);
            label1.Text = tea.Teacher3().ToString();

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
    }
}
