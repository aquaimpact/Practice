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
    public partial class EmergencyMaintenenceManagement : Form
    {
        public EmergencyMaintenenceManagement()
        {
            InitializeComponent();
        }

        private void EmergencyMaintenenceManagement_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                var q = db.Assets.ToList();
                dataGridView2.DataSource = cdt(q);
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            foreach(DataGridViewRow dr in dataGridView2.Rows)
            {
                using(var db = new Session2Entities())
                {
                    var id = dr.Cells["Asset SN"].Value.ToString();
                    var q = db.EmergencyMaintenances.Where(x => x.Asset.AssetSN == id).ToList();
                    var input = "";
                    foreach (var item in q)
                    {
                        if(item.EMEndDate == null)
                        {
                            input = null;
                        }
                    }
                    if(input == null)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        DataTable cdt(List<Asset> assets)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Asset SN");
            dt.Columns.Add("Asset Name");
            dt.Columns.Add("Last Closed EM");
            dt.Columns.Add("Number of EMs");
            foreach(var item in assets)
            {
                DataRow dr = dt.NewRow();
                dr["Asset SN"] = item.AssetSN;
                dr["Asset Name"] = item.AssetName;
                using( var db = new Session2Entities())
                {
                    var q = db.EmergencyMaintenances.Where(x => x.AssetID == item.ID).OrderBy(x => x.EMEndDate).ToList();
                    var status = "--";
                    foreach (var items in q)
                    {
                        if (items.EMEndDate != null)
                        {
                            status = items.EMEndDate.ToString();
                        }
                        else
                        {
                            status = "--";
                        }
                    }
                    dr["Last Closed EM"] = status;

                    dr["Number of EMs"] = q.Count();
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void SnedEMREQ_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow dr in dataGridView2.SelectedRows)
                {
                    var id = dr.Cells["Asset SN"].Value.ToString();
                    EmergencyManagementRequest emergencyManagementRequest = new EmergencyManagementRequest(id);
                    this.Hide();
                    emergencyManagementRequest.Show();
                }
            }
        }
    }
}
