using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityAdmissionSystem
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logopctrbx_Click(object sender, EventArgs e)
        {

        }

        private void registlbl_Click(object sender, EventArgs e)
        {

        }



        private void passwordlbl_Click(object sender, EventArgs e)
        {

        }



        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Proqramdan çıxmaq istədiyinizdən əminsinizmi?",
        "Çıxış Təsdiqi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string gmail = txtgmail.Text.Trim();
            string password = txtpassword.Text;

            
            string gmailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            
            bool isPasswordValid = password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsLetter);

            if (System.Text.RegularExpressions.Regex.IsMatch(gmail, gmailPattern) && isPasswordValid)
            {
                
                StudentInformation studentInfoForm = new StudentInformation();
                studentInfoForm.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Gmail və ya şifrə yanlışdır. Gmail ünvanını düzgün daxil edin və şifrənizin 8 simvoldan ibarət olduğuna əmin olun!",
                                "Xəta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void txtgmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void gmaillbl_Click(object sender, EventArgs e)
        {

        }
    }
}
