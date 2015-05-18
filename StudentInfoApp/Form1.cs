using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }
            //string  regNo;
            //string firstName;
            //string lastName;
        Student aStudent = new Student();

        private void showButton_Click(object sender, EventArgs e)
        {
            if (regTextBox.Text == "" || firstNameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                MessageBox.Show("Pls Enter The Information.");
            }
            else
            {
                aStudent.regNo = regTextBox.Text;
                aStudent.firstName = firstNameTextBox.Text;
                aStudent.lastName = lastNameTextBox.Text;
               
                //MessageBox.Show(aStudent.firstName +" " +aStudent.lastName + " And your Registration No. Is: " +aStudent.regNo);
                //MessageBox.Show(aStudent.GetFullName() + " " + " And your Registration No. Is: " + aStudent.regNo);
                MessageBox.Show(aStudent.GetFullName() + " " + " And your Registration No. Is: " + aStudent.GetCodeNo("456"));
            }
            regTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
                regTextBox.Text = aStudent.regNo;
                firstNameTextBox.Text = aStudent.firstName;
                lastNameTextBox.Text = aStudent.lastName;

            


        }

        private void clearButton_Click(object sender, EventArgs e)
        {

           
                regTextBox.Clear();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
            

        }
    }
}
