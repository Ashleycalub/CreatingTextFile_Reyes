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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatingTextFile_Reyes
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Age = txtAge.Text;
            string Bday = dateTimePickerBday.Text;
            string Program = cbProgram.Text;
            string Firstname = txtFirstName.Text;
            string Middlename = txtMI.Text;
            string Studno = txtStudNo.Text;
            string Lastname = txtLastName.Text;
            string Gender = cbGender.Text;
            string Contactno = txtContactNo.Text;
            string FileName = String.Concat(Studno, ".txt");
            

            string[] info = { "Student no.: " + Studno, "FullName: " + Firstname + " " + Middlename + ". " + Lastname,
            "Program: " + Program + "\nAge: " + Age, "Birthday: " + Bday, "Contact no.: " + Contactno, "Gender: " + Gender };
            
            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, FileName));

            Console.WriteLine(Studno);
            foreach (string i in info)
            {
                outputFile.WriteLine(i);
            }

            outputFile.Close();
            MessageBox.Show("Successfully saved!!!");
            Close();
       
        }


        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
            string[] ListOfGender = new string[]
                              {
                "Female", "Male"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudent = new FrmStudentRecord();
            frmStudent.ShowDialog();

            FrmRegistration frmRegistration = new FrmRegistration();

            frmRegistration.Close();
        }
    }
}
