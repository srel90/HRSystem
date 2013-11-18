using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRSystem.com;
using HRSystem.entity;
using HRSystem.form;
namespace HRSystem.form
{
    public partial class party : DevComponents.DotNetBar.Office2007Form
    {
        comParty comParty = new comParty();
        enParty enParty = new enParty();
        string mode = "insert";
        public party()
        {
            InitializeComponent();
        }

        private void party_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {

            DataSet ds = comParty.selectAllParty();
            dgvParty.DataSource = ds.Tables[0];
            txtpartyID.Text = comParty.getLastID().Tables[0].Rows[0]["lastID"].ToString();
            txtname.Text = "";
            lockcontrol();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keyword = Regex.Replace(txtsearch.Text.ToString(), @"\s\s+", " ");
            string[] searchTerms = keyword.Split(' ');
            List<string> searchTermBits = new List<string>();
            foreach (string term in searchTerms)
            {
                term.Trim();
                if (term != string.Empty)
                {
                    searchTermBits.Add("name LIKE '%" + term + "%'");
                }
            }
            if (searchTermBits.Count != 0)
            {
                keyword = String.Join<string>(" OR ", searchTermBits);
                keyword = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName FROM party WHERE " + keyword;

                DataSet ds = comParty.searchParty(keyword);
                dgvParty.DataSource = ds.Tables[0];
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            txtpartyID.Text = comParty.getLastID().Tables[0].Rows[0]["lastID"].ToString();
            txtname.Text = "";
            rdostatus1.Checked = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (dgvParty.SelectedRows.Count > 0)
            {
                unlockcontrol();
                mode = "update";
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข");
            }

        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvParty.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (comParty.deleteParty(Convert.ToInt32(txtpartyID.Text)))
                    {
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");

                    }
                }
                Initialize();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
            }

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            lockcontrol();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            enParty.partyID = Convert.ToInt32(txtpartyID.Text);
            enParty.name = txtname.Text;
            if (rdostatus1.Checked == true)
            {
                enParty.status = 1;
            }
            else
            {
                enParty.status = 0;
            }
            switch (mode)
            {
                case "insert":
                    if (comParty.insertParty(enParty))
                    {
                        MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
                    }
                    break;
                case "update":
                    if (comParty.updateParty(enParty))
                    {
                        MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อยแล้ว");
                    }
                    break;
            }
            Initialize();
        }
        private void dgvParty_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtpartyID.Text = dgvParty.Rows[e.RowIndex].Cells["_partyID"].Value.ToString();
                txtname.Text = dgvParty.Rows[e.RowIndex].Cells["_name"].Value.ToString();
                if (dgvParty.Rows[e.RowIndex].Cells["_status"].Value.ToString().Equals("0"))
                {
                    rdostatus2.Checked = true;
                }
                else
                {
                    rdostatus1.Checked = true;
                }
            }
        }
        private void lockcontrol()
        {
            dgvParty.Enabled = true;
            dgvParty.ClearSelection();
            txtname.Enabled = false;
            rdostatus1.Enabled = false;
            rdostatus2.Enabled = false;

            btnadd.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            btnsave.Enabled = false;
            btncancel.Enabled = false;
        }
        private void unlockcontrol()
        {
            dgvParty.Enabled = false;
            dgvParty.ClearSelection();
            txtname.Enabled = true;
            rdostatus1.Enabled = true;
            rdostatus2.Enabled = true;

            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btncancel.Enabled = true;
        }




    }
}
