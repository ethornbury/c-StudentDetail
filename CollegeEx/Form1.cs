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
//when going outside the program, need this line

namespace CollegeEx
{
    public partial class Form1 : Form
    {
        //declare filepath here so available across
        //before the string = @"and put what you need in";
        string myfilepath = "p:\\test\\students.csv";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtBxFname.Text;
            string lname = txtBxSurname.Text;
            string dob = dtpDOB.Text;
            string gender ="";
            if(rdoMale.Checked)
            {
                gender = "Male";
            }
            else if(rdoFemale.Checked)
            {
                gender = "Female";
            }
            string email = txtBxEmail.Text;
            string course = cmbBxCourseDet.SelectedItem.ToString();

            //streaming will buffer in the data
            StreamWriter sw = File.AppendText(myfilepath);
            {
                sw.Write(fname + ",");  //column 1
                sw.Write(lname + ",");  //column 2
                sw.Write(dob + ",");  //column 3
                sw.Write(gender + ",");  //column 4
                sw.Write(email + ",");  //column 5
                sw.WriteLine(course + ",");  //column 6
            }

            sw.Close();
            //best practice to close as when write to db will throw an error.
            txtBxFname.Clear();
            txtBxSurname.Clear();
            txtBxEmail.Clear();
            //clear the boxes for the next input 
            

        }
    }
}
