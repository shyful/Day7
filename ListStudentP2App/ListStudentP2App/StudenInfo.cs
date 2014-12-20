using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListStudentP2App
{
    public partial class StudenInfo : Form
    {
        public StudenInfo()
        {
            InitializeComponent();
        }

        List<Student> students=new List<Student>(); 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void regnotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
          Student aStudent=new Student();
            aStudent.regNo =regnotextBox.Text;
            aStudent.firstName = firstnametextBox.Text;
            aStudent.lastName = lastnametextBox.Text;
            students.Add(aStudent);
            MessageBox.Show("Saved Successfully");
            regnotextBox.Clear();
            firstnametextBox.Clear();
            lastnametextBox.Clear();
        }
     
        private void showallButton_Click(object sender, EventArgs e)
        {
            string value = "";
            foreach (Student vStudent in students)
            {
                value+= vStudent.regNo + "\t\t" + vStudent.GetFullName()+"\n";
            }
            MessageBox.Show("Registration No.\tFull Name\n"+value);

        }

        private void clearallButton_Click(object sender, EventArgs e)
        {
            students.Clear();
        }
    }
}
