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
    public partial class ViewStudentForm : Form
    {

        public ViewStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (File.Exists(SearchStudentBox.Text+".txt"))
            {
                String a = SearchStudentBox.Text + ".txt";
                StreamReader sr = new StreamReader(a);
                richTextBox1.ReadOnly = true;
                richTextBox1.AppendText("Name:  " + sr.ReadLine());
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Father's Name:  " + sr.ReadLine());
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Age:  " + sr.ReadLine());
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Gender:  " + sr.ReadLine());
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Degree:  " + sr.ReadLine());
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Section:  " + sr.ReadLine());
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Session:  " + sr.ReadLine());
                sr.Close();
                
            }
            else{
                MessageBox.Show("The entered student does not exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
