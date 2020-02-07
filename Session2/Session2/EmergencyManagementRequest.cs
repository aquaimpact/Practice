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
    public partial class EmergencyManagementRequest : Form
    {
        string ids;
        public EmergencyManagementRequest(string id)
        {
            InitializeComponent();
            ids = id;
        }

        private void EmergencyManagementRequest_Load(object sender, EventArgs e)
        {
            using(var db = new Session2Entities())
            {
                var q = db.Assets.Where(x => x.AssetSN == ids).FirstOrDefault();
                SN.Text = q.AssetSN;
                Name.Text = q.AssetName;
                dept.Text = q.DepartmentLocation.Department.Name;

                var q2 = db.Priorities.ToList();
                foreach(var item in q2)
                {
                    comboBox1.Items.Add(item.Name);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyMaintenenceManagement emergencyMaintenenceManagement = new EmergencyMaintenenceManagement();
            emergencyMaintenenceManagement.Show();
        }

        private void SendReq_Click(object sender, EventArgs e)
        {
            
            using (var db = new Session2Entities())
            {
                EmergencyMaintenance emergencyMaintenance = new EmergencyMaintenance();
                var q = db.Assets.Where(x => x.AssetSN == ids).FirstOrDefault();
                var q2 = db.EmergencyMaintenances.Where(x => x.AssetID == q.ID).ToList();
                var bools = false;
                foreach (var item in q2)
                {
                    if (item.EMEndDate == null)
                    {
                        bools = true;
                    }
                }
                if (bools == true)
                {
                    MessageBox.Show("There is already a request!");
                    return;
                }
                emergencyMaintenance.AssetID = q.ID;
                emergencyMaintenance.PriorityID = comboBox1.SelectedIndex + 1;
                emergencyMaintenance.DescriptionEmergency = Desc.Text;
                emergencyMaintenance.OtherConsiderations = other.Text;
                emergencyMaintenance.EMStartDate = null;
                emergencyMaintenance.EMEndDate = null;
                emergencyMaintenance.EMReportDate = DateTime.Now;
                emergencyMaintenance.EMTechnicianNote = null;
                db.EmergencyMaintenances.Add(emergencyMaintenance);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Success!");
                    this.Hide();
                    EmergencyMaintenenceManagement emergencyMaintenenceManagement = new EmergencyMaintenenceManagement();
                    emergencyMaintenenceManagement.Show();
                }catch(Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            }
        }
    }
}
