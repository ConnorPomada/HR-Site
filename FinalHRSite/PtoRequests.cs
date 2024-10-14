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
    public partial class PtoRequests : Form
    {
        public PtoRequests(int id)
        {
            InitializeComponent();
            Requests.DataSource = Classes.SqlTableGetter("PTO", "*", "ManagerID", Convert.ToString(id));
            Requests.AutoResizeColumns();
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            Classes.Updater("PTO", "Status", "Approved", "ID", Requests.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show($"PTO Approved");
        }

        private void Deny_Click(object sender, EventArgs e)
        {
            Classes.Updater("PTO", "Status", "Denied", "ID", Requests.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show($"DENIED!");
        }
    }
}
