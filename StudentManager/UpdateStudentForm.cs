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
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void First_NameBox_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = GetInfoBox.Text + ".txt";
            if (File.Exists(a))
            {
                using (StreamReader sr = File.OpenText(a))
                {
                    string b=sr.ReadLine();
                    string[] words = b.Split(' ');
                    First_NameBox.Text = words[0];
                    Last_NameBox.Text = words[1];
                    Fathers_NameBox.Text = sr.ReadLine();
                    AgeBox.Text = sr.ReadLine();
                    GenderBox.Text = sr.ReadLine();
                    DegreeBox.Text = sr.ReadLine();
                    SectionBex.Text = sr.ReadLine();
                    SessionBox.Text = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Student does not exist");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String path = GetInfoBox.Text + ".txt";
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
                    MessageBox.Show("  Information Updated Successfully");
                    sw.Close();
                    this.Close();

                }
            }
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
