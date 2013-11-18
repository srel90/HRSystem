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
using System.Text.RegularExpressions;
namespace HRSystem.form
{
    public partial class partyfrm : DevComponents.DotNetBar.Office2007Form
    {
        comParty comParty = new comParty();
        public string partyID { get; set; }
        public partyfrm()
        {
            InitializeComponent();
        }

        private void partyfrm_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {

            DataSet ds = comParty.selectAllParty();
            dgvParty.DataSource = ds.Tables[0];
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
                    searchTermBits.Add("name LIKE '%" + term + "%'");
                }
            }
            if (searchTermBits.Count != 0)
            {
                keyword = String.Join<string>(" OR ", searchTermBits);
                keyword = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName FROM party WHERE " + keyword;

                DataSet ds = comParty.searchParty(keyword);
                dgvParty.DataSource = ds.Tables[0];
            }
        }

        private void dgvParty_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                partyID = dgvParty.Rows[e.RowIndex].Cells["_partyID"].Value.ToString();
                this.Close();
            }
        }
    }
}
