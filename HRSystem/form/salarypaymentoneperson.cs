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
    
    public partial class salarypaymentoneperson : DevComponents.DotNetBar.Office2007Form
    {
        comTimeTable comTimeTable = new comTimeTable();
        comPersonal comPersonal = new comPersonal();
        public salarypaymentoneperson()
        {
            InitializeComponent();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTo.Value = NextMonth(dateFrom.Value);
        }

        private void txtpersonalCard_ButtonCustomClick(object sender, EventArgs e)
        {
            personalfrm personalfrm = new personalfrm();
            personalfrm.ShowDialog();
            txtpersonalCard.Text = string.IsNullOrEmpty(personalfrm.personalCard) ? "" : personalfrm.personalCard.ToString();
            personalfrm.Dispose();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpersonalCard.Text.Equals(string.Empty))
            {
                MessageBox.Show("กรุณาเลือกพนักงาน");
                return;
            }
            dgv1.Rows.Clear();
            txtleave.Text = "";
            txtlate.Text = "";
            txtlatecount.Text = "";
            txtearly.Text = "";
            txtearlycount.Text = "";
            txtot.Text = "";
            progressBarX1.Value = 0;
            List<enpTimeTable> enpTimeTable = new List<enpTimeTable>();
            IEnumerable<DateTime> dtr = DateRange(dateFrom.Value, dateTo.Value);
            DataTable TimeTable = comTimeTable.selectTimeTable(txtpersonalCard.Text, txtpersonalCard.Text, dateFrom.Value.ToString(), dateTo.Value.ToString()).Tables[0];
            string timein, timeout;
            double leave,late,early,latecount=0,earlycount=0,tcount=1,ot=0;
            
            DataTable personaldata = comPersonal.selectPersonalByPersonalCardID(Convert.ToInt16(txtpersonalCard.Text)).Tables[0];
            foreach (var it in dtr)
            {
                timein = string.Empty;
                timeout = string.Empty;
                leave = 0;
                late = 0;
                early = 0;
                latecount = 0;
                earlycount = 0;
                ot = 0;
                for (int i = 0; i < TimeTable.Rows.Count; i++)
                {
                    if (TimeTable.Rows[i]["timetable"].ToString().Equals(it.ToString()))
                    {

                        timein = TimeTable.Rows[i]["clockIn"].ToString();
                        timeout = TimeTable.Rows[i]["clockOut"].ToString();
                        break;
                    }
                }
                if (timein.Equals(string.Empty) && timeout.Equals(string.Empty))
                {
                    leave = 1;
                }
                if (!timein.Equals(string.Empty))
                {
                    DateTime StartTimein = DateTime.Parse(timein);
                    DateTime noon = DateTime.Parse("12:00");
                    DateTime EndTimein = DateTime.Parse(personaldata.Rows[0]["timein"].ToString());
                    TimeSpan ts = StartTimein - EndTimein;
                    TimeSpan ex = StartTimein - noon;//ลงเวลาเข้าหลังเที่ยง
                    if (ts.TotalMinutes > 30 && ex.TotalMinutes<=0)//เข้างานสายเกิน 30 นาที นับเป็น สาย 1 ครั้ง และเวลาที่ลงต้องเป็นเวลาก่อนเที่ยง
                    {
                        late = 1;
                        latecount = ts.TotalMinutes;
                    }
                }
                if (!timeout.Equals(string.Empty))
                {
                    DateTime StartTimein = DateTime.Parse(timeout);
                    DateTime EndTimein = DateTime.Parse(personaldata.Rows[0]["timeout"].ToString());
                    TimeSpan ts = StartTimein - EndTimein;
                    if (ts.TotalMinutes < 0)//ออกงานก่อนเวลาออก
                    {
                        early = 1;
                        earlycount = Math.Abs(ts.TotalMinutes);
                    }
                    if (ts.TotalMinutes > 0)//ออกงานหลังเวลาออก
                    {
                        ot = Math.Abs(ts.TotalMinutes);
                    }
                }

               
                enpTimeTable.Add(new enpTimeTable()
                {
                    personalCard=personaldata.Rows[0]["personalCard"].ToString(),
                    date = it.ToString("yyyy-MM-dd"),
                    timein=timein,
                    timeout=timeout,
                    leave=leave,
                    late=late,
                    latecount=latecount,
                    early=early,
                    earlycount=earlycount,
                    ot=ot
                   
                });
                Double tick = (100.0 / dtr.Count()) * tcount;
                progressBarX1.Value = Convert.ToInt32(Math.Ceiling(tick));
                tcount++;
            }
            int l1=0, l2=0, l3=0, l4=0, l5=0, l6=0;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            style.ForeColor = Color.Yellow;
            foreach (var it in enpTimeTable)
            {
                int idx = dgv1.Rows.Add();
                DataGridViewRow row = dgv1.Rows[idx];
                row.Cells["_personalCard"].Value = it.personalCard;
                row.Cells["_date"].Value = it.date;
                row.Cells["_timein"].Value = it.timein;
                row.Cells["_timeout"].Value = it.timeout;
                row.Cells["_leave"].Value = it.leave;
                if (it.leave > 0) row.Cells["_leave"].Style = style;
                row.Cells["_late"].Value = it.late;
                if (it.late > 0) row.Cells["_late"].Style = style;
                row.Cells["_latecount"].Value = it.latecount;
                if (it.latecount > 0) row.Cells["_latecount"].Style = style;
                row.Cells["_early"].Value = it.early;
                if (it.early > 0) row.Cells["_early"].Style = style;
                row.Cells["_earlycount"].Value = it.earlycount;
                if (it.earlycount > 0) row.Cells["_earlycount"].Style = style;
                row.Cells["_ot"].Value = it.ot;
                if (it.ot > 0) row.Cells["_ot"].Style = style;
                l1 += (int)it.leave;
                l2 += (int)it.late;
                l3 += (int)it.latecount;
                l4 += (int)it.early;
                l5 += (int)it.earlycount;
                l6 += (int)it.ot;

            }
            txtleave.Text = l1.ToString();
            txtlate.Text = l2.ToString();
            txtlatecount.Text = l3.ToString();
            txtearly.Text = l4.ToString();
            txtearlycount.Text = l5.ToString();
            txtot.Text = l6.ToString();
        }
        public IEnumerable<DateTime> DateRange(DateTime fromDate, DateTime toDate)
        {
            return Enumerable.Range(0, toDate.Subtract(fromDate).Days + 1)
                             .Select(d => fromDate.AddDays(d));
        }
        private DateTime NextMonth(DateTime date)
        {
            if (date.Day != DateTime.DaysInMonth(date.Year, date.Month))
                return date.AddMonths(1).AddDays(-1);
            else
                return date.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void salarypaymentoneperson_Load(object sender, EventArgs e)
        {
       
        }
    }
    class enpTimeTable
    {
        public string personalCard { get; set; }
        public string date { get; set; }
        public string timein { get; set; }
        public string timeout { get; set; }
        public double leave { get; set; }
        public double late { get; set; }
        public double latecount { get; set; }
        public double early { get; set; }
        public double earlycount { get; set; }
        public double ot { get; set; }
    }
    
}
