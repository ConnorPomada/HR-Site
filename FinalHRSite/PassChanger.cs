using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using PasswordController;

namespace FinalHRSite
{

    public partial class PassChanger : Form
    {
        private int id;
        public string[] employee;
        public string[] oldPass;
        public PassChanger(int id)
        {
            this.id = id;
            employee = Classes.SqlDataGetter("EMPLOYEES", "*", "EMPLOYEE_ID", id.ToString());
            oldPass = Classes.SqlDataGetter("LOGIN", "*", "EmployeeID", id.ToString());
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            PasswordSalt salt = new PasswordSalt();
            if (NewPass.Text == newpasscheck.Text && User.Text == oldPass[0] && salt.VerifyPassword(OldPass.Text, oldPass[1], Convert.FromBase64String(oldPass[2]))) 
            {
                Classes.PasswordUpdate(NewPass.Text,User.Text);
                MessageBox.Show("Password Changed");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
            
        }
    }
}
