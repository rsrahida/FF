using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UniversityAdmissionSystem
{
    public partial class StudentInformation : Form
    {
        private DataTable studentTable;

        public StudentInformation()
        {
            InitializeComponent();
            InitializeStudentTable();
        }

        private void InitializeStudentTable()
        {
            studentTable = new DataTable();
            studentTable.Columns.Add("Name", typeof(string));
            studentTable.Columns.Add("Surname", typeof(string));
            studentTable.Columns.Add("Birth of Date", typeof(DateTime));
            studentTable.Columns.Add("Gender", typeof(string));
            studentTable.Columns.Add("Phone", typeof(string));
            studentTable.Columns.Add("Home Address", typeof(string));
            studentTable.Columns.Add("Student ID", typeof(string));
            studentTable.Columns.Add("Admission Year", typeof(DateTime));
            studentTable.Columns.Add("Group NO", typeof(string));
            studentTable.Columns.Add("Faculty", typeof(string));
            studentTable.Columns.Add("Major", typeof(string));
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtHomeAddress.Text) ||
                string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtGroupNo.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(cmbFaculty.Text) ||
                string.IsNullOrWhiteSpace(txtMajor.Text))
            {
                MessageBox.Show("Bütün sahələri doldurun!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveStudent()
        {
            if (ValidateFields())
            {
                try
                {
                    DataRow row = studentTable.NewRow();

                    // Xanaları yoxlayıb doldurur
                    row["Name"] = txtName.Text;
                    row["Surname"] = txtSurname.Text;
                    row["Birth of Date"] = dateTimePickerBirth.Value;
                    row["Gender"] = cmbGender.Text;
                    row["Phone"] = txtPhone.Text;
                    row["Home Address"] = txtHomeAddress.Text;
                    row["Student ID"] = txtStudentID.Text;
                    row["Admission Year"] = dateTimePickerAdmission.Value;
                    row["Group NO"] = txtGroupNo.Text;
                    row["Faculty"] = cmbFaculty.Text;
                    row["Major"] = txtMajor.Text;

                    studentTable.Rows.Add(row);

                    MessageBox.Show("Tələbə uğurla əlavə edildi!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void StudentInformation_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPhone.Clear();
            txtHomeAddress.Clear();
            txtStudentID.Clear();
            txtGroupNo.Clear();
            cmbGender.SelectedIndex = -1;
            cmbFaculty.SelectedIndex = -1;
            txtMajor.Clear();
            dateTimePickerBirth.Value = DateTime.Now;
            dateTimePickerAdmission.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(studentTable);
            adminPanel.ShowDialog();
        }
    }
}
