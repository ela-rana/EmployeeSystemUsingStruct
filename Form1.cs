using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSystemUsingStruct
{
    public partial class Form1 : Form
    {
        List<Employee> employees;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employees = new List<Employee>();   //to create some dummy entry values to represent
            employees.Add(new Employee() { Eid = 1, FirstName = "Ian", LastName = "Richards", Salary = 4000, Dept = Department.IT });
            employees.Add(new Employee() { Eid = 2, FirstName = "Josh", LastName = "Smith", Salary = 4000, Dept = Department.HR });
            employees.Add(new Employee() { Eid = 3, FirstName = "Robert", LastName = "King", Salary = 6000, Dept = Department.HR });
            employees.Add(new Employee() { Eid = 4, FirstName = "Mack", LastName = "Intosh", Salary = 9100, Dept = Department.Finance });
            employees.Add(new Employee() { Eid = 5, FirstName = "James", LastName = "Bond", Salary = 7566, Dept = Department.Marketing });
            dataGridViewEmployee.DataSource = employees;
            comboBoxDept.DataSource = Enum.GetValues(typeof(Department));
            comboBoxDept.SelectedIndex = -1;
            dataGridViewEmployee.Visible = false;
            groupBoxEmployeeDetails.Visible = false;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            groupBoxEmployeeDetails.Visible = true;
        }

        private void buttonViewEmployees_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.Visible = true;
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if(textBoxEid.Text != String.Empty && textBoxFirstName.Text != String.Empty && 
               textBoxLastName.Text != String.Empty && textBoxSalary.Text != String.Empty && comboBoxDept.Text != String.Empty)
            {
                Employee emp = new Employee();
                emp.Eid = Int32.Parse(textBoxEid.Text);
                emp.FirstName = textBoxFirstName.Text;
                emp.LastName = textBoxLastName.Text;
                emp.Salary = Int32.Parse(textBoxSalary.Text);
                emp.Dept = (Department)comboBoxDept.SelectedIndex;
                employees.Add(emp);
                MessageBox.Show("Record added");            
                RefreshData();
            }
            else
            {
                MessageBox.Show("All field must be filled to add record");
            }
        }
        /// <summary>
        /// A method to clear all filled values in the Employee Add textboxes, and to refresh the datagrid 
        /// with most current number of records
        /// </summary>
        private void RefreshData()
        {
            textBoxEid.Clear(); //blanks out and clears any text currently in the Employee ID textbox
            textBoxFirstName.Clear();   //clears First Name textbox
            textBoxLastName.Clear();    //clears Last Name textbox
            textBoxSalary.Clear();  //clears Salary textbox
            comboBoxDept.SelectedIndex = -1;    //combobox cannot be cleared. So to return it to default 
                    //its set to -1, a value outside its range (since the combobox's index starts at 0) 
            dataGridViewEmployee.DataSource = null; //to clear the datagridview before it can be refreshed
            dataGridViewEmployee.DataSource = employees;    //to display the latest employees data to grid
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (employees.Count != 0)
            {
                employees.RemoveAt(dataGridViewEmployee.CurrentRow.Index);
                RefreshData();
            }
            else 
            { 
                MessageBox.Show("There are no records to delete.");
            }
            //var empid = dataGridViewEmployee.
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxEid_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            bool parsed = Int32.TryParse(textBoxEid.Text, out temp);

            if (parsed=false || temp < 0 || temp > 100)
            {
                MessageBox.Show("Value must be between 1 and 100.\n\nYou cannot enter non whole number or blank values");
                e.Cancel = true;    //e.cancel says that the value is invalid, keep focus on the same textbox still
            }
        }

        private void textBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxFirstName.TextLength > 25)
            {
                MessageBox.Show("First Name can be upto 25 characters. No more than that");
                e.Cancel = true;    //e.cancel says that the value is invalid, keep focus on the same textbox still
                                    //so if
                textBoxFirstName.Clear();
            }
            
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxLastName.TextLength > 25)
            {
                MessageBox.Show("Last Name can be upto 25 characters. No more than that");
               // e.Cancel = true;    //e.cancel says that the value is invalid, keep focus on the same textbox still
               // textBoxLastName.Clear();
            }
        }

        private void textBoxSalary_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
