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
    public partial class users : DevComponents.DotNetBar.Office2007Form
    {
        comUser comUser = new comUser();
        enUser enUser = new enUser();
        string mode = "insert";
        public users()
        {
            InitializeComponent();
        }

        private void users_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {

            DataSet ds = comUser.selectAllUser();
            dgv1.DataSource = ds.Tables[0];
            txtuserID.Text = comUser.getLastID().Tables[0].Rows[0]["lastID"].ToString();
            txtname.Text = "";
            txtlastname.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
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
                    searchTermBits.Add("lastname LIKE '%" + term + "%'");
                    searchTermBits.Add("username LIKE '%" + term + "%'");
                }
            }
            if (searchTermBits.Count != 0)
            {
                keyword = String.Join<string>(" OR ", searchTermBits);
                keyword = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName FROM users WHERE " + keyword;

                DataSet ds = comUser.searchUser(keyword);
                dgv1.DataSource = ds.Tables[0];
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            txtuserID.Text = comUser.getLastID().Tables[0].Rows[0]["lastID"].ToString();
            txtname.Text = "";
            txtlastname.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
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
                    if (comUser.deleteUser(Convert.ToInt32(txtuserID.Text)))
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
            enUser.userID = Convert.ToInt32(txtuserID.Text);
            enUser.name = txtname.Text;
            enUser.lastname = txtlastname.Text;
            enUser.username = txtusername.Text;
            enUser.password = txtpassword.Text;
            if (txtpassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("กรุณาพิมพ์รหัสผ่าน");
                return;
            }
            if (rdostatus1.Checked == true)
            {
                enUser.status = 1;
            }
            else
            {
                enUser.status = 0;
            }
            switch (mode)
            {
                case "insert":
                    if (comUser.insertUser(enUser))
                    {
                        MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
                    }
                    break;
                case "update":
                    if (comUser.updateUser(enUser))
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
                txtuserID.Text = dgv1.Rows[e.RowIndex].Cells["_userID"].Value.ToString();
                txtname.Text = dgv1.Rows[e.RowIndex].Cells["_name"].Value.ToString();
                txtlastname.Text = dgv1.Rows[e.RowIndex].Cells["_lastname"].Value.ToString();
                txtusername.Text = dgv1.Rows[e.RowIndex].Cells["_username"].Value.ToString();
                
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
            txtname.Enabled = false;
            txtlastname.Enabled = false;
            txtusername.Enabled = false;
            txtpassword.Enabled = false;
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
            txtname.Enabled = true;
            txtlastname.Enabled = true;
            txtusername.Enabled = true;
            txtpassword.Enabled = true;
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
