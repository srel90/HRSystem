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
            dgv1.Rows.Clear();
            List<enpTimeTable> enpTimeTable = new List<enpTimeTable>();
            IEnumerable<DateTime> dtr = DateRange(dateFrom.Value, dateTo.Value);
            DataTable TimeTable = comTimeTable.selectTimeTable(txtpersonalCard.Text, txtpersonalCard.Text, dateFrom.Value.ToString(), dateTo.Value.ToString()).Tables[0];
            string timein, timeout;
            int leave,leavecount=0,latecount=0;
            float late;
            foreach (var it in dtr)
            {
                timein = string.Empty;
                timeout = string.Empty;
                leave = 0;
                late = 0;
                for (int i = 0; i < TimeTable.Rows.Count; i++)
                {
                    if (TimeTable.Rows[i]["dateTime"].ToString().Equals(it.ToString()))
                    {
                        timein = TimeTable.Rows[i]["timeStamp"].ToString();
                        if ((i + 1) < TimeTable.Rows.Count)
                        {
                            if (TimeTable.Rows[i + 1]["dateTime"].ToString().Equals(it.ToString()))
                            {
                                timeout = TimeTable.Rows[i + 1]["timeStamp"].ToString();
                                break;
                            }
                        }
                        break;
                    }
                }
                if (timein.Equals(string.Empty) && timeout.Equals(string.Empty))
                {
                    leave = 1;
                    leavecount++;
                }
                enpTimeTable.Add(new enpTimeTable()
                {
                    date = it.ToString("yyyy-MM-dd"),
                    timein=timein,
                    timeout=timeout,
                    leave=leave,
                    late=late
                   
                });
            }
            foreach (var it in enpTimeTable)
            {
                int idx = dgv1.Rows.Add();
                DataGridViewRow row = dgv1.Rows[idx];
                row.Cells["_date"].Value = it.date;
                row.Cells["_timein"].Value = it.timein;
                row.Cells["_timeout"].Value = it.timeout;
                row.Cells["_leave"].Value = it.leave;
                row.Cells["_late"].Value = it.late;

            }
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
    }
    class enpTimeTable
    {
        public string date { get; set; }
        public string timein { get; set; }
        public string timeout { get; set; }
        public int leave { get; set; }
        public float late { get; set; }
    }
    
}
