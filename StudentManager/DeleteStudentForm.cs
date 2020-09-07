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
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(DeleteStudentBox.Text + ".txt")){
                File.Delete(DeleteStudentBox.Text + ".txt");
                MessageBox.Show("Student deleted successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Student Doesn't Exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
