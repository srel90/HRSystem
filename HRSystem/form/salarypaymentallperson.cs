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

    public partial class salarypaymentallperson : DevComponents.DotNetBar.Office2007Form
    {
        comTimeTable comTimeTable = new comTimeTable();
        comPersonal comPersonal = new comPersonal();
        public salarypaymentallperson()
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
        private void txtpersonalCardto_ButtonCustomClick(object sender, EventArgs e)
        {
            personalfrm personalfrm = new personalfrm();
            personalfrm.ShowDialog();
            txtpersonalCardto.Text = string.IsNullOrEmpty(personalfrm.personalCard) ? "" : personalfrm.personalCard.ToString();
            personalfrm.Dispose();
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpersonalCard.Text.Equals(string.Empty) || txtpersonalCardto.Text.Equals(string.Empty))
            {
                MessageBox.Show("กรุณาเลือกพนักงาน");
                return;
            }
            dgv1.Rows.Clear();
            progressBarX1.Value = 0;
            List<enpTimeTableAll> enpTimeTableAll = new List<enpTimeTableAll>();
            IEnumerable<DateTime> dtr = DateRange(dateFrom.Value, dateTo.Value);            
            string timein, timeout;
            DataTable personaldata = comPersonal.selectPersonalRank(Convert.ToInt16(txtpersonalCard.Text), Convert.ToInt16(txtpersonalCardto.Text)).Tables[0];
            for (int j = 0; j < personaldata.Rows.Count; j++)
            {
                double leave=0, late=0, early=0, latecount = 0, earlycount = 0, tcount = 1, ot = 0;
                DataTable TimeTable = comTimeTable.selectTimeTable(personaldata.Rows[j]["personalCard"].ToString(), personaldata.Rows[j]["personalCard"].ToString(), dateFrom.Value.ToString(), dateTo.Value.ToString()).Tables[0];
                foreach (var it in dtr)
                {
                    timein = string.Empty;
                    timeout = string.Empty;
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
                        leave+= 1;
                    }
                    if (!timein.Equals(string.Empty))
                    {
                        DateTime StartTimein = DateTime.Parse(timein);
                        DateTime noon = DateTime.Parse("12:00");
                        DateTime EndTimein = DateTime.Parse(personaldata.Rows[j]["timein"].ToString());
                        TimeSpan ts = StartTimein - EndTimein;
                        TimeSpan ex = StartTimein - noon;//ลงเวลาเข้าหลังเที่ยง
                        if (ts.TotalMinutes > 30 && ex.TotalMinutes <= 0)//เข้างานสายเกิน 30 นาที นับเป็น สาย 1 ครั้ง และเวลาที่ลงต้องเป็นเวลาก่อนเที่ยง
                        {
                            late+= 1;
                            latecount+= ts.TotalMinutes;
                        }
                    }
                    if (!timeout.Equals(string.Empty))
                    {
                        DateTime StartTimein = DateTime.Parse(timeout);
                        DateTime EndTimein = DateTime.Parse(personaldata.Rows[0]["timeout"].ToString());
                        TimeSpan ts = StartTimein - EndTimein;
                        if (ts.TotalMinutes < 0)//ออกงานก่อนเวลาออก
                        {
                            early += 1;
                            earlycount += Math.Abs(ts.TotalMinutes);
                        }
                        if (ts.TotalMinutes > 0)//ออกงานหลังเวลาออก
                        {
                            ot += Math.Abs(ts.TotalMinutes);
                        }
                    }


                   
                    Double tick = (100.0 / dtr.Count()) * tcount;
                    progressBarX1.Value = Convert.ToInt32(Math.Ceiling(tick));
                    tcount++;
                }
                enpTimeTableAll.Add(new enpTimeTableAll()
                    {
                        personalCard = personaldata.Rows[j]["personalCard"].ToString(),
                        leave = leave,
                        late = late,
                        latecount = latecount,
                        early = early,
                        earlycount = earlycount,
                        ot = ot

                    });
            }
            foreach (var it in enpTimeTableAll)
            {
                int idx = dgv1.Rows.Add();
                DataGridViewRow row = dgv1.Rows[idx];
                row.Cells["_personalCard"].Value = it.personalCard;
                row.Cells["_leave"].Value = it.leave;
                row.Cells["_late"].Value = it.late;
                row.Cells["_latecount"].Value = it.latecount;
                row.Cells["_early"].Value = it.early;
                row.Cells["_earlycount"].Value = it.earlycount;
                row.Cells["_ot"].Value = it.ot;

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

        private void salarypaymentallperson_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dateFrom.Value = dt;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count != 0)
            {
                comPersonal comPersonal = new comPersonal();
                comExpenditure comExpenditure = new comExpenditure();
                comSalary comSalary = new comSalary();
                comPayment comPayment = new comPayment();
                DataTable dtpersonal, dtsalary, dtexpenditure;
                enPayment enPayment = new enPayment();
                double salary = 0.0;//เงินเดือน
                double outcome = 0.0;//รายจ่าย
                double income = 0.0;//รายรับ
                double incomewithnotax = 0.0;//รายรับไม่ต้องเสียภาษี
                double taxDec = 0.0;//หักภาษี
                double socialTaxDec = 0.0;//หักประกันสังคม
                double lateDec = 0.0;//หักสาย
                double leaveDec = 0.0;//หักขาด
                double ot = 0.0;//โอที
                double total = 0.0;//สุทธิ
                progressBarX1.Value = 0;
                foreach (DataGridViewRow dgvr in dgv1.Rows)
                {

                    dtpersonal = comPersonal.selectPersonalByPersonalCardID(Convert.ToInt32(dgvr.Cells["_personalCard"].Value.ToString())).Tables[0];
                    int personalID = Convert.ToInt32(dtpersonal.Rows[0]["personalID"].ToString());

                    dtsalary = comSalary.selectAllSalaryByPersonalID(personalID).Tables[0];
                    if (dtsalary.Rows[0]["calculateType"].Equals(0))//กรณีเงินเดือน
                    {
                        salary = Convert.ToDouble(dtsalary.Rows[0]["salary"].ToString());

                    }
                    else//กรณีรายวัน รายกะ คำนวนตามจำนวนวันที่ทำงาน
                    {
                        salary = Convert.ToDouble(dtsalary.Rows[0]["shiftsalary"].ToString());
                        DateTime startDate = DateTime.Parse(dateFrom.Text);
                        DateTime endDate = DateTime.Parse(dateTo.Text);
                        TimeSpan ts = (endDate.AddDays(1) - startDate);
                        int workday = ts.Days - Convert.ToInt32(dgvr.Cells["_leave"].Value.ToString());
                        salary *= workday;
                    }

                    dtexpenditure = comExpenditure.selectAllExpenditureByPersonalID(personalID).Tables[0];
                    for (int i = 0; i < dtexpenditure.Rows.Count; i++)
                    {
                        if (dtexpenditure.Rows[i]["expenditureType"].Equals(0))//รายจ่ายไม่ต้องคำนวนภาษี
                        {
                            outcome += Convert.ToDouble(dtexpenditure.Rows[i]["amount"].ToString());
                        }
                        else if (dtexpenditure.Rows[i]["expenditureType"].Equals(1))//รายรับคำนวนภาษี
                        {

                            if (dtexpenditure.Rows[i]["calTax"].Equals("Y"))
                            {
                                income += Convert.ToDouble(dtexpenditure.Rows[i]["amount"].ToString());
                            }
                            else
                            {
                                incomewithnotax += Convert.ToDouble(dtexpenditure.Rows[i]["amount"].ToString());
                            }

                        }
                    }

                    if ((salary + income) > 15000)
                    {
                        taxDec += (salary * 0.03);//หักภาษีจากเงินเดือน
                        taxDec += (income * 0.03);//หักภาษีจากรายได้ที่ต้องหักภาษี
                    }
                    if (salary > 15000)//หักประกันสังคม
                    {
                        socialTaxDec = 750;//หักประกันสังคมสูงสุดที่ฐานเงินเดือน 15000
                    }
                    else
                    {
                        socialTaxDec = salary * 0.05;
                    }
                    if (!dtsalary.Rows[0]["lateDeduct"].Equals(0))//กรณีหักเงินมาสาย
                    {
                        if (Convert.ToInt32(dgvr.Cells["_late"].Value.ToString()) >= 60)//ถ้ามาสาย 60 นาทีขึ้นไป
                        {
                            lateDec = 0;//กำหนดว่าหักเท่าไร
                        }
                    }
                    if (!dtsalary.Rows[0]["leaveDeduct"].Equals(0))//กรณีหักเงินขาดงาน
                    {
                        double leavecount = Convert.ToInt32(dgvr.Cells["_leave"].Value.ToString());//จำนวนวันที่ขาดงาน
                        leaveDec = 0;//กำหนดว่าหักเท่าไร
                    }

                    int otcount = Convert.ToInt32(dgvr.Cells["_ot"].Value.ToString());//ทำโอทีกี่นาที
                    ot = 0;//กำหนดว่าจ่ายโอทีเท่าไร

                    total += salary;
                    total += income;
                    total += incomewithnotax;
                    total += ot;
                    total -= outcome;
                    total -= taxDec;
                    total -= socialTaxDec;
                    total -= lateDec;
                    total -= leaveDec;

                    enPayment.personalID = personalID;
                    enPayment.startDate = dateFrom.Text;
                    enPayment.endDate = dateTo.Text;
                    enPayment.payDate = DateTime.Now.ToString();
                    enPayment.expenditureInc = income;
                    enPayment.expenditureDec = outcome;
                    enPayment.leaveDec = leaveDec;
                    enPayment.lateDec = lateDec;
                    enPayment.OTInc = ot;
                    enPayment.socialTaxDec = socialTaxDec;
                    enPayment.taxDec = taxDec;
                    enPayment.salary = salary;
                    enPayment.total = total;

                    //if (comPayment.insertPayment(enPayment))
                    //{
                    //    MessageBox.Show("บันทึกข้อมูลเงินเดือนเรียบร้อยแล้ว");
                    //    dgv1.Rows.Clear();
                    //    progressBarX1.Value = 0;
                    //}
                }
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูลการทำงานกรุณาคำนวณเงินเดือน");
            }
        }

        
    }
    class enpTimeTableAll
    {
        public string personalCard { get; set; }
        public double leave { get; set; }
        public double late { get; set; }
        public double latecount { get; set; }
        public double early { get; set; }
        public double earlycount { get; set; }
        public double ot { get; set; }
    }

}
