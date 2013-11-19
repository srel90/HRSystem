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
            comTimeTable comTimeTable = new comTimeTable();
            DataSet ds = comTimeTable.selectTimeTable(txtpersonalCardFrom.Text, txtpersonalCardTo.Text, dateFrom.Value.ToString(), dateTo.Value.ToString());
            dgv1.DataSource = ds.Tables[0];
        }

        private void rpttimetable_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dateFrom.Value = dt;
            dateTo.Value = dt;
        }
    }
}
