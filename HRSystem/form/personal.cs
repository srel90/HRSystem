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
using System.IO;
using HRSystem.com;
using HRSystem.entity;
using HRSystem.form;
namespace HRSystem.form
{
    public partial class personal : DevComponents.DotNetBar.Office2007Form
    {
        comPersonal comPersonal = new comPersonal();
        comPersonalAddress comPersonalAddress = new comPersonalAddress();
        comWork comWork = new comWork();
        comSalary comSalary = new comSalary();
        comSocialTax comSocialTax = new comSocialTax();
        comExpenditure comExpenditure = new comExpenditure();
        comLeaveRight comLeaveRight = new comLeaveRight();
        comPromoted comPromoted = new comPromoted();

        enPersonal enPersonal = new enPersonal();
        enPersonalAddress enPersonalAddress = new enPersonalAddress();
        enWork enWork = new enWork();
        enSalary enSalary = new enSalary();
        enSocialTax enSocialTax = new enSocialTax();
        enExpenditure enExpenditure = new enExpenditure();
        enLeaveRight enLeaveRight = new enLeaveRight();
        enPromoted enPromoted = new enPromoted();
        StringBuilder sb = new StringBuilder();
        string mode = "insert";
        public personal()
        {
            InitializeComponent();
        }

        private void personal_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {
            clearcontrol();

            DataSet ds = comPersonal.selectAllPersonal();
            dgv1.DataSource = ds.Tables[0];
            
            DataTable dataTable = new DataTable("sex");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "หญิง");
            dataTable.Rows.Add(1, "ชาย");
            cbosex.DataSource = dataTable;
            cbosex.DisplayMember = "Name";
            cbosex.ValueMember = "Id";

            dataTable = new DataTable("bloodGroup");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "A");
            dataTable.Rows.Add(1, "B");
            dataTable.Rows.Add(2, "AB");
            dataTable.Rows.Add(3, "O");
            cbobloodGroup.DataSource = dataTable;
            cbobloodGroup.DisplayMember = "Name";
            cbobloodGroup.ValueMember = "Id";

