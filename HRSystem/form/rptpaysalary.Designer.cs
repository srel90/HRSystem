namespace HRSystem.form
{
    partial class rptpaysalary
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
            this.btnprint = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            this.dateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpersonalCard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this._paymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._payDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._expenditureInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._expenditureDec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._leaveDec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lateDec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._OTInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._socialTaxDec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._taxDec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnprint.Location = new System.Drawing.Point(682, 19);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(73, 48);
            this.btnprint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "พิมพ์สลิปเงินเดือน";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnshow
            // 
            this.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnshow.Location = new System.Drawing.Point(602, 19);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(73, 48);
            this.btnshow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "ค้นหา";
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dateTo
            // 
            // 
            // 
            // 
            this.dateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTo.ButtonDropDown.Visible = true;
            this.dateTo.Location = new System.Drawing.Point(396, 47);
            // 
            // 
            // 
            this.dateTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTo.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this.dateTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.TodayButtonVisible = true;
            this.dateTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTo.Name = "dateTo";
            this.dateTo.ShowUpDown = true;
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTo.TabIndex = 3;
            // 
            // dateFrom
            // 
            // 
            // 
            // 
            this.dateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateFrom.ButtonDropDown.Visible = true;
            this.dateFrom.Location = new System.Drawing.Point(118, 47);
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateFrom.MonthCalendar.BackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this.dateFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShowUpDown = true;
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateFrom.TabIndex = 2;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "ถึงวันที่ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ตั้งแต่วันที่ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "รหัสพนักงาน :";
            // 
            // txtpersonalCard
            // 
            // 
            // 
            // 
            this.txtpersonalCard.Border.Class = "TextBoxBorder";
            this.txtpersonalCard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpersonalCard.ButtonCustom.Visible = true;
            this.txtpersonalCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpersonalCard.Location = new System.Drawing.Point(118, 19);
            this.txtpersonalCard.Name = "txtpersonalCard";
            this.txtpersonalCard.Size = new System.Drawing.Size(86, 22);
            this.txtpersonalCard.TabIndex = 1;
            this.txtpersonalCard.ButtonCustomClick += new System.EventHandler(this.txtpersonalCard_ButtonCustomClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.btnshow);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpersonalCard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 85);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "คำนวณเงืนเดือน";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._paymentID,
            this._personalID,
            this._title,
            this._name,
            this._lastname,
            this._party,
            this._department,
            this._position,
            this._startDate,
            this._endDate,
            this._payDate,
            this._expenditureInc,
            this._expenditureDec,
            this._leaveDec,
            this._lateDec,
            this._OTInc,
            this._socialTaxDec,
            this._taxDec,
            this._salary,
            this._total});
            this.dgv1.Location = new System.Drawing.Point(12, 103);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(761, 329);
            this.dgv1.TabIndex = 35;
            this.dgv1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv1_DataBindingComplete);
            // 
            // _paymentID
            // 
            this._paymentID.DataPropertyName = "paymentID";
            this._paymentID.HeaderText = "_paymentID";
            this._paymentID.Name = "_paymentID";
            this._paymentID.ReadOnly = true;
            this._paymentID.Visible = false;
            // 
            // _personalID
            // 
            this._personalID.DataPropertyName = "personalID";
            this._personalID.HeaderText = "รหัสพนักงาน";
            this._personalID.Name = "_personalID";
            this._personalID.ReadOnly = true;
            // 
            // _title
            // 
            this._title.DataPropertyName = "title";
            this._title.HeaderText = "คำนำหน้า";
            this._title.Name = "_title";
            this._title.ReadOnly = true;
            // 
            // _name
            // 
            this._name.DataPropertyName = "name";
            this._name.HeaderText = "ชื่อ";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            // 
            // _lastname
            // 
            this._lastname.DataPropertyName = "lastname";
            this._lastname.HeaderText = "นามสกุล";
            this._lastname.Name = "_lastname";
            this._lastname.ReadOnly = true;
            // 
            // _party
            // 
            this._party.DataPropertyName = "party";
            this._party.HeaderText = "ฝ่าย";
            this._party.Name = "_party";
            this._party.ReadOnly = true;
            // 
            // _department
            // 
            this._department.DataPropertyName = "department";
            this._department.HeaderText = "แผนก";
            this._department.Name = "_department";
            this._department.ReadOnly = true;
            // 
            // _position
            // 
            this._position.DataPropertyName = "position";
            this._position.HeaderText = "ตำแหน่ง";
            this._position.Name = "_position";
            this._position.ReadOnly = true;
            // 
            // _startDate
            // 
            this._startDate.DataPropertyName = "startDate";
            this._startDate.HeaderText = "วันเริ่มต้น";
            this._startDate.Name = "_startDate";
            this._startDate.ReadOnly = true;
            // 
            // _endDate
            // 
            this._endDate.DataPropertyName = "endDate";
            this._endDate.HeaderText = "วันสิ้นสุด";
            this._endDate.Name = "_endDate";
            this._endDate.ReadOnly = true;
            // 
            // _payDate
            // 
            this._payDate.DataPropertyName = "payDate";
            this._payDate.HeaderText = "วันที่บันทึกเงินเดือน";
            this._payDate.Name = "_payDate";
            this._payDate.ReadOnly = true;
            // 
            // _expenditureInc
            // 
            this._expenditureInc.DataPropertyName = "expenditureInc";
            this._expenditureInc.HeaderText = "รายรับ";
            this._expenditureInc.Name = "_expenditureInc";
            this._expenditureInc.ReadOnly = true;
            // 
            // _expenditureDec
            // 
            this._expenditureDec.DataPropertyName = "expenditureDec";
            this._expenditureDec.HeaderText = "รายจ่าย";
            this._expenditureDec.Name = "_expenditureDec";
            this._expenditureDec.ReadOnly = true;
            // 
            // _leaveDec
            // 
            this._leaveDec.DataPropertyName = "leaveDec";
            this._leaveDec.HeaderText = "หักขาดงาน";
            this._leaveDec.Name = "_leaveDec";
            this._leaveDec.ReadOnly = true;
            // 
            // _lateDec
            // 
            this._lateDec.DataPropertyName = "lateDec";
            this._lateDec.HeaderText = "หักสาย";
            this._lateDec.Name = "_lateDec";
            this._lateDec.ReadOnly = true;
            // 
            // _OTInc
            // 
            this._OTInc.DataPropertyName = "OTInc";
            this._OTInc.HeaderText = "ค่าล่วงเวลา";
            this._OTInc.Name = "_OTInc";
            this._OTInc.ReadOnly = true;
            // 
            // _socialTaxDec
            // 
            this._socialTaxDec.DataPropertyName = "socialTaxDec";
            this._socialTaxDec.HeaderText = "หักประกันสังคม";
            this._socialTaxDec.Name = "_socialTaxDec";
            this._socialTaxDec.ReadOnly = true;
            // 
            // _taxDec
            // 
            this._taxDec.DataPropertyName = "taxDec";
            this._taxDec.HeaderText = "นำส่งภาษ๊";
            this._taxDec.Name = "_taxDec";
            this._taxDec.ReadOnly = true;
            // 
            // _salary
            // 
            this._salary.DataPropertyName = "salary";
            this._salary.HeaderText = "เงินเดือน";
            this._salary.Name = "_salary";
            this._salary.ReadOnly = true;
            // 
            // _total
            // 
            this._total.DataPropertyName = "total";
            this._total.HeaderText = "ยอดสุทธิ";
            this._total.Name = "_total";
            this._total.ReadOnly = true;
            // 
            // rptpaysalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.Name = "rptpaysalary";
            this.Text = "รายงานการจ่ายเงินเดือน";
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnprint;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpersonalCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _paymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _title;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn _party;
        private System.Windows.Forms.DataGridViewTextBoxColumn _department;
        private System.Windows.Forms.DataGridViewTextBoxColumn _position;
        private System.Windows.Forms.DataGridViewTextBoxColumn _startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _payDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _expenditureInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn _expenditureDec;
        private System.Windows.Forms.DataGridViewTextBoxColumn _leaveDec;
        private System.Windows.Forms.DataGridViewTextBoxColumn _lateDec;
        private System.Windows.Forms.DataGridViewTextBoxColumn _OTInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn _socialTaxDec;
        private System.Windows.Forms.DataGridViewTextBoxColumn _taxDec;
        private System.Windows.Forms.DataGridViewTextBoxColumn _salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn _total;
    }
}