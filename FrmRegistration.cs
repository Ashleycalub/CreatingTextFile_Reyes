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
            string getStudentNo = txtStudNo.Text;
            string getLastName = txtLastName.Text;
            string getMiddleName = txtMI.Text;
            string getFirstName = txtFirstName.Text;
            string getAge = txtAge.Text;
            string getBirthday = dateTimePickerBday.Text;
            string getList = cbProgram.Text;
            string getGender = cbGender.Text;
            string getContactNo = txtContactNo.Text;
            string setFileName = String.Concat(getStudentNo, ".txt");

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, setFileName));

            string[] info = { "StudentNo.:" + getStudentNo, "FullName:" + getFirstName + " " + getMiddleName
                   + " " + getLastName, "Program:" + getList + "Age:" + getAge, "Birthday:" + 
                    getBirthday, "ContactNo.:" + getContactNo, "Gender: " + getGender, };

            Console.WriteLine(getStudentNo);
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
    }
}
