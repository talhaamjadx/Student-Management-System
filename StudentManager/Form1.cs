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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm asf = new AddStudentForm();
            asf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewStudentForm vsf = new ViewStudentForm();
            vsf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteStudentForm dsf = new DeleteStudentForm();
            dsf.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateStudentForm usf = new UpdateStudentForm();
            usf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
