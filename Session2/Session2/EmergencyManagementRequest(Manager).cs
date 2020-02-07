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
    public partial class EmergencyManagementRequest_Manager_ : Form
    {
        public EmergencyManagementRequest_Manager_()
        {
            InitializeComponent();
        }

        private void EmergencyManagementRequest_Manager__Load(object sender, EventArgs e)
        {
            using( var db = new Session2Entities())
            {
                var q = db.EmergencyMaintenances.Where(x => x.EMEndDate == null).OrderByDescending(x => x.PriorityID).OrderBy(x => x.EMStartDate).ToList();
                dataGridView1.DataSource = cdt(q);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        DataTable cdt(List<EmergencyMaintenance> emergencyMaintenances)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Asset SN");
            dt.Columns.Add("Asset Name");
            dt.Columns.Add("Request Date");
            dt.Columns.Add("Employee Full Name");
            dt.Columns.Add("Department");
            foreach(var item in emergencyMaintenances)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = item.ID;
                dr["Asset SN"] = item.Asset.AssetSN;
                dr["Asset Name"] = item.Asset.AssetName;
                dr["Request Date"] = item.EMStartDate;
                dr["Employee Full Name"] = item.Asset.Employee.FirstName + item.Asset.Employee.LastName;
                dr["Department"] = item.Asset.DepartmentLocation.Department.Name;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void Manage_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var id = dr.Cells["ID"].Value.ToString();
                    EmergencyMaintReqDetail emergencyManagementRequest = new EmergencyMaintReqDetail(id);
                    this.Hide();
                    emergencyManagementRequest.Show();
                }
            }
        }
    }
}
