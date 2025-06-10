using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm(string searchTerm = "")
        {
            InitializeComponent();
            LoadStudents(searchTerm); // Load students with optional search term
        }

        private void LoadStudents(string searchTerm = "")
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                // Show all students if no search term is provided
                dataGridView1.DataSource = SharedData.Students;
            }
            else
            {
                // Filter students by name or class
                var filteredStudents = SharedData.Students
                    .Where(s => s.Name.ToLower().Contains(searchTerm.ToLower()) || s.Class.ToLower().Contains(searchTerm.ToLower()))
                    .ToList();

                // Bind the filtered list to the DataGridView
                dataGridView1.DataSource = filteredStudents;

                // If no students match the search term, show a message
                if (filteredStudents.Count == 0)
                {
                    MessageBox.Show("No matching students found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents(); // Refresh the list
        }
    }
}