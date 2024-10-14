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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            string[] Departments = { "EXECUTIVE", "HR", "ENGINEERING", "SALES" };
            Department.DataSource = Departments;
            string[] managers = Classes.SqlDataGetter("EMPLOYEES", "EMPLOYEE_NAME");
            Managers.DataSource = managers;
            int[] acc = {1, 2};
            AccessLvl.DataSource = acc;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Name.Text;
                int salary = int.Parse(Salary.Text);
                string department = Department.Text;
                string title = Title.Text;
                string manager = Managers.Text;
                string password = Password.Text;
                string[] manid = Classes.SqlDataGetter("EMPLOYEES", "EMPLOYEE_ID", "EMPLOYEE_NAME", $"'{manager}'");
                int managerID = Convert.ToInt32(manid[0]);
                string joinDate = JoinDate.Value.ToString("yyyy-MM-dd");
                Classes.SqlDataAdder($"'{name}',{salary},'{department}','{title}',{managerID},'{joinDate}'");
                string[] id = Classes.SqlDataGetter("EMPLOYEES", "EMPLOYEE_ID", "EMPLOYEE_NAME", $"'{name}'");
                Classes.PasswordMaker(name, password, Convert.ToInt32(id[0]), Convert.ToInt32(AccessLvl.Text));
                MessageBox.Show($"Employee {name} Added \n USERNAME: {name} \n PASSWORD: {password}");
                this.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
