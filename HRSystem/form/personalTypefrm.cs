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
using HRSystem.com;
using HRSystem.entity;
using HRSystem.form;

namespace HRSystem.form
{
    public partial class personalTypefrm : DevComponents.DotNetBar.Office2007Form
    {
        comPersonalType comPersonalType = new comPersonalType();
        public string personalTypeID { get; set; }
        public personalTypefrm()
        {
            InitializeComponent();
        }

        private void personalTypefrm_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {

            DataSet ds = comPersonalType.selectAllPersonalType();
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
                    searchTermBits.Add("personalType LIKE '%" + term + "%'");
                }
            }
            if (searchTermBits.Count != 0)
            {
                keyword = String.Join<string>(" OR ", searchTermBits);
                keyword = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName FROM personalType WHERE " + keyword;

                DataSet ds = comPersonalType.searchPersonalType(keyword);
                dgv1.DataSource = ds.Tables[0];
            }
        }

        private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                personalTypeID = dgv1.Rows[e.RowIndex].Cells["_personalTypeID"].Value.ToString();
                this.Close();
            }
        }
    }
}
