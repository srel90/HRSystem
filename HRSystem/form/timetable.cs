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
using HRSystem.entity;
using HRSystem.com;
using HRSystem.form;
namespace HRSystem.form
{
    public partial class timetable : DevComponents.DotNetBar.Office2007Form
    {
        
        public timetable()
        {
            InitializeComponent();
        }

        private void btnopenfile_Click(object sender, EventArgs e)
        {
            Boolean formatchk = false;
            
            openFileDialog1.Title = "เลือกไฟล์ลงเวลาปฏิบัติงานของพนักงาน";
            openFileDialog1.Filter = "Text File|*.txt";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                gridtimetable.Rows.Clear();
                txttextfile.Text = openFileDialog1.FileName;
                if (!txttextfile.Text.Equals(String.Empty))
                {
                    string[] lines = System.IO.File.ReadAllLines(@txttextfile.Text);
                    string[] line;
                    foreach (var it in lines)
                    {
                        line = Regex.Replace(it, @"\s+", " ").Trim().Split(' ');
                        if (line.Length == 7)
                        {
                            formatchk = true;
                            int idx = gridtimetable.Rows.Add();
                            DataGridViewRow row = gridtimetable.Rows[idx];
                            row.Cells["_personalIDCard"].Value = line[0].ToString();
                            string[] dt = line[1].Split('/');
                            row.Cells["_timetable"].Value = dt[2]+"-"+dt[1]+"-"+dt[0];
                            row.Cells["_onduty"].Value = line[3].ToString();
                            row.Cells["_offduty"].Value = line[4].ToString();
                            row.Cells["_clockIn"].Value = line[5].ToString();
                            row.Cells["_clockOut"].Value = line[6].ToString();
                        }
                        
                    }
                    if (!formatchk)
                    {
                        MessageBox.Show("รูปแบบข้อมูลไม่ถูกต้อง");
                    }

                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            enTimeTable enTimeTable = new enTimeTable();
            comTimeTable comTimeTable=new comTimeTable();
            int rowcount = gridtimetable.Rows.Count;
            int i = 1;
            if (rowcount != 0)
            {
                foreach (DataGridViewRow row in gridtimetable.Rows)
                {
                    Double tick = (100.0/rowcount)*i;
                    progressBarX1.Value =Convert.ToInt32(Math.Ceiling(tick));
                    enTimeTable.personalCard=row.Cells["_personalIDCard"].Value.ToString();
                    enTimeTable.timetable = row.Cells["_timetable"].Value.ToString();
                    enTimeTable.onduty = row.Cells["_onduty"].Value.ToString();
                    enTimeTable.offduty = row.Cells["_offduty"].Value.ToString();
                    enTimeTable.clockIn = row.Cells["_clockIn"].Value.ToString();
                    enTimeTable.clockOut = row.Cells["_clockOut"].Value.ToString();
                    comTimeTable.insertTimeTable(enTimeTable);
                    i++;
                }
                if (progressBarX1.Value >= 100)
                {
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
                    gridtimetable.Rows.Clear();
                    progressBarX1.Value = 0;
                    txttextfile.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูลที่ต้องการบันทึก");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            gridtimetable.Rows.Clear();
            progressBarX1.Value = 0;
            txttextfile.Text = string.Empty;
        }
    }
}
