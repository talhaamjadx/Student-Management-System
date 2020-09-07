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
namespace StudentManager
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void First_NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = Student_IDBox.Text + ".txt";
            if (First_NameBox.Text == "" || Last_NameBox.Text == "" || First_NameBox.Text == "" || AgeBox.Text == "" || GenderBox.Text == "" || DegreeBox.Text == "" || SectionBex.Text == "" || SessionBox.Text == "")
            {
                MessageBox.Show("You must enter all information");
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine(First_NameBox.Text + " " + Last_NameBox.Text);
                    sw.WriteLine(Fathers_NameBox.Text);
                    sw.WriteLine(AgeBox.Text);
                    sw.WriteLine(GenderBox.Text);
                    sw.WriteLine(DegreeBox.Text);
                    sw.WriteLine(SectionBex.Text);
                    sw.WriteLine(SessionBox.Text);
                    sw.Close();
                    this.Close();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Student_IDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
