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
    public partial class personalType : DevComponents.DotNetBar.Office2007Form
    {
        comPersonalType comPersonalType = new comPersonalType();
        enPersonalType enPersonalType = new enPersonalType();
        string mode = "insert";
        public personalType()
        {
            InitializeComponent();
        }

        private void personalType_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {

            DataSet ds = comPersonalType.selectAllPersonalType();
            dgv1.DataSource = ds.Tables[0];
            txtpersonalTypeID.Text = comPersonalType.getLastID().Tables[0].Rows[0]["lastID"].ToString();
            txtpersonalType.Text = "";
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
                    searchTermBits.Add("personalType LIKE '%" + term + "%'");
                }
            }
            if (searchTermBits.Count != 0)
            {
                keyword = String.Join<string>(" OR ", searchTermBits);
                keyword = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName FROM personalType WHERE " + keyword;

                DataSet ds = comPersonalType.searchPersonalType(keyword);
                dgv1.DataSource = ds.Tables[0];
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            txtpersonalTypeID.Text = comPersonalType.getLastID().Tables[0].Rows[0]["lastID"].ToString();
            txtpersonalType.Text = "";
            rdostatus1.Checked = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (dgv1.SelectedRows.Count > 0)
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
            if (dgv1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    if (comPersonalType.deletePersonalType(Convert.ToInt32(txtpersonalTypeID.Text)))
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
            enPersonalType.personalTypeID = Convert.ToInt32(txtpersonalTypeID.Text);
            enPersonalType.personalType = txtpersonalType.Text;
            if (rdostatus1.Checked == true)
            {
                enPersonalType.status = 1;
            }
            else
            {
                enPersonalType.status = 0;
            }
            switch (mode)
            {
                case "insert":
                    if (comPersonalType.insertPersonalType(enPersonalType))
                    {
                        MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
                    }
                    break;
                case "update":
                    if (comPersonalType.updatePersonalType(enPersonalType))
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
                txtpersonalTypeID.Text = dgv1.Rows[e.RowIndex].Cells["_personalTypeID"].Value.ToString();
                txtpersonalType.Text = dgv1.Rows[e.RowIndex].Cells["_personalType"].Value.ToString();
                if (dgv1.Rows[e.RowIndex].Cells["_status"].Value.ToString().Equals("0"))
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
            dgv1.Enabled = true;
            dgv1.ClearSelection();
            txtpersonalType.Enabled = false;
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
            dgv1.Enabled = false;
            dgv1.ClearSelection();
            txtpersonalType.Enabled = true;
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
