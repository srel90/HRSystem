using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HRSystem.com;
namespace HRSystem.form
{
    public partial class mainForm : DevComponents.DotNetBar.Office2007RibbonForm
    {
        party party;
        department department;
        position position;
        personalType personalType;
        users users;
        personal personal;
        rptviewer rptviewer;
        rptpersonal rptpersonal;
        rpttimetable rpttimetable;
        timetable timetable;
        salarypaymentoneperson salarypaymentoneperson;
        comParty comParty = new comParty();
        comDepartment comDepartment = new comDepartment();
        comPosition comPosition = new comPosition();
        comPersonalType comPersonalType = new comPersonalType();
        public mainForm()
        {
            InitializeComponent();
        }
        public void setstatusbar(string status)
        {
            toolStripStatusLabel1.Text = "ผู้ใช้งาน : "+status;
        }
        public void DisplayForm<T>(ref T frm) where T : Form, new()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new T();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState =FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
                frm.BringToFront();
            }

        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Application.Exit();
            login login = new login();
            login.Show();
        }

        private void btnparty_Click(object sender, EventArgs e)
        {
            DisplayForm<party>(ref party);

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btndepartment_Click(object sender, EventArgs e)
        {
            DisplayForm<department>(ref department);
        }

        private void btnposition_Click(object sender, EventArgs e)
        {
            DisplayForm<position>(ref position);
        }

        private void btnpersonaltype_Click(object sender, EventArgs e)
        {
            DisplayForm<personalType>(ref personalType);
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            DisplayForm<users>(ref users);
        }

        private void buttonItem13_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 0;
            
        }

        private void btnaddress_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 1;
        }

        private void btnwork_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 2;
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 3;
        }

        private void btnsocialtax_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 4;
        }

        private void btnexpenditure_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 5;
        }

        private void btnleaveright_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 6;
        }

        private void btnpromoted_Click(object sender, EventArgs e)
        {
            DisplayForm<personal>(ref personal);
            DevComponents.DotNetBar.TabControl tbx = personal.Controls.Find("tabpanel", true).FirstOrDefault() as DevComponents.DotNetBar.TabControl;
            tbx.SelectedTabIndex = 7;
        }

        private void btnrptparty_Click(object sender, EventArgs e)
        {
            
            DisplayForm<rptviewer>(ref rptviewer);
            DataSet ds = comParty.selectAllParty();
            rptviewer.rptviewer_show(ds, "partylist.rdlc","รายงานข้อมูลฝ่าย");
            
        }

        private void btnrptdepartment_Click(object sender, EventArgs e)
        {
            DisplayForm<rptviewer>(ref rptviewer);
            DataSet ds = comDepartment.selectAllDepartment();
            rptviewer.rptviewer_show(ds, "departmentlist.rdlc", "รายงานข้อมูลแผนก");
        }

        private void btnrptposition_Click(object sender, EventArgs e)
        {
            DisplayForm<rptviewer>(ref rptviewer);
            DataSet ds = comPosition.selectAllPosition();
            rptviewer.rptviewer_show(ds, "positionlist.rdlc", "รายงานข้อมูลตำแหน่ง");
        }

        private void btnrptpersonaltype_Click(object sender, EventArgs e)
        {
            DisplayForm<rptviewer>(ref rptviewer);
            DataSet ds = comPersonalType.selectAllPersonalType();
            rptviewer.rptviewer_show(ds, "personalTypelist.rdlc", "รายงานข้อมูลประเภทพนักงาน");
        }

        private void btnrptpersonal_Click(object sender, EventArgs e)
        {
            DisplayForm<rptpersonal>(ref rptpersonal);
        }

        private void btntimetable_Click(object sender, EventArgs e)
        {
            DisplayForm<timetable>(ref timetable);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            toolStripStatusLabel2.Text = "วันที่ : "+now.ToString();
        }

        private void btnrpttimetable_Click(object sender, EventArgs e)
        {
            DisplayForm<rpttimetable>(ref rpttimetable);
        }

        private void btnpayperpersonal_Click(object sender, EventArgs e)
        {
            DisplayForm<salarypaymentoneperson>(ref salarypaymentoneperson);
        }

    }
}
