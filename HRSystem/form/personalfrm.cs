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
    public partial class personalfrm : DevComponents.DotNetBar.Office2007Form
    {
        comPersonal comPersonal = new comPersonal();
        public string personalCard { get; set; }
        public personalfrm()
        {
            InitializeComponent();
            DataSet ds = comPersonal.selectAllPersonal();
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
                    searchTermBits.Add("personalCode LIKE '%" + term + "%'");
                    searchTermBits.Add("personalCard LIKE '%" + term + "%'");
                    searchTermBits.Add("title LIKE '%" + term + "%'");
                    searchTermBits.Add("name LIKE '%" + term + "%'");
                    searchTermBits.Add("lastname LIKE '%" + term + "%'");
                    searchTermBits.Add("nickname LIKE '%" + term + "%'");
                    searchTermBits.Add("height LIKE '%" + term + "%'");
                    searchTermBits.Add("weight LIKE '%" + term + "%'");
                    searchTermBits.Add("bloodGroup LIKE '%" + term + "%'");
                    searchTermBits.Add("[national] LIKE '%" + term + "%'");
                    searchTermBits.Add("nationality LIKE '%" + term + "%'");
                    searchTermBits.Add("religion LIKE '%" + term + "%'");
                    searchTermBits.Add("personalStatus LIKE '%" + term + "%'");
                    searchTermBits.Add("birthdate LIKE '%" + term + "%'");
                    searchTermBits.Add("militaryStatus LIKE '%" + term + "%'");
                }
            }
            if (searchTermBits.Count != 0)
            {
                keyword = String.Join<string>(" OR ", searchTermBits);
                keyword = "SELECT *,CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END AS statusName FROM personal WHERE " + keyword;

                DataSet ds = comPersonal.searchPersonal(keyword);
                dgv1.DataSource = ds.Tables[0];
            }
        }

        private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                personalCard = dgv1.Rows[e.RowIndex].Cells["_personalCard"].Value.ToString();
                this.Close();
            }
        }
    }
}
