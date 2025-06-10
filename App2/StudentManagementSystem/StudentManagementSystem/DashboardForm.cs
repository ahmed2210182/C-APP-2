using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        // Event handler for the Add Student button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Open the Add Student form
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        // Event handler for the View Students button
        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            // Open the View Students form
            ViewStudentsForm viewStudentsForm = new ViewStudentsForm();
            viewStudentsForm.Show();
        }

        // Event handler for the Search Students button
        private void btnSearchStudents_Click(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = txtSearchTerm.Text.Trim();

            // Open the View Students form with the search term
            ViewStudentsForm viewStudentsForm = new ViewStudentsForm(searchTerm);
            viewStudentsForm.Show();
        }

        // Event handler for the File menu item
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}