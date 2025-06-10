namespace StudentManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddStudent;
        private System.Windows.Forms.ToolStripButton btnViewStudents;
        private System.Windows.Forms.ToolStripButton btnSearchStudents;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Panel panel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddStudent = new System.Windows.Forms.ToolStripButton();
            this.btnViewStudents = new System.Windows.Forms.ToolStripButton();
            this.btnSearchStudents = new System.Windows.Forms.ToolStripButton();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileToolStripMenuItem,
                this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);

            // helpToolStripMenuItem
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";

            // toolStrip1
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.btnAddStudent,
                this.btnViewStudents,
                this.btnSearchStudents});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";

            // btnAddStudent
            this.btnAddStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(77, 22);
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            // btnViewStudents
            this.btnViewStudents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(85, 22);
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);

            // btnSearchStudents
            this.btnSearchStudents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearchStudents.Name = "btnSearchStudents";
            this.btnSearchStudents.Size = new System.Drawing.Size(95, 22);
            this.btnSearchStudents.Text = "Search Students";
            this.btnSearchStudents.Click += new System.EventHandler(this.btnSearchStudents_Click);

            // txtSearchTerm
            this.txtSearchTerm.Location = new System.Drawing.Point(300, 27); // Adjusted position
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(150, 20);
            this.txtSearchTerm.TabIndex = 2;

            // panel1
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 401);
            this.panel1.TabIndex = 3;

            // DashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}