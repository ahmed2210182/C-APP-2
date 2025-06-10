using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        // Constructor
        public LoginForm()
        {
            InitializeComponent();
        }

        // Event handler for the Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Hardcoded credentials
            string validUsername = "admin";
            string validPassword = "1234";

            // Get input from TextBoxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate credentials
            if (username == validUsername && password == validPassword)
            {
                MessageBox.Show("Login successful! Welcome to the Student Management System.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the Dashboard form
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}