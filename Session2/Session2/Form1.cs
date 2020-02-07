using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                var q = db.Employees.Where(x => x.Username == Username.Text && x.Password == Pass.Text).FirstOrDefault();
                if (q != null)
                {
                    if (q.isAdmin == true)
                    {
                        this.Hide();
                        EmergencyManagementRequest_Manager_ emergencyManagementRequest_Manager_ = new EmergencyManagementRequest_Manager_();
                        emergencyManagementRequest_Manager_.Show();
                    }
                    else
                    {
                        this.Hide();
                        EmergencyMaintenenceManagement emergencyMaintenenceManagement = new EmergencyMaintenenceManagement();
                        emergencyMaintenenceManagement.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User!");
                }
            }
        }
    }
}
