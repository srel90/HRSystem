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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            label1.Parent = logopicturebox;
            label1.BackColor = Color.Transparent;
            label2.Parent = logopicturebox;
            label2.BackColor = Color.Transparent;
            label3.Text = "";
            label3.Parent = logopicturebox;
            label3.BackColor = Color.Transparent;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Equals(string.Empty) || txtpassword.Text.Equals(""))
            {
                label3.Text = "กรุณากรอก ชื่อผู้ใช้ และ รหัสผ่าน";
                
            }
            else
            {
                comUser comUser = new comUser();
                enUser enUser=new enUser();
                enUser.username=txtusername.Text;
                enUser.password=txtpassword.Text;
                string ret = comUser.checkUser(enUser);
                if (!ret.Equals("false"))
                {
                    this.Hide();
                    mainForm mainForm = new mainForm();
                    mainForm.setstatusbar(comUser.selectUserByuserID(Convert.ToInt16(ret)).Tables[0].Rows[0]["name"].ToString());
                    mainForm.Show();
                }
                else
                {
                    label3.Text = "ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง";
                    txtusername.Focus();
                    txtusername.SelectionStart = 0;
                    txtusername.SelectionLength=txtusername.TextLength;
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }
    }
}
