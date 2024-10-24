using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void Employee_id_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {
           ;
        }

        private void Position_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(
                   int.Parse(Employee_id.Text),
                   Fname.Text,
                   Lname.Text,
                   Position.Text
               );

            dataGridView1.Rows.Add(
                employee.EmployeeID,
                employee.FirstName,
                employee.LastName,
                employee.Position
            );

            Employee_id.Text = "";
            Fname.Text = "";
            Lname.Text = "";
            Position.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public class Employee
        {
            private int employeeID;
            private string firstName;
            private string lastName;
            private string position;

            public Employee(int employeeID, string firstName, string lastName)
            {
                this.employeeID = employeeID;
                this.firstName = firstName;
                this.lastName = lastName;
                
            }
            public Employee(int employeeID, string firstName, string lastName, string position)
            {
                this.employeeID = employeeID;
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;

            }

            public int EmployeeID { get { return employeeID; } }
            public string FirstName { get { return firstName; } }
            public string LastName
            {
                get
                {
                    return lastName;
                }
            }
            public string Position
            {
                get
                {
                    return position;
                }
            }
        }
    }
}
//James Vladimir Z. Gacis
