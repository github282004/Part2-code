using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastname = textBox1.Text;
            string Firstname = textBox2.Text;
            string middlename = textBox3.Text;

            string studentName = "Student Name:" + Firstname + " " +  middlename + " " + lastname;
            string gender = "none";

            if (radioButton1.Checked)
            {
                gender = "Gender: " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = "Gender: " + radioButton2.Text;
            }

            string DateOfBirth = "Date of birth: " + dayBox.Text + "/" + monthBox.Text + yearBox.Text;
            string program = "Program: " + program1.Text;
            MessageBox.Show(studentName + "\n" +  gender + "\n" + DateOfBirth + "\n" + program);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                ComboBox myBox = new ComboBox();
                dayBox.Items.Add(i.ToString());
            }
            string[] months = { "January","February","March","April","May", "June", "July", "August", "September", "October", "November","December"};
            foreach (string list in months)
            {
               monthBox.Items.Add(list);
            }
            for (int i = 1990; i <= 2024; i++)
            {
                ComboBox myBox = new ComboBox();
                yearBox.Items.Add(i.ToString());
            }

            string[] programs = {"Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information Systems", "Bachelor of Science in Computer Engineering"};
            foreach (string list in programs)
            {
                program1.Items.Add(list);
            }
        }
    }
}