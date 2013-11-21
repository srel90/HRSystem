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
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count != 0)
            {
                DisplayForm<rptviewer>(ref rptviewer);
                DataTable dt = new DataTable();
                dt.Columns.Add("timeTableID");
                dt.Columns.Add("personalCard");
                dt.Columns.Add("timetable");
                dt.Columns.Add("onduty");
                dt.Columns.Add("offduty");
                dt.Columns.Add("clockIn");
                dt.Columns.Add("clockOut");
                foreach (DataGridViewRow row in dgv1.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["timeTableID"] = row.Cells["_timeTableID"].Value.ToString();
                    dr["personalCard"] = row.Cells["_personalCard"].Value.ToString();
                    dr["timetable"] = row.Cells["_timetable"].Value.ToString();
                    dr["onduty"] = row.Cells["_onduty"].Value.ToString();
                    dr["offduty"] = row.Cells["_offduty"].Value.ToString();
                    dr["clockIn"] = row.Cells["_clockIn"].Value.ToString();
                    dr["clockOut"] = row.Cells["_clockOut"].Value.ToString();
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

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTo.Value = NextMonth(dateFrom.Value);
        }
        private DateTime NextMonth(DateTime date)
        {
            if (date.Day != DateTime.DaysInMonth(date.Year, date.Month))
                return date.AddMonths(1).AddDays(-1);
            else
                return date.AddDays(1).AddMonths(1).AddDays(-1);
        }
    }
}
