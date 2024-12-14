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
    public partial class AdminPanel : Form
    {
        public AdminPanel(DataTable studentTable)
        {
            InitializeComponent();

            dataGridView1.DataSource = studentTable;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
        public void AddDataToGrid(string[] rowData)
        {
            dataGridView1.Rows.Add(rowData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    string newValue = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Enter new value for {dataGridView1.Columns[i].Name}:",
                        "Edit Record",
                        selectedRow.Cells[i].Value?.ToString()
                    );

                    
                    if (!string.IsNullOrWhiteSpace(newValue))
                    {
                        selectedRow.Cells[i].Value = newValue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove the selected record?",
                    "Remove Record",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
