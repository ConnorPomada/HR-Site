using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHRSite
{
    public partial class Employee : Form
    {
        public int id;
        public string[] employee;
        public Employee(int id)
        {
            this.id = id;
            employee = Classes.SqlDataGetter("EMPLOYEES", "*", "EMPLOYEE_ID", id.ToString());
            DataTable dt = Classes.SqlTableGetter("PTO", "*", "Id", $"{employee[0]}");
            InitializeComponent();
            if (dt != null)
            {
                Requests.DataSource = dt;
            }
            else
            {
            }
            //Displays the employee's information
            welcomeMsg.Text = $"Welcome, {employee[1]}";
            data.Text = $"Employee ID: {employee[0]} \nYour Department Is: {employee[3]}, And Your Position: {employee[4]} \nYour Compensation: {string.Format("{0:C}", Convert.ToDecimal(employee[2]))}\n";
            Requests.AutoResizeColumns();
        }

        private void PTO_Click(object sender, EventArgs e)
        {
            PtoRequester pto = new PtoRequester(this.id);
            pto.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Requests.DataSource = Classes.SqlTableGetter("PTO", "*", "Id", $"{employee[0]}");
            Requests.AutoResizeColumns();
        }

        private void PasswordChng_Click(object sender, EventArgs e)
        {
            PassChanger pass = new PassChanger(this.id);
            pass.Show();
        }
    }
}
