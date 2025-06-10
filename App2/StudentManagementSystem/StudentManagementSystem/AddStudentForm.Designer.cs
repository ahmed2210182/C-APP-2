namespace StudentManagementSystem
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(150, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(150, 90);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 1;

            // cmbClass
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] { "Class 1", "Class 2", "Class 3" });
            this.cmbClass.Location = new System.Drawing.Point(150, 130);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(200, 21);
            this.cmbClass.TabIndex = 2;

            // dtpDateOfBirth
            this.dtpDateOfBirth.Location = new System.Drawing.Point(150, 170);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 3;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(150, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age:";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class:";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of Birth:";

            // AddStudentForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}