using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHRSite
{
    public partial class Form2 : Form
    {
        private int id;
        public Form2(int id)
        {
            this.id = id;
            InitializeComponent();
            EmployeeData.DataSource = Classes.SqlTableGetter("EMPLOYEES", "*");
            EmployeeData.AutoResizeColumns();
            string[] employee = Classes.SqlDataGetter("EMPLOYEES", "EMPLOYEE_NAME", "EMPLOYEE_ID", id.ToString());
            Name.Text = $"Welcome, {employee[0]}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeData.DataSource = Classes.SqlTableGetter("EMPLOYEES", "*");
            EmployeeData.AutoResizeColumns();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Employee employee = new Employee(this.id);
            employee.Show();
        }

        private void LeaveReq_Click(object sender, EventArgs e)
        {
            PtoRequests pto = new PtoRequests(this.id);
            pto.Show();
        }
    }
}
