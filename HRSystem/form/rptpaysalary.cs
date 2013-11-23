using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRSystem.entity;
using HRSystem.com;
using HRSystem.form;
namespace HRSystem.form
{
    public partial class rptpaysalary : Form
    {
        rptviewer rptviewer;
        public rptpaysalary()
        {
            InitializeComponent();
        }

        private void txtpersonalCard_ButtonCustomClick(object sender, EventArgs e)
        {
            personalfrm personalfrm = new personalfrm();
            personalfrm.ShowDialog();
            txtpersonalCard.Text = string.IsNullOrEmpty(personalfrm.personalCard) ? "" : personalfrm.personalCard.ToString();
            personalfrm.Dispose();
        }
        private DateTime NextMonth(DateTime date)
        {
            if (date.Day != DateTime.DaysInMonth(date.Year, date.Month))
                return date.AddMonths(1).AddDays(-1);
            else
                return date.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTo.Value = NextMonth(dateFrom.Value);
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            comPayment comPayment=new comPayment();
            comPersonal comPersonal = new comPersonal();
            if (txtpersonalCard.Text.Equals(string.Empty))
            {
                MessageBox.Show("กรุณาพิมพ์รหัสพนักงาน");
                return;
            }

            int personalCard = Convert.ToInt32(txtpersonalCard.Text);
            int personalID;
            String startDate,endDate;
            startDate=dateFrom.Text;
            endDate=dateTo.Text;
            DataTable personaldata = comPersonal.selectPersonalByPersonalCardID(personalCard).Tables[0];
            if (personaldata.Rows.Count != 0)
            {
                personalID = Convert.ToInt32(personaldata.Rows[0]["personalID"].ToString());
                DataTable payment = comPayment.selectAllPaymentByPersonalIDAndstartDateendDate(personalID, startDate, endDate).Tables[0];
                if (payment.Rows.Count != 0)
                {
                    dgv1.DataSource = payment;
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลเงินเดือน");
                }
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูลพนักงาน");
            }
            
        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv1.ClearSelection();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count != 0)
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgv1.Columns)
                {
                    dt.Columns.Add(column.DataPropertyName);
                }
                for (int i = 0; i < dgv1.SelectedRows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < dgv1.Columns.Count; j++)
                    {
                        dr[j] = dgv1.SelectedRows[i].Cells[j].Value;
                    }
                    dt.Rows.Add(dr);
                }
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                DisplayForm<rptviewer>(ref rptviewer);
                rptviewer.rptviewer_show(ds, "paymentslip.rdlc", "สลิปเงินเดือน");
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการพิมพ์");
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