            dataTable = new DataTable("personalStatus");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "โสด");
            dataTable.Rows.Add(1, "สมรส");
            dataTable.Rows.Add(2, "หย่า");
            cbopersonalStatus.DataSource = dataTable;
            cbopersonalStatus.DisplayMember = "Name";
            cbopersonalStatus.ValueMember = "Id";

            dataTable = new DataTable("militaryStatus");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "ได้รับการยกเว้น");
            dataTable.Rows.Add(1, "ผ่านการเกณฑ์");
            dataTable.Rows.Add(2, "ไม่ผ่านการเกณฑ์");
            cbomilitaryStatus.DataSource = dataTable;
            cbomilitaryStatus.DisplayMember = "Name";
            cbomilitaryStatus.ValueMember = "Id";

            dataTable = new DataTable("workStatus");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "ทำงานปกติ");
            dataTable.Rows.Add(1, "ทดลองงาน");
            dataTable.Rows.Add(2, "ฝึกงาน");
            dataTable.Rows.Add(3, "พักงาน");
            dataTable.Rows.Add(4, "ลาอบรม/ศึกษาต่อ");
            dataTable.Rows.Add(5, "ออก");
            cboworkStatus.DataSource = dataTable;
            cboworkStatus.DisplayMember = "Name";
            cboworkStatus.ValueMember = "Id";

            dataTable = new DataTable("calculateType");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "รายเดือน");
            dataTable.Rows.Add(1, "รายวัน");
            dataTable.Rows.Add(2, "รายกะ");
            cbocalculateType.DataSource = dataTable;
            cbocalculateType.DisplayMember = "Name";
            cbocalculateType.ValueMember = "Id";

            dataTable = new DataTable("lateDeduct");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "ไม่หักเงิน");
            dataTable.Rows.Add(1, "ตามอัตราเงินเดือน");
            dataTable.Rows.Add(2, "คงที่ต่อนาที");
            dataTable.Rows.Add(3, "คิดต่อชั่วโมง");
            dataTable.Rows.Add(4, "คิดต่อครั้ง");
            ddllateDeduct.DataSource = dataTable;
            ddllateDeduct.DisplayMember = "Name";
            ddllateDeduct.ValueMember = "Id";

            dataTable = new DataTable("leaveDeduct");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Rows.Add(0, "ไม่หักเงิน");
            dataTable.Rows.Add(1, "ขาดงานโดยไม่ทราบสาเหตุ");
            ddlleaveDeduct.DataSource = dataTable;
            ddlleaveDeduct.DisplayMember = "Name";
            ddlleaveDeduct.ValueMember = "Id";
            
            lockcontrol();
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
        private void btnadd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            mode = "insert";
            clearcontrol();
            rdostatus1.Checked = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (dgv1.SelectedRows.Count > 0)
            {
                unlockcontrol();
                mode = "update";
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข");
            }

        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    sb.Clear();
                    
                        try
                        {
                            if (File.Exists(txtoldphoto.Text))
                                {
                                    File.Delete(txtoldphoto.Text);
                                }
                            
                        }
                        catch (Exception ex)
                        {

                            throw new Exception(ex.Message);
                        }
                        if (comPersonal.deletePersonal(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลพนักงานเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลพนักงานได้");
                            sb.Append("\r\n");
                        }
                        if (comPersonalAddress.deletePersonalByPersonalID(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลที่อยู่เรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลที่อยู่ได้");
                            sb.Append("\r\n");
                        }
                        if (comWork.deleteWorkByPersonalID(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลการทำงานเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลการทำงานได้");
                            sb.Append("\r\n");
                        }
                        if (comSalary.deleteSalaryByPersonalID(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลเงินเดือนเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลเงินเดือนได้");
                            sb.Append("\r\n");
                        }
                        if (comSocialTax.deleteSocialTaxByPersonalID(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลประกันสังคมเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลประกันสังคมได้");
                            sb.Append("\r\n");
                        }
                        if (comExpenditure.deleteExpenditureBypersonalID(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลรายได้/รายการหักเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลมูลรายได้/รายการหักได้");
                            sb.Append("\r\n");
                        }
                        if (comLeaveRight.deleteLeaveRightBypersonalID(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลสิทธิ์เรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลสิทธิ์การลาได้");
                            sb.Append("\r\n");
                        }
                        if (comPromoted.deletePromotedByPersonalID(Convert.ToInt32(txtpersonalID.Text)))
                        {
                            sb.Append("ลบข้อมูลการปรับเงินเดือนเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถลบข้อมูลการปรับเงินเดือนได้");
                            sb.Append("\r\n");
                        }
                    MessageBox.Show(sb.ToString());


                }
                Initialize();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
            }

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            lockcontrol();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            int personalID = Convert.ToInt32(comPersonal.getLastID().Tables[0].Rows[0]["lastID"].ToString());
            enPersonal.personalID = personalID;
            enPersonal.personalCode = txtpersonalCode.Text;
            enPersonal.personalCard = txtpersonalCard.Text;
            enPersonal.title = txttitle.Text;
            enPersonal.name = txtname.Text;
            enPersonal.lastname = txtlastname.Text;
            enPersonal.nickname = txtnickname.Text;
            enPersonal.sex = cbosex.SelectedValue.ToString();
            enPersonal.height=dbiheight.Value;
            enPersonal.weight = dbiweight.Value;
            enPersonal.bloodGroup = cbobloodGroup.SelectedValue.ToString();
            enPersonal.national = txtnational.Text;
            enPersonal.nationality = txtnationality.Text;
            enPersonal.religion = txtreligion.Text;
            enPersonal.personalStatus = cbopersonalStatus.SelectedValue.ToString();
            enPersonal.militaryStatus = cbomilitaryStatus.SelectedValue.ToString();
            enPersonal.birthdate = dtbirthdate.Value;

            enPersonalAddress.personalAddressID = Convert.ToInt16(string.IsNullOrEmpty(txtpersonalAddressID.Text) ? null : txtpersonalAddressID.Text); 
            enPersonalAddress.personalID = personalID;
            enPersonalAddress.building = txtbuilding.Text;
            enPersonalAddress.room = txtroom.Text;
            enPersonalAddress.floor = txtfloor.Text;
            enPersonalAddress.village = txtvillage.Text;
            enPersonalAddress.number = txtnumber.Text;
            enPersonalAddress.lanes = txtlanes.Text;
            enPersonalAddress.group = txtgroup.Text;
            enPersonalAddress.road = txtroad.Text;
            enPersonalAddress.district = txtdistrict.Text;
            enPersonalAddress.subdistrict = txtsubdistrict.Text;
            enPersonalAddress.province = txtprovince.Text;
            enPersonalAddress.postcode = txtpostcode.Text;
            enPersonalAddress.tel = txttel.Text;
            enPersonalAddress.fax = txtfax.Text;
            enPersonalAddress.email = txtemail.Text;
            enPersonalAddress.website = txtwebsite.Text;
            enPersonalAddress.ERContact = txtERContact.Text;
            enPersonalAddress.relation = txtrelation.Text;
            enPersonalAddress.contactNumber = txtcontactNumber.Text;

            enWork.workID = Convert.ToInt16(string.IsNullOrEmpty(txtworkID.Text) ? null : txtworkID.Text); 
            enWork.personalID = personalID;
            enWork.partyID =Convert.ToInt16( string.IsNullOrEmpty(txtpartyID.Text) ? null:txtpartyID.Text);
            enWork.departmentID = Convert.ToInt16(string.IsNullOrEmpty(txtdepartmentID.Text) ? null : txtdepartmentID.Text);
            enWork.positionID = Convert.ToInt16(string.IsNullOrEmpty(txtpositionID.Text) ? null : txtpositionID.Text);
            enWork.personalTypeID = Convert.ToInt16(string.IsNullOrEmpty(txtpersonalTypeID.Text) ? null : txtpersonalTypeID.Text);
            enWork.level = txtlevel.Text;
            enWork.workStatus = Convert.ToInt16(cboworkStatus.SelectedValue);
            enWork.startDate = (DateTime)dtstartDate.Value;
            enWork.resignDate = (DateTime)dtresignDate.Value;
            enWork.taxNumber = txttaxNumber.Text;
            enWork.idCard = txtidCard.Text;
            enWork.issueDate = (DateTime)dtissueDate.Value;
            enWork.expireDate = (DateTime)dtexpireDate.Value;
            enWork.issueAddress = txtissueAddress.Text;
            enWork.idCardAddress = txtidCardAddress.Text;

            enSalary.salaryID =  Convert.ToInt16(string.IsNullOrEmpty(txtsalaryID.Text) ? null : txtsalaryID.Text); 
            enSalary.personalID = personalID;
            enSalary.bank = txtbank.Text;
            enSalary.accountNumber = txtaccountNumber.Text;
            enSalary.calculateType = Convert.ToInt16(cbocalculateType.SelectedValue);
            enSalary.salary = txtsalary.Value;
            enSalary.shiftSalary = txtshiftSalary.Value;
            if (rdocalTax_1.Checked == true)
            {
                enSalary.calTax = "Y";
            }
            else if (rdocalTax_2.Checked == true)
            {
                enSalary.calTax = "N";
            }
            if (rdocalSocialTax_1.Checked == true)
            {
                enSalary.calSocialTax = "Y";
            }
            else if (rdocalSocialTax_2.Checked == true)
            {
                enSalary.calSocialTax = "N";
            }
            enSalary.lateDeduct = Convert.ToInt16(ddllateDeduct.SelectedValue);
            enSalary.leaveDeduct = Convert.ToInt16(ddlleaveDeduct.SelectedValue);

            enSocialTax.socialTaxID =Convert.ToInt16(string.IsNullOrEmpty(txtsocialTaxID.Text) ? null : txtsocialTaxID.Text); 
            enSocialTax.personalID = personalID;
            enSocialTax.socialTaxIDCard = txtsocialTaxIDCard.Text;
            enSocialTax.hospitalCode = txthospitalCode.Text;
            enSocialTax.hospital = txthospital.Text;

            //enExpenditure enExpenditure = new enExpenditure();
            //enLeaveRight enLeaveRight = new enLeaveRight();
            //enPromoted enPromoted = new enPromoted();

            List<enExpenditure> Expenditure = new List<enExpenditure>();
            for (int i = 0; i < gvadd.Rows.Count - 1; i++)
            {
                DataGridViewRow row = gvadd.Rows[i];
                Expenditure.Add(new enExpenditure()
                {
                    expenditureID = Convert.ToInt16(row.Cells["_gvaddexpenditureID"].Value==null ? null : row.Cells["_gvaddexpenditureID"].Value.ToString()),
                    personalID = personalID,
                    expenditureType = 0,
                    description = row.Cells["_gvadddescription"].Value.ToString(),
                    calSocialTax = row.Cells["_gvaddcalSocialTax"].Value.ToString(),
                    calTax = row.Cells["_gvaddcalTax"].Value.ToString(),
                    amount = Convert.ToDouble(row.Cells["_gvaddamount"].Value)
                });
            }
            for (int i = 0; i < gvminu.Rows.Count - 1; i++)
            {
                DataGridViewRow row = gvminu.Rows[i];
                Expenditure.Add(new enExpenditure()
                {
                    expenditureID = Convert.ToInt16( string.IsNullOrEmpty(row.Cells["_gvminuexpenditureID"].Value.ToString()) ? null:row.Cells["_gvminuexpenditureID"].Value.ToString()),
                    personalID = personalID,
                    expenditureType = 1,
                    description = row.Cells["_gvminudescription"].Value.ToString(),
                    calSocialTax = row.Cells["_gvminucalSocialTax"].Value.ToString(),
                    calTax = row.Cells["_gvminucalTax"].Value.ToString(),
                    amount = Convert.ToDouble(row.Cells["_gvminuamount"].Value)
                });
            }
            List<enLeaveRight> LeaveRight = new List<enLeaveRight>();
            for (int i = 0; i < gvleleaveRight.Rows.Count - 1; i++)
            {
                DataGridViewRow row = gvleleaveRight.Rows[i];
                LeaveRight.Add(new enLeaveRight()
                {

                    leaveRightID = Convert.ToInt16(row.Cells["_gvleleaveRightID"].Value==null ? null : row.Cells["_gvleleaveRightID"].Value.ToString()),
                    personalID = personalID,
                    year = row.Cells["_gvleyear"].Value.ToString(),
                    description = row.Cells["_gvledescription"].Value.ToString(),
                    leaveAmount = Convert.ToInt16(row.Cells["_gvleleaveAmount"].Value == null ? null : row.Cells["_gvleleaveAmount"].Value.ToString()),
                    usedLeaveAmount = Convert.ToInt16(row.Cells["_gvleusedLeaveAmount"].Value == null ? null : row.Cells["_gvleusedLeaveAmount"].Value.ToString()),
                    balanceLeaveAmount = Convert.ToInt16(row.Cells["_gvlebalanceLeaveAmount"].Value == null ? null : row.Cells["_gvlebalanceLeaveAmount"].Value.ToString())            
                });
            }
            List<enPromoted> Promoted = new List<enPromoted>();
            for (int i = 0; i < gvppromoted.Rows.Count - 1; i++)
            {
                DataGridViewRow row = gvppromoted.Rows[i];
                Promoted.Add(new enPromoted()
                {
                    promotedID = Convert.ToInt16(row.Cells["_gvppromotedID"].Value == null ? null : row.Cells["_gvppromotedID"].Value.ToString()),
                    personalID = personalID,
                    updateDate = row.Cells["_gvpupdateDate"].Value == null ? DateTime.Today : Convert.ToDateTime(row.Cells["_gvpupdateDate"].Value.ToString()),
                    oldSalary = Convert.ToDouble(row.Cells["_gvpoldSalary"].Value == null ? null : row.Cells["_gvpoldSalary"].Value.ToString()),
                    newSalary = Convert.ToDouble(row.Cells["_gvpnewSalary"].Value == null ? null : row.Cells["_gvpnewSalary"].Value.ToString()),
                    oldPositionID = Convert.ToInt16(row.Cells["_gvpoldPositionID"].Value == null ? null : row.Cells["_gvpoldPositionID"].Value.ToString()),
                    oldPositionDetail = row.Cells["_gvpoldPositionDetail"].Value == null ? "" : row.Cells["_gvpoldPositionDetail"].Value.ToString(),
                    newPositionID = Convert.ToInt16(row.Cells["_gvpnewPositionID"].Value == null ? null : row.Cells["_gvpnewPositionID"].Value.ToString()),
                    newPositionDetail = row.Cells["_gvpnewPositionDetail"].Value == null ? "" : row.Cells["_gvpnewPositionDetail"].Value.ToString(),
                    remark = row.Cells["_gvpremark"].Value == null ? "" : row.Cells["_gvpremark"].Value.ToString()
                });
            }

            string appPath = Application.StartupPath;
            string sourcePath = @txtphoto.Text;
            string targetPath = @appPath + "\\images\\";
            enPersonal.photo = targetPath + enPersonal.personalID + Path.GetExtension(sourcePath);

            if (rdostatus1.Checked == true)
            {
                enPersonal.status = 1;
            }
            else
            {
                enPersonal.status = 0;
            }
            
            switch (mode)
            {
                case "insert":
                    sb.Clear();
                        if (!txtphoto.Text.Equals(string.Empty))
                        {
                            try
                            {

                                if (!Directory.Exists(targetPath))
                                {
                                    Directory.CreateDirectory(targetPath);
                                }
                                File.Copy(sourcePath, targetPath + enPersonal.personalID + Path.GetExtension(sourcePath));
                            }
                            catch (Exception ex)
                            {

                                throw new Exception(ex.Message);
                            }

                        }
                        else
                        {
                            enPersonal.photo = String.Empty;
                        }
                        
                    
                        if (comPersonal.insertPersonal(enPersonal))
                        {
                            sb.Append("เพิ่มข้อมูลพนักงานเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถเพิ่มข้อมูลพนักงานได้");
                            sb.Append("\r\n");
                        }
                        if (comPersonalAddress.insertPersonalAddress(enPersonalAddress))
                        {
                            sb.Append("เพิ่มข้อมูลที่อยู่อาศัยเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถเพิ่มข้อมูลอยู่อาศัยได้");
                            sb.Append("\r\n");
                        }
                        if (comWork.insertWork(enWork))
                        {
                            sb.Append("เพิ่มข้อมูลการทำงานเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถเพิ่มข้อมูลการทำงานได้");
                            sb.Append("\r\n");
                        }
                        if(comSalary.insertSalary(enSalary))
                        {
                            sb.Append("เพิ่มข้อมูลเงินเดือนเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถเพิ่มข้อมูลเงินเดือนได้");
                            sb.Append("\r\n");
                        }
                        if (comSocialTax.insertSocialTax(enSocialTax))
                        {
                            sb.Append("เพิ่มข้อมูลประกันสังคมเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถเพิ่มข้อมูลประกันสังคมได้");
                            sb.Append("\r\n");
                        }
                        foreach (var it in Expenditure)
                        {
                            enExpenditure.expenditureID = it.expenditureID;
                            enExpenditure.personalID = it.personalID;
                            enExpenditure.expenditureType = it.expenditureType;
                            enExpenditure.description = it.description;
                            enExpenditure.calTax = it.calTax;
                            enExpenditure.calSocialTax = it.calSocialTax;
                            enExpenditure.amount = it.amount;
                            if (comExpenditure.insertExpenditure(enExpenditure))
                            {
                                sb.Append("เพิ่มข้อมูลรายรับ/รายหักเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถเพิ่มข้อมูลรายรับ/รายหักได้");
                                sb.Append("\r\n");
                            }
                        }
                        foreach (var it in LeaveRight)
                        {
                            enLeaveRight.leaveRightID = it.leaveRightID;
                            enLeaveRight.personalID = it.personalID;
                            enLeaveRight.year = it.year;
                            enLeaveRight.description = it.description;
                            enLeaveRight.leaveAmount = it.leaveAmount;
                            enLeaveRight.usedLeaveAmount = it.usedLeaveAmount;
                            enLeaveRight.balanceLeaveAmount = it.balanceLeaveAmount;
                            if (comLeaveRight.insertLeaveRight(enLeaveRight))
                            {
                                sb.Append("เพิ่มข้อมูลสิทธิ์การลาเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถเพิ่มข้อมูลสิทธิ์การลาได้");
                                sb.Append("\r\n");
                            }
                        }
                        foreach (var it in Promoted)
                        {
                            enPromoted.promotedID = it.promotedID;
                            enPromoted.personalID = it.personalID;
                            enPromoted.updateDate = it.updateDate;
                            enPromoted.oldSalary = it.oldSalary;
                            enPromoted.newSalary = it.newSalary;
                            enPromoted.oldPositionID = it.oldPositionID;
                            enPromoted.oldPositionDetail = it.oldPositionDetail;
                            enPromoted.newPositionID = it.newPositionID;
                            enPromoted.newPositionDetail = it.newPositionDetail;
                            enPromoted.remark = it.remark;
                            if (comPromoted.insertPromoted(enPromoted))
                            {
                                sb.Append("เพิ่มข้อมูลการปรับเงินเดือนเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารเพิ่มข้อมูลการปรับเงินเดือนได้");
                                sb.Append("\r\n");
                            }
                        }
                        MessageBox.Show(sb.ToString()); 
                    break;
                case "update":
                    sb.Clear();
                    personalID = Convert.ToInt32(txtpersonalID.Text);
                    enPersonal.personalID = personalID;
                    enPersonalAddress.personalID = personalID;
                    enWork.personalID = personalID;
                    enSalary.personalID = personalID;
                    enSocialTax.personalID = personalID;
                    foreach (var it in Expenditure)
                    {
                        it.personalID = personalID;
                    }
                    foreach (var it in LeaveRight)
                    {
                        it.personalID = personalID;
                    }
                    foreach (var it in Promoted)
                    {
                        it.personalID = personalID;
                    }
                    enPersonal.photo = targetPath + enPersonal.personalID + Path.GetExtension(sourcePath);
                        if (!txtphoto.Text.Equals(string.Empty))
                        {
                            try
                            {
                                if (!Directory.Exists(targetPath))
                                {
                                    Directory.CreateDirectory(targetPath);
                                }
                                if (File.Exists(txtoldphoto.Text))
                                {
                                    File.Delete(txtoldphoto.Text);
                                }
                                File.Copy(sourcePath, targetPath + enPersonal.personalID + Path.GetExtension(sourcePath));
                            }
                            catch (Exception ex)
                            {

                                throw new Exception(ex.Message);
                            }

                        }
                        else
                        {
                            enPersonal.photo = txtoldphoto.Text;
                        }
                        if (comPersonal.updatePersonal(enPersonal))
                        {
                            sb.Append("ปรับปรุงข้อมูลพนักงานเรียบร้อยแล้ว");
                            sb.Append("\r\n");
                        }
                        else
                        {
                            sb.Append("ไม่สามารถปรับปรุงข้อมูลพนักงานได้");
                            sb.Append("\r\n");
                        }
                        if (comPersonalAddress.selectAllPersonalAddressByPersonalID(personalID).Tables[0].Rows.Count != 0)
                        {
                            if (comPersonalAddress.updatePersonalAddress(enPersonalAddress))
                            {
                                sb.Append("ปรับปรุงข้อมูลที่อยู่อาศัยเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถปรับปรุงข้อมูลอยู่อาศัยได้");
                                sb.Append("\r\n");
                            }
                        }
                        else
                        {
                            if (comPersonalAddress.insertPersonalAddress(enPersonalAddress))
                            {
                                sb.Append("เพิ่มข้อมูลที่อยู่อาศัยเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถเพิ่มข้อมูลอยู่อาศัยได้");
                                sb.Append("\r\n");
                            }
                        }
                        if (comWork.selectAllWorkByPersonalID(personalID).Tables[0].Rows.Count != 0)
                        {
                            if (comWork.updateWork(enWork))
                            {
                                sb.Append("ปรับปรุงข้อมูลการทำงานเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถปรับปรุงข้อมูลการทำงานได้");
                                sb.Append("\r\n");
                            }
                        }
                        else
                        {
                            if (comWork.insertWork(enWork))
                            {
                                sb.Append("เพิ่มข้อมูลการทำงานเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถเพิ่มข้อมูลการทำงานได้");
                                sb.Append("\r\n");
                            }
                        }
                        if (comSalary.selectAllSalaryByPersonalID(personalID).Tables[0].Rows.Count != 0)
                        {
                            if (comSalary.updateSalary(enSalary))
                            {
                                sb.Append("ปรับปรุงข้อมูลเงินเดือนเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถปรับปรุงข้อมูลเงินเดือนได้");
                                sb.Append("\r\n");
                            }
                        }
                        else
                        {
                            if (comSalary.insertSalary(enSalary))
                            {
                                sb.Append("เพิ่มข้อมูลเงินเดือนเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถเพิ่มข้อมูลเงินเดือนได้");
                                sb.Append("\r\n");
                            }
                        }
                        if (comSocialTax.selectAllSocialTaxByPersonalID(personalID).Tables[0].Rows.Count != 0)
                        {
                            if (comSocialTax.updateSocialTax(enSocialTax))
                            {
                                sb.Append("ปรับปรุงข้อมูลประกันสังคมเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถปรับปรุงข้อมูลประกันสังคมได้");
                                sb.Append("\r\n");
                            }
                        }
                        else
                        {
                            if (comSocialTax.insertSocialTax(enSocialTax))
                            {
                                sb.Append("เพิ่มข้อมูลประกันสังคมเรียบร้อยแล้ว");
                                sb.Append("\r\n");
                            }
                            else
                            {
                                sb.Append("ไม่สามารถเพิ่มข้อมูลประกันสังคมได้");
                                sb.Append("\r\n");
                            }
                        }
                        if (comExpenditure.deleteExpenditureBypersonalID(personalID))
                        {
                            foreach (var it in Expenditure)
                            {
                                enExpenditure.expenditureID = it.expenditureID;
                                enExpenditure.personalID = it.personalID;
                                enExpenditure.expenditureType = it.expenditureType;
                                enExpenditure.description = it.description;
                                enExpenditure.calTax = it.calTax;
                                enExpenditure.calSocialTax = it.calSocialTax;
                                enExpenditure.amount = it.amount;
                                if (comExpenditure.insertExpenditure(enExpenditure))
                                {
                                    sb.Append("ปรับปรุงข้อมูลรายรับ/รายหักเรียบร้อยแล้ว");
                                    sb.Append("\r\n");
                                }
                                else
                                {
                                    sb.Append("ไม่สามารถปรับปรุงข้อมูลรายรับ/รายหักได้");
                                    sb.Append("\r\n");
                                }
                            }
                        }
                        if (comLeaveRight.deleteLeaveRightBypersonalID(personalID))
                        {
                            foreach (var it in LeaveRight)
                            {
                                enLeaveRight.leaveRightID = it.leaveRightID;
                                enLeaveRight.personalID = it.personalID;
                                enLeaveRight.year = it.year;
                                enLeaveRight.description = it.description;
                                enLeaveRight.leaveAmount = it.leaveAmount;
                                enLeaveRight.usedLeaveAmount = it.usedLeaveAmount;
                                enLeaveRight.balanceLeaveAmount = it.balanceLeaveAmount;
                                if (comLeaveRight.insertLeaveRight(enLeaveRight))
                                {
                                    sb.Append("ปรับปรุงข้อมูลสิทธิ์การลาเรียบร้อยแล้ว");
                                    sb.Append("\r\n");
                                }
                                else
                                {
                                    sb.Append("ไม่สามารถปรับปรุงข้อมูลสิทธิ์การลาได้");
                                    sb.Append("\r\n");
                                }
                            }
                        }
                        if (comPromoted.deletePromotedByPersonalID(personalID))
                        {
                            foreach (var it in Promoted)
                            {
                                enPromoted.promotedID = it.promotedID;
                                enPromoted.personalID = it.personalID;
                                enPromoted.updateDate = it.updateDate;
                                enPromoted.oldSalary = it.oldSalary;
                                enPromoted.newSalary = it.newSalary;
                                enPromoted.oldPositionID = it.oldPositionID;
                                enPromoted.oldPositionDetail = it.oldPositionDetail;
                                enPromoted.newPositionID = it.newPositionID;
                                enPromoted.newPositionDetail = it.newPositionDetail;
                                enPromoted.remark = it.remark;
                                if (comPromoted.insertPromoted(enPromoted))
                                {
                                    sb.Append("ปรับปรุงข้อมูลการปรับเงินเดือนเรียบร้อยแล้ว");
                                    sb.Append("\r\n");
                                }
                                else
                                {
                                    sb.Append("ไม่สามารปรับปรุงข้อมูลการปรับเงินเดือนได้");
                                    sb.Append("\r\n");
                                }
                            }
                        }
                        MessageBox.Show(sb.ToString());
                    break;
            }
            Initialize();
        }
        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                clearcontrol();
                int personalID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["_personalID"].Value.ToString());
                txtpersonalID.Text = dgv1.Rows[e.RowIndex].Cells["_personalID"].Value.ToString();
                txtpersonalCode.Text = dgv1.Rows[e.RowIndex].Cells["_personalCode"].Value.ToString();
                txtpersonalCard.Text = dgv1.Rows[e.RowIndex].Cells["_personalCard"].Value.ToString();
                txttitle.Text = dgv1.Rows[e.RowIndex].Cells["_title"].Value.ToString();
                txtname.Text = dgv1.Rows[e.RowIndex].Cells["_name"].Value.ToString();
                txtlastname.Text = dgv1.Rows[e.RowIndex].Cells["_lastname"].Value.ToString();
                txtnickname.Text = dgv1.Rows[e.RowIndex].Cells["_nickname"].Value.ToString();
                cbosex.SelectedValue = dgv1.Rows[e.RowIndex].Cells["_sex"].Value.ToString();
                dbiheight.Value = Convert.ToDouble(dgv1.Rows[e.RowIndex].Cells["_height"].Value.ToString());
                dbiweight.Value = Convert.ToDouble(dgv1.Rows[e.RowIndex].Cells["_weight"].Value.ToString());
                cbobloodGroup.SelectedValue = dgv1.Rows[e.RowIndex].Cells["_bloodGroup"].Value.ToString();
                txtnational.Text = dgv1.Rows[e.RowIndex].Cells["_national"].Value.ToString();
                txtnationality.Text = dgv1.Rows[e.RowIndex].Cells["_nationality"].Value.ToString();
                txtreligion.Text = dgv1.Rows[e.RowIndex].Cells["_religion"].Value.ToString();
                cbopersonalStatus.SelectedValue = dgv1.Rows[e.RowIndex].Cells["_personalStatus"].Value.ToString();
                cbomilitaryStatus.SelectedValue = dgv1.Rows[e.RowIndex].Cells["_militaryStatus"].Value.ToString();
                dtbirthdate.Value = (DateTime)dgv1.Rows[e.RowIndex].Cells["_birthdate"].Value;
                txtoldphoto.Text = dgv1.Rows[e.RowIndex].Cells["_photo"].Value.ToString();
                if (!dgv1.Rows[e.RowIndex].Cells["_photo"].Value.ToString().Equals(string.Empty))
                {
                    using (FileStream stream = new FileStream(dgv1.Rows[e.RowIndex].Cells["_photo"].Value.ToString(), FileMode.Open, FileAccess.Read))
                    {
                        picture1.Image = Image.FromStream(stream);
                        stream.Dispose();
                    }
                }
                //picture1.Image = Image.FromFile(dgv1.Rows[e.RowIndex].Cells["_photo"].Value.ToString());
                if (dgv1.Rows[e.RowIndex].Cells["_status"].Value.ToString().Equals("0"))
                {
                    rdostatus2.Checked = true;
                }
                else
                {
                    rdostatus1.Checked = true;
                }
                DataTable dt;
                dt = comPersonalAddress.selectAllPersonalAddressByPersonalID(personalID).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    txtpersonalAddressID.Text = dt.Rows[0]["personalAddressID"].ToString();
                    txtbuilding.Text = dt.Rows[0]["building"].ToString();
                    txtfloor.Text = dt.Rows[0]["floor"].ToString();
                    txtvillage.Text = dt.Rows[0]["village"].ToString();
                    txtlanes.Text = dt.Rows[0]["lanes"].ToString();
                    txtroad.Text = dt.Rows[0]["road"].ToString();
                    txtsubdistrict.Text = dt.Rows[0]["subdistrict"].ToString();
                    txtpostcode.Text = dt.Rows[0]["postcode"].ToString();
                    txtfax.Text = dt.Rows[0]["fax"].ToString();
                    txtwebsite.Text = dt.Rows[0]["website"].ToString();
                    txtrelation.Text = dt.Rows[0]["relation"].ToString();
                    txtroom.Text = dt.Rows[0]["room"].ToString();
                    txtnumber.Text = dt.Rows[0]["number"].ToString();
                    txtgroup.Text = dt.Rows[0]["group"].ToString();
                    txtdistrict.Text = dt.Rows[0]["district"].ToString();
                    txtprovince.Text = dt.Rows[0]["province"].ToString();
                    txttel.Text = dt.Rows[0]["tel"].ToString();
                    txtemail.Text = dt.Rows[0]["email"].ToString();
                    txtERContact.Text = dt.Rows[0]["ERContact"].ToString();
                    txtcontactNumber.Text = dt.Rows[0]["contactNumber"].ToString();
                }

                
                dt = comWork.selectAllWorkByPersonalID(personalID).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    txtworkID.Text = dt.Rows[0]["workID"].ToString();
                    txtpartyID.Text = dt.Rows[0]["partyID"].ToString();
                    txtdepartmentID.Text = dt.Rows[0]["departmentID"].ToString();
                    txtpositionID.Text = dt.Rows[0]["positionID"].ToString();
                    txtpersonalTypeID.Text = dt.Rows[0]["personalTypeID"].ToString();
                    txtlevel.Text = dt.Rows[0]["level"].ToString();
                    cboworkStatus.SelectedValue = dt.Rows[0]["workStatus"].ToString();
                    dtstartDate.Value = (DateTime)dt.Rows[0]["startDate"];
                    dtresignDate.Value = (DateTime)dt.Rows[0]["resignDate"];
                    txttaxNumber.Text = dt.Rows[0]["taxNumber"].ToString();
                    txtidCard.Text = dt.Rows[0]["idCard"].ToString();
                    dtissueDate.Value = (DateTime)dt.Rows[0]["issueDate"];
                    dtexpireDate.Value = (DateTime)dt.Rows[0]["expireDate"];
                    txtissueAddress.Text = dt.Rows[0]["issueAddress"].ToString();
                    txtidCardAddress.Text = dt.Rows[0]["idCardAddress"].ToString();
                }
                dt = comSalary.selectAllSalaryByPersonalID(personalID).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    txtsalaryID.Text = dt.Rows[0]["salaryID"].ToString();
                    txtbank.Text = dt.Rows[0]["bank"].ToString();
                    txtaccountNumber.Text = dt.Rows[0]["accountNumber"].ToString();
                    cbocalculateType.SelectedValue = dt.Rows[0]["calculateType"].ToString();
                    txtsalary.Text =dt.Rows[0]["salary"].ToString();
                    txtshiftSalary.Text = dt.Rows[0]["shiftSalary"].ToString();
                    if (dt.Rows[0]["calTax"].ToString().Equals("Y"))
                    {
                        rdocalTax_1.Checked = true;
                        rdocalTax_2.Checked = false;
                    }
                    else if (dt.Rows[0]["calTax"].ToString().Equals("N"))
                    {
                        rdocalTax_1.Checked = false;
                        rdocalTax_2.Checked = true;
                    }
                    if (dt.Rows[0]["calSocialTax"].ToString().Equals("Y"))
                    {
                        rdocalSocialTax_1.Checked = true;
                        rdocalSocialTax_2.Checked = false;
                    }
                    else if (dt.Rows[0]["calSocialTax"].ToString().Equals("N"))
                    {
                        rdocalSocialTax_1.Checked = false;
                        rdocalSocialTax_2.Checked = true;
                    }
                    ddllateDeduct.SelectedValue = dt.Rows[0]["lateDeduct"].ToString();
                    ddlleaveDeduct.SelectedValue = dt.Rows[0]["leaveDeduct"].ToString();
                   
                }

                dt = comSocialTax.selectAllSocialTaxByPersonalID(personalID).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    txtsocialTaxID.Text = dt.Rows[0]["socialTaxID"].ToString();
                    txtsocialTaxIDCard.Text = dt.Rows[0]["socialTaxIDCard"].ToString();
                    txthospitalCode.Text = dt.Rows[0]["hospitalCode"].ToString();
                    txthospital.Text = dt.Rows[0]["hospital"].ToString();
                }

                
                dt = comExpenditure.selectAllExpenditureByPersonalID(personalID).Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["expenditureType"].Equals(0))
                    {
                        int idx = gvadd.Rows.Add();
                        DataGridViewRow row = gvadd.Rows[idx];
                        row.Cells["_gvaddexpenditureID"].Value = (int)dt.Rows[i]["expenditureID"];
                        row.Cells["_gvaddpersonalID"].Value = (int)dt.Rows[i]["personalID"];
                        row.Cells["_gvaddexpenditureType"].Value = (int)dt.Rows[i]["expenditureType"];
                        row.Cells["_gvadddescription"].Value = dt.Rows[i]["description"].ToString();
                        row.Cells["_gvaddcalTax"].Value = dt.Rows[i]["calTax"].ToString();
                        row.Cells["_gvaddcalSocialTax"].Value = dt.Rows[i]["calSocialTax"].ToString();
                        row.Cells["_gvaddamount"].Value = dt.Rows[i]["amount"];
                        
                    }
                    else if (dt.Rows[i]["expenditureType"].Equals(1))
                    {
                        int idx = gvminu.Rows.Add();
                        DataGridViewRow row = gvminu.Rows[idx];
                        row.Cells["_gvaddexpenditureID"].Value = (int)dt.Rows[i]["expenditureID"];
                        row.Cells["_gvaddpersonalID"].Value = (int)dt.Rows[i]["personalID"];
                        row.Cells["_gvaddexpenditureType"].Value = (int)dt.Rows[i]["expenditureType"];
                        row.Cells["_gvadddescription"].Value = dt.Rows[i]["description"].ToString();
                        row.Cells["_gvaddcalTax"].Value = dt.Rows[i]["calTax"].ToString();
                        row.Cells["_gvaddcalSocialTax"].Value = dt.Rows[i]["calSocialTax"].ToString();
                        row.Cells["_gvaddamount"].Value = (double)dt.Rows[i]["amount"];
                    }
                }

                
                dt = comLeaveRight.selectAllLeaveRightByPersonalID(personalID).Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int idx = gvleleaveRight.Rows.Add();
                    DataGridViewRow row = gvleleaveRight.Rows[idx];
                    row.Cells["_gvleleaveRightID"].Value = (int)dt.Rows[i]["leaveRightID"];
                    row.Cells["_gvlepersonalID"].Value = (int)dt.Rows[i]["personalID"];
                    row.Cells["_gvleyear"].Value = dt.Rows[i]["year"];
                    row.Cells["_gvledescription"].Value = dt.Rows[i]["description"].ToString();
                    row.Cells["_gvleleaveAmount"].Value = (int)dt.Rows[i]["leaveAmount"];
                    row.Cells["_gvleusedleaveAmount"].Value = (int)dt.Rows[i]["usedLeaveAmount"];
                    row.Cells["_gvlebalanceleaveAmount"].Value = (int)dt.Rows[i]["balanceLeaveAmount"];
                }

                
                dt = comPromoted.selectAllPromotedBypersonalID(personalID).Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int idx = gvppromoted.Rows.Add();
                    DataGridViewRow row = gvppromoted.Rows[idx];
                    row.Cells["_gvppromotedID"].Value = (int)dt.Rows[i]["promotedID"];
                    row.Cells["_gvppersonalID"].Value = dt.Rows[i]["personalID"];
                    row.Cells["_gvpupdateDate"].Value = (DateTime)dt.Rows[i]["updateDate"];
                    row.Cells["_gvpoldSalary"].Value = dt.Rows[i]["oldSalary"];
                    row.Cells["_gvpoldPositionID"].Value = (int)dt.Rows[i]["oldPositionID"];
                    row.Cells["_gvpoldPositionDetail"].Value = dt.Rows[i]["oldPositionDetail"].ToString();
                    row.Cells["_gvpnewSalary"].Value = dt.Rows[i]["newSalary"];
                    row.Cells["_gvpnewPositionID"].Value = (int)dt.Rows[i]["newPositionID"];
                    row.Cells["_gvpnewPositionDetail"].Value = dt.Rows[i]["newPositionDetail"].ToString();
                    row.Cells["_gvpremark"].Value = dt.Rows[i]["remark"].ToString();

                }
            }
        }
        private void lockcontrol()
        {
            dgv1.Enabled = true;
            dgv1.ClearSelection();
            
            txtpersonalCode.Enabled = false;
            txtpersonalCard.Enabled = false;
            txttitle.Enabled = false;
            txtname.Enabled = false;
            txtlastname.Enabled = false;
            txtnickname.Enabled = false;
            cbosex.Enabled = false;
            dbiheight.Enabled = false;
            dbiweight.Enabled = false;
            cbobloodGroup.Enabled = false;
            txtnational.Enabled = false;
            txtnationality.Enabled = false;
            txtreligion.Enabled = false;
            cbopersonalStatus.Enabled = false;
            cbomilitaryStatus.Enabled = false;
            dtbirthdate.Enabled = false;

            txtbuilding.Enabled = false;
            txtfloor.Enabled = false;
            txtvillage.Enabled = false;
            txtlanes.Enabled = false;
            txtroad.Enabled = false;
            txtsubdistrict.Enabled = false;
            txtpostcode.Enabled = false;
            txtfax.Enabled = false;
            txtwebsite.Enabled = false;
            txtrelation.Enabled = false;
            txtroom.Enabled = false;
            txtnumber.Enabled = false;
            txtgroup.Enabled = false;
            txtdistrict.Enabled = false;
            txtprovince.Enabled = false;
            txttel.Enabled = false;
            txtemail.Enabled = false;
            txtERContact.Enabled = false;
            txtcontactNumber.Enabled = false;

            txtpartyID.Enabled = false;
            txtdepartmentID.Enabled = false;
            txtpositionID.Enabled = false;
            txtpersonalTypeID.Enabled = false;
            txtlevel.Enabled = false;
            cboworkStatus.Enabled = false;
            dtstartDate.Enabled = false;
            dtresignDate.Enabled = false;
            txttaxNumber.Enabled = false;
            txtidCard.Enabled = false;
            dtissueDate.Enabled = false;
            dtexpireDate.Enabled = false;
            txtissueAddress.Enabled = false;
            txtidCardAddress.Enabled = false;

            txtbank.Enabled = false;
            txtaccountNumber.Enabled = false;
            cbocalculateType.Enabled = false;
            txtsalary.Enabled = false;
            txtshiftSalary.Enabled = false;
            gbcalTax.Enabled = false;
            gbcalSocialTax.Enabled = false;
            ddllateDeduct.Enabled = false;
            ddlleaveDeduct.Enabled = false;

            txtsocialTaxIDCard.Enabled = false;
            txthospitalCode.Enabled = false;
            txthospital.Enabled = false;

            gexpenditure.Enabled = false;
            gleaveright.Enabled = false;
            gpromoted.Enabled = false;


            rdostatus1.Enabled = false;
            rdostatus2.Enabled = false;

            btnadd.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            btnsave.Enabled = false;
            btncancel.Enabled = false;
            btnbrowse.Enabled = false;
        }
        private void unlockcontrol()
        {
            dgv1.Enabled = false;
            dgv1.ClearSelection();

            txtpersonalCode.Enabled = true;
            txtpersonalCard.Enabled = true;
            txttitle.Enabled = true;
            txtname.Enabled = true;
            txtlastname.Enabled = true;
            txtnickname.Enabled = true;
            cbosex.Enabled = true;
            dbiheight.Enabled = true;
            dbiweight.Enabled = true;
            cbobloodGroup.Enabled = true;
            txtnational.Enabled = true;
            txtnationality.Enabled = true;
            txtreligion.Enabled = true;
            cbopersonalStatus.Enabled = true;
            cbomilitaryStatus.Enabled = true;
            dtbirthdate.Enabled = true;

            rdostatus1.Enabled = true;
            rdostatus2.Enabled = true;

            txtbuilding.Enabled = true;
            txtfloor.Enabled = true;
            txtvillage.Enabled = true;
            txtlanes.Enabled = true;
            txtroad.Enabled = true;
            txtsubdistrict.Enabled = true;
            txtpostcode.Enabled = true;
            txtfax.Enabled = true;
            txtwebsite.Enabled = true;
            txtrelation.Enabled = true;
            txtroom.Enabled = true;
            txtnumber.Enabled = true;
            txtgroup.Enabled = true;
            txtdistrict.Enabled = true;
            txtprovince.Enabled = true;
            txttel.Enabled = true;
            txtemail.Enabled = true;
            txtERContact.Enabled = true;
            txtcontactNumber.Enabled = true;

            txtpartyID.Enabled = true;
            txtdepartmentID.Enabled = true;
            txtpositionID.Enabled = true;
            txtpersonalTypeID.Enabled = true;
            txtlevel.Enabled = true;
            cboworkStatus.Enabled = true;
            dtstartDate.Enabled = true;
            dtresignDate.Enabled = true;
            txttaxNumber.Enabled = true;
            txtidCard.Enabled = true;
            dtissueDate.Enabled = true;
            dtexpireDate.Enabled = true;
            txtissueAddress.Enabled = true;
            txtidCardAddress.Enabled = true;

            txtbank.Enabled = true;
            txtaccountNumber.Enabled = true;
            cbocalculateType.Enabled = true;
            txtsalary.Enabled = true;
            txtshiftSalary.Enabled = true;
            gbcalTax.Enabled = true;
            gbcalSocialTax.Enabled = true;
            ddllateDeduct.Enabled = true;
            ddlleaveDeduct.Enabled = true;

            txtsocialTaxIDCard.Enabled = true;
            txthospitalCode.Enabled = true;
            txthospital.Enabled = true;

            gexpenditure.Enabled = true;
            gleaveright.Enabled = true;
            gpromoted.Enabled = true;

            btnadd.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnsave.Enabled = true;
            btncancel.Enabled = true;
            btnbrowse.Enabled = true;
        }
        private void clearcontrol()
        {
            txtpersonalID.Text = comPersonal.getLastID().Tables[0].Rows[0]["lastID"].ToString();
            txtpersonalCode.Text = "";
            txtpersonalCard.Text = "";
            txttitle.Text = "";
            txtname.Text = "";
            txtlastname.Text = "";
            txtnickname.Text = "";
            dbiheight.Value = 0;
            dbiweight.Value = 0;
            txtnational.Text = "";
            txtnationality.Text = "";
            txtreligion.Text = "";
            dtbirthdate.Value = DateTime.Now;
            txtphoto.Text = "";
            picture1.Image = null;

            txtbuilding.Text = "";
            txtfloor.Text = "";
            txtvillage.Text = "";
            txtlanes.Text = "";
            txtroad.Text = "";
            txtsubdistrict.Text = "";
            txtpostcode.Text = "";
            txtfax.Text = "";
            txtwebsite.Text = "";
            txtrelation.Text = "";
            txtroom.Text = "";
            txtnumber.Text = "";
            txtgroup.Text = "";
            txtdistrict.Text = "";
            txtprovince.Text = "";
            txttel.Text = "";
            txtemail.Text = "";
            txtERContact.Text = "";
            txtcontactNumber.Text = "";

            txtpartyID.Text = "";
            txtdepartmentID.Text = "";
            txtpositionID.Text = "";
            txtpersonalTypeID.Text = "";
            txtlevel.Text = "";
            dtstartDate.Value = DateTime.Now;
            dtresignDate.Value = DateTime.Now;
            txttaxNumber.Text = "";
            txtidCard.Text = "";
            dtissueDate.Value = DateTime.Now;
            dtexpireDate.Value = DateTime.Now;
            txtissueAddress.Text = "";
            txtidCardAddress.Text = "";

            txtbank.Text = "";
            txtaccountNumber.Text = "";
            cbocalculateType.SelectedValue = 0;
            txtsalary.Value = 0;
            txtshiftSalary.Value = 0;
            ddllateDeduct.SelectedValue = 0;
            ddlleaveDeduct.SelectedValue = 0;

            txtsocialTaxIDCard.Text = "";
            txthospitalCode.Text = "";
            txthospital.Text = "";

            gvadd.DataSource = null;
            gvadd.Rows.Clear();
            gvminu.DataSource = null;
            gvminu.Rows.Clear();
            gvleleaveRight.DataSource = null;
            gvleleaveRight.Rows.Clear();
            gvppromoted.DataSource = null;
            gvppromoted.Rows.Clear();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "เลือกรูปภาพพนักงาน";
            openFileDialog1.Filter = "jpg|*.jpg|bmp|*.bmp|png|*.png";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtphoto.Text = openFileDialog1.FileName;
                if (!txtphoto.Text.Equals(String.Empty))
                {
                    picture1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }

        }

        private void dgv1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
        private void txtpartyID_ButtonCustomClick(object sender, EventArgs e)
        {
            partyfrm partyfrm = new partyfrm();
            partyfrm.ShowDialog();
            txtpartyID.Text = string.IsNullOrEmpty(partyfrm.partyID)?"":partyfrm.partyID.ToString();
            partyfrm.Dispose();
        }

        private void txtdepartmentID_ButtonCustomClick(object sender, EventArgs e)
        {
            departmentfrm departmentfrm = new departmentfrm();
            departmentfrm.ShowDialog();
            txtdepartmentID.Text = string.IsNullOrEmpty(departmentfrm.departmentID) ? "" : departmentfrm.departmentID.ToString();
            departmentfrm.Dispose();
        }

        private void txtpositionID_ButtonCustomClick(object sender, EventArgs e)
        {
            positionfrm positionfrm = new positionfrm();
            positionfrm.ShowDialog();
            txtpositionID.Text = string.IsNullOrEmpty(positionfrm.positionID) ? "" : positionfrm.positionID.ToString();
            positionfrm.Dispose();
        }

        private void txtpersonalTypeID_ButtonCustomClick(object sender, EventArgs e)
        {
            personalTypefrm personalTypefrm = new personalTypefrm();
            personalTypefrm.ShowDialog();
            txtpersonalTypeID.Text = string.IsNullOrEmpty(personalTypefrm.personalTypeID) ? "" : personalTypefrm.personalTypeID.ToString();
            personalTypefrm.Dispose();
        }




    }
}
