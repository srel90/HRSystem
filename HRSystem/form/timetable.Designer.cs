namespace HRSystem.form
{
    partial class timetable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttextfile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.btnopenfile = new DevComponents.DotNetBar.ButtonX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.gridtimetable = new System.Windows.Forms.DataGridView();
            this._personalIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._timetable = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this._onduty = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this._offduty = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this._clockIn = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this._clockOut = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridtimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txttextfile);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnopenfile);
            this.groupBox1.Controls.Add(this.progressBarX1);
            this.groupBox1.Controls.Add(this.gridtimetable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ดึงข้อมูลจากเครื่องลงเวลา";
            // 
            // txttextfile
            // 
            // 
            // 
            // 
            this.txttextfile.Border.Class = "TextBoxBorder";
            this.txttextfile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttextfile.Location = new System.Drawing.Point(14, 28);
            this.txttextfile.Name = "txttextfile";
            this.txttextfile.Size = new System.Drawing.Size(467, 20);
            this.txttextfile.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Location = new System.Drawing.Point(649, 28);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 20);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "บันทึก";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnclear.Location = new System.Drawing.Point(568, 28);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 20);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "ล้าง";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnopenfile
            // 
            this.btnopenfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnopenfile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnopenfile.Location = new System.Drawing.Point(487, 28);
            this.btnopenfile.Name = "btnopenfile";
            this.btnopenfile.Size = new System.Drawing.Size(75, 20);
            this.btnopenfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnopenfile.TabIndex = 2;
            this.btnopenfile.Text = "เปิดไฟล์";
            this.btnopenfile.Click += new System.EventHandler(this.btnopenfile_Click);
            // 
            // progressBarX1
            // 
            this.progressBarX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarX1.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.Class = "";
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(14, 366);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(754, 23);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressBarX1.TabIndex = 4;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // gridtimetable
            // 
            this.gridtimetable.AllowUserToAddRows = false;
            this.gridtimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridtimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._personalIDCard,
            this._timetable,
            this._onduty,
            this._offduty,
            this._clockIn,
            this._clockOut});
            this.gridtimetable.Location = new System.Drawing.Point(14, 57);
            this.gridtimetable.Name = "gridtimetable";
            this.gridtimetable.Size = new System.Drawing.Size(754, 303);
            this.gridtimetable.TabIndex = 0;
            // 
            // _personalIDCard
            // 
            this._personalIDCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._personalIDCard.HeaderText = "รหัสบัตรพนักงาน";
            this._personalIDCard.Name = "_personalIDCard";
            // 
            // _timetable
            // 
            this._timetable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._timetable.HeaderText = "วันที่";
            this._timetable.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this._timetable.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._timetable.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this._timetable.MonthCalendar.BackgroundStyle.Class = "";
            this._timetable.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._timetable.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this._timetable.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._timetable.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this._timetable.MonthCalendar.MarkedDates = new System.DateTime[0];
            this._timetable.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._timetable.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this._timetable.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._timetable.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this._timetable.Name = "_timetable";
            this._timetable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._timetable.ShowUpDown = true;
            // 
            // _onduty
            // 
            this._onduty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._onduty.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._onduty.BackgroundStyle.Class = "TextBoxBorder";
            this._onduty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._onduty.Culture = new System.Globalization.CultureInfo("en-US");
            this._onduty.ForeColor = System.Drawing.SystemColors.ControlText;
            this._onduty.HeaderText = "เวลาเริ่มงาน";
            this._onduty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._onduty.Mask = "##:##";
            this._onduty.Name = "_onduty";
            this._onduty.PasswordChar = '\0';
            this._onduty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._onduty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._onduty.Text = "  :";
            // 
            // _offduty
            // 
            this._offduty.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._offduty.BackgroundStyle.Class = "TextBoxBorder";
            this._offduty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._offduty.Culture = new System.Globalization.CultureInfo("en-US");
            this._offduty.ForeColor = System.Drawing.SystemColors.ControlText;
            this._offduty.HeaderText = "เวลาเลิกงาน";
            this._offduty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._offduty.Mask = "##:##";
            this._offduty.Name = "_offduty";
            this._offduty.PasswordChar = '\0';
            this._offduty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._offduty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._offduty.Text = "  :";
            // 
            // _clockIn
            // 
            this._clockIn.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._clockIn.BackgroundStyle.Class = "TextBoxBorder";
            this._clockIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._clockIn.Culture = new System.Globalization.CultureInfo("en-US");
            this._clockIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this._clockIn.HeaderText = "ลงเวลาเข้า";
            this._clockIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._clockIn.Mask = "##:##";
            this._clockIn.Name = "_clockIn";
            this._clockIn.PasswordChar = '\0';
            this._clockIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._clockIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._clockIn.Text = "  :";
            // 
            // _clockOut
            // 
            this._clockOut.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._clockOut.BackgroundStyle.Class = "TextBoxBorder";
            this._clockOut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._clockOut.Culture = new System.Globalization.CultureInfo("en-US");
            this._clockOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this._clockOut.HeaderText = "ลงเวลาออก";
            this._clockOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._clockOut.Mask = "##:##";
            this._clockOut.Name = "_clockOut";
            this._clockOut.PasswordChar = '\0';
            this._clockOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._clockOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._clockOut.Text = "  :";
            // 
            // timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 426);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "timetable";
            this.Text = "ดึงเวลาทำงานจากเครื่องบันทึกเวลา";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridtimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridtimetable;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttextfile;
        private DevComponents.DotNetBar.ButtonX btnopenfile;
        private DevComponents.DotNetBar.ButtonX btnclear;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalIDCard;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn _timetable;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _onduty;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _offduty;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _clockIn;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _clockOut;
    }
}