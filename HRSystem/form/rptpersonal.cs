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
using System.IO;
using HRSystem.com;
using HRSystem.entity;
using HRSystem.form;

namespace HRSystem.form
{
    public partial class rptpersonal : Form
    {
        rptviewer rptviewer;
        comPersonal comPersonal = new comPersonal();
        public rptpersonal()
        {
            InitializeComponent();
            DataSet ds = comPersonal.selectAllPersonal();
            dgv1.DataSource = ds.Tables[0];
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
                    searchTermBits.Add("personalCode LIKE '%" + term + "%'");
                    searchTermBits.Add("personalCard LIKE '%" + term + "%'");
                    searchTermBits.Add("title LIKE '%" + term + "%'");
                    searchTermBits.Add("name LIKE '%" + term + "%'");
                    searchTermBits.Add("lastname LIKE '%" + term + "%'");
                    searchTermBits.Add("nickname LIKE '%" + term + "%'");
                    searchTermBits.Add("height LIKE '%" + term + "%'");
                    searchTermBits.Add("weight LIKE '%" + term + "%'");
                    searchTermBits.Add("bloodGroup LIKE '%" + term + "%'");
                    searchTermBits.Add("[national] LIKE '%" + term + "%'");
                    searchTermBits.Add("nationality LIKE '%" + term + "%'");
                    searchTermBits.Add("religion LIKE '%" + term + "%'");
                    searchTermBits.Add("personalStatus LIKE '%" + term + "%'");
                    searchTermBits.Add("birthdate LIKE '%" + term + "%'");
                    searchTermBits.Add("militaryStatus LIKE '%" + term + "%'");
                }
            }
            if (searchTermBits.Count != 0)
            {
                keyword = String.Join<string>(" OR ", searchTermBits);
                keyword = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName FROM personal WHERE " + keyword;
                comPersonal comPersonal = new com.comPersonal();
                DataSet ds = comPersonal.searchPersonal(keyword);
                dgv1.DataSource = ds.Tables[0];
                dgv1.ClearSelection();
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            if (txtpersonalID.Text.Equals(string.Empty) && chk_2.Checked == true)
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการรายงาน");
            }
            else
            {
                if (chk_2.Checked == true)
                {
                    DisplayForm<rptviewer>(ref rptviewer);
                    DataSet ds = comPersonal.selectPersonal(Convert.ToInt16(txtpersonalID.Text));
                    rptviewer.rptviewer_show(ds, "personal.rdlc", "รายงานข้อมูลพนักงานรายบุคคล");
                }
                else if (chk_1.Checked == true)
                {
                    DisplayForm<rptviewer>(ref rptviewer);
                    DataSet ds = comPersonal.selectPersonalList();
                    rptviewer.rptviewer_show(ds, "personallist.rdlc", "รายงานข้อมูลพนักงานทั้งหมด");
                }

            }
            txtpersonalID.Text = string.Empty;
            dgv1.ClearSelection();
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtpersonalID.Text = dgv1.Rows[e.RowIndex].Cells["_personalID"].Value.ToString();
            }
        }
        public void DisplayForm<T>(ref T frm) where T : Form, new()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new T();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
                frm.BringToFront();
            }

        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv1.ClearSelection();
        }
    }
}
