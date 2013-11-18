using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem.form
{
    public partial class rptviewer : Form
    {
        public rptviewer()
        {
            InitializeComponent();
        }

        private void rptviewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void rptviewer_show(DataSet ds,string rptname,string title)
        {
            this.Text = title;
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\reports\\" + rptname;
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
