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
    public partial class EmergencyMaintReqDetail : Form
    {
        int ids;
        List<ChangedPart> parts = new List<ChangedPart>();
        public EmergencyMaintReqDetail(string id)
        {
            InitializeComponent();
            ids = int.Parse(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyManagementRequest_Manager_ emergencyManagementRequest_Manager_ = new EmergencyManagementRequest_Manager_();
            emergencyManagementRequest_Manager_.Show();
        }

        private void EmergencyMaintReqDetail_Load(object sender, EventArgs e)
        {
            using(var db = new Session2Entities())
            {
                var q = db.EmergencyMaintenances.Where(x => x.ID == ids).FirstOrDefault();
                SN.Text = q.Asset.AssetSN;
                Name.Text = q.Asset.AssetName;
                dept.Text = q.Asset.DepartmentLocation.Department.Name;

                Start.Value = DateTime.Now;
                end.Value = DateTime.Now; // can be null if not tech note

                var q3 = db.Parts.ToList();
                foreach(var item in q3)
                {
                    comboBox1.Items.Add(item.Name);
                }
                comboBox1.SelectedIndex = 0;
                dataGridView1.DataSource = cdt(parts);
                links();
            }
        }

        void links()
        {
            DataGridViewLinkColumn dataGridViewLinkColumn = new DataGridViewLinkColumn();
            dataGridViewLinkColumn.HeaderText = "Action";
            dataGridViewLinkColumn.Text = "Remove";
            dataGridView1.Columns.Add(dataGridViewLinkColumn);
        }

        DataTable cdt(List<ChangedPart> changedParts)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Part Name");
            dt.Columns.Add("Amount");
            foreach(var item in changedParts)
            {
                DataRow dr = dt.NewRow();
                using(var db = new Session2Entities())
                {
                    var q = db.Parts.Where(x => x.ID == item.PartID).FirstOrDefault();
                    dr["Part Name"] = q.Name;
                }
                
                dr["Amount"] = item.Amount;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            ChangedPart changedPart = new ChangedPart();
            changedPart.Amount = numericUpDown1.Value;
            using(var db = new Session2Entities())
            {
                var q = db.Parts.Where(x => x.Name == comboBox1.Text).FirstOrDefault();
                changedPart.PartID = q.ID;
            }
            parts.Add(changedPart);
            dataGridView1.DataSource = cdt(parts);

        }
    }
}
