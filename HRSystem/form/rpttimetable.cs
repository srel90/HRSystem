using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRSystem.com;
using HRSystem.entity;
using HRSystem.form;
namespace HRSystem.form
{
    public partial class rpttimetable : DevComponents.DotNetBar.Office2007Form
    {
        rptviewer rptviewer;
        comTimeTable comTimeTable = new comTimeTable();
        public rpttimetable()
        {
            InitializeComponent();
        }

        private void txtpersonalCardFrom_ButtonCustomClick(object sender, EventArgs e)
        {
            personalfrm personalfrm = new personalfrm();
            personalfrm.ShowDialog();
            txtpersonalCardFrom.Text = string.IsNullOrEmpty(personalfrm.personalCard) ? "" : personalfrm.personalCard.ToString();
            personalfrm.Dispose();
        }

        private void txtpersonalCardTo_ButtonCustomClick(object sender, EventArgs e)
        {
            personalfrm personalfrm = new personalfrm();
            personalfrm.ShowDialog();
            txtpersonalCardTo.Text = string.IsNullOrEmpty(personalfrm.personalCard) ? "" : personalfrm.personalCard.ToString();
            personalfrm.Dispose();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            
            DataSet ds = comTimeTable.selectTimeTable(txtpersonalCardFrom.Text, txtpersonalCardTo.Text, dateFrom.Value.ToString(), dateTo.Value.ToString());
            dgv1.DataSource = ds.Tables[0];
        }

        private void rpttimetable_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dateFrom.Value = dt;
            dateTo.Value = dt;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count != 0)
            {
                DisplayForm<rptviewer>(ref rptviewer);
                DataTable dt = new DataTable();
                dt.Columns.Add("timeTableID");
                dt.Columns.Add("personalCard");
                dt.Columns.Add("dateTime");
                dt.Columns.Add("timeStamp");
                foreach (DataGridViewRow row in dgv1.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["timeTableID"] = row.Cells["timeTableID"].Value.ToString();
                    dr["personalCard"] = row.Cells["personalCard"].Value.ToString();
                    dr["dateTime"] = row.Cells["dateTime"].Value.ToString();
                    dr["timeStamp"] = row.Cells["timeStamp"].Value.ToString();
                    dt.Rows.Add(dr);

                }
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                rptviewer.rptviewer_show(ds, "timetablelist.rdlc", "รายงานข้อมูลการลงเวลา");
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูลสำหรับการรายงาน");
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
    }
}
