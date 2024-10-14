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
    public partial class PtoRequester : Form
    {
        int id;
        public PtoRequester(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string[] employee = Classes.SqlDataGetter("EMPLOYEES", "*", "EMPLOYEE_ID", id.ToString());
            string startDate = StartDate.Value.ToString("yyyy-MM-dd");
            string endDate = EndDate.Value.ToString("yyyy-MM-dd");
            Classes.SqlDataAdderPTO($"{employee[0]},'{employee[1]}',{employee[5]},'{startDate}','{endDate}','Pending'");
            MessageBox.Show($"PTO Requested!");
            this.Close();
        }
    }
}
