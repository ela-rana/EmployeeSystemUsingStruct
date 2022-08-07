namespace EmployeeSystemUsingStruct
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmployeeData = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.groupBoxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEid = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEid = new System.Windows.Forms.TextBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonViewEmployees = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.groupBoxEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmployeeData
            // 
            this.labelEmployeeData.AutoSize = true;
            this.labelEmployeeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeData.Location = new System.Drawing.Point(110, 21);
            this.labelEmployeeData.Name = "labelEmployeeData";
            this.labelEmployeeData.Size = new System.Drawing.Size(122, 18);
            this.labelEmployeeData.TabIndex = 0;
            this.labelEmployeeData.Text = "Employee Data";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(336, 30);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(638, 509);
            this.dataGridViewEmployee.TabIndex = 6;
            // 
            // groupBoxEmployeeDetails
            // 
            this.groupBoxEmployeeDetails.Controls.Add(this.buttonAddRecord);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelDept);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelSalary);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelLastName);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelFirstName);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelEid);
            this.groupBoxEmployeeDetails.Controls.Add(this.comboBoxDept);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxSalary);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxLastName);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxEid);
            this.groupBoxEmployeeDetails.Location = new System.Drawing.Point(8, 209);
            this.groupBoxEmployeeDetails.Name = "groupBoxEmployeeDetails";
            this.groupBoxEmployeeDetails.Size = new System.Drawing.Size(322, 220);
            this.groupBoxEmployeeDetails.TabIndex = 2;
            this.groupBoxEmployeeDetails.TabStop = false;
            this.groupBoxEmployeeDetails.Text = "Employee Details";
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(145, 189);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecord.TabIndex = 5;
            this.buttonAddRecord.Text = "Add record";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(10, 165);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(65, 13);
            this.labelDept.TabIndex = 9;
            this.labelDept.Text = "Department:";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(10, 130);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(36, 13);
            this.labelSalary.TabIndex = 8;
            this.labelSalary.Text = "Salary";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(10, 91);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(10, 57);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelEid
            // 
            this.labelEid.AutoSize = true;
            this.labelEid.Location = new System.Drawing.Point(10, 24);
            this.labelEid.Name = "labelEid";
            this.labelEid.Size = new System.Drawing.Size(70, 13);
            this.labelEid.TabIndex = 5;
            this.labelEid.Text = "Employee ID:";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(81, 162);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(221, 21);
            this.comboBoxDept.TabIndex = 4;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(81, 123);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(221, 20);
            this.textBoxSalary.TabIndex = 3;
            this.textBoxSalary.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSalary_Validating);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(81, 88);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(221, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastName_Validating);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(81, 54);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(221, 20);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirstName_Validating);
            // 
            // textBoxEid
            // 
            this.textBoxEid.Location = new System.Drawing.Point(81, 21);
            this.textBoxEid.Name = "textBoxEid";
            this.textBoxEid.Size = new System.Drawing.Size(221, 20);
            this.textBoxEid.TabIndex = 0;
            this.textBoxEid.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEid_Validating);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(89, 63);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(143, 28);
            this.buttonAddEmployee.TabIndex = 7;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonViewEmployees
            // 
            this.buttonViewEmployees.Location = new System.Drawing.Point(89, 97);
            this.buttonViewEmployees.Name = "buttonViewEmployees";
            this.buttonViewEmployees.Size = new System.Drawing.Size(143, 28);
            this.buttonViewEmployees.TabIndex = 8;
            this.buttonViewEmployees.Text = "View Employees";
            this.buttonViewEmployees.UseVisualStyleBackColor = true;
            this.buttonViewEmployees.Click += new System.EventHandler(this.buttonViewEmployees_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(89, 131);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(143, 28);
            this.buttonDeleteEmployee.TabIndex = 9;
            this.buttonDeleteEmployee.Text = "Delete Employee";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(89, 505);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit Application";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(986, 560);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonViewEmployees);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.groupBoxEmployeeDetails);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.labelEmployeeData);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Employee System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.groupBoxEmployeeDetails.ResumeLayout(false);
            this.groupBoxEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeData;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.GroupBox groupBoxEmployeeDetails;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEid;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEid;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonViewEmployees;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonExit;
    }
}

