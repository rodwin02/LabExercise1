using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABexerciseHomeres
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getProgram = txtProgram.Text;
            string getLastName = txtLastName.Text;
            string getFirstName = txtFirstName.Text;
            string getMI = txtMI.Text;
            string getAge = txtAge.Text;
            string getGender = txtGender.Text;
            string getBirthday = txtBirthday.Text;
            string getContactNo = txtContactNo.Text;


            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            getStudentNo + ".txt")))
            {
                outputFile.WriteLine("Student No. " + getStudentNo);
                outputFile.WriteLine("Full Name: " + getLastName + "," + getFirstName + "," + getMI);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No: " + getContactNo);

            }
            this.Close();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
