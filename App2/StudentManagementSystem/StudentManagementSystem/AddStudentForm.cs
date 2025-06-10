using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text) || cmbClass.SelectedItem == null)
                {
                    MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate age (must be a number)
                if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 100)
                {
                    MessageBox.Show("Please enter a valid age (1-100).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new student
                Student newStudent = new Student
                {
                    Name = txtName.Text,
                    Age = age,
                    Class = cmbClass.SelectedItem.ToString(),
                    DateOfBirth = dtpDateOfBirth.Value
                };

                // Add the student to the shared list
                SharedData.Students.Add(newStudent);

                // Display success message
                MessageBox.Show("Student saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                txtName.Clear();
                txtAge.Clear();
                cmbClass.SelectedIndex = -1;
                dtpDateOfBirth.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                // Display the error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}