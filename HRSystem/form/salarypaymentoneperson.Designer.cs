namespace HRSystem.form
{
    partial class salarypaymentoneperson
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this._personalCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._timein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._leave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._late = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._latecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._early = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._earlycount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnprint = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            this.dateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpersonalCard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtleave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlatecount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.txtearly = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            this.txtearlycount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.txtot = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            this.SuspendLayout();
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
            this._personalCard,
            this._date,
            this._timein,
            this._timeout,
            this._leave,
            this._late,
            this._latecount,
            this._early,
            this._earlycount,
            this._ot});
            this.dgv1.Location = new System.Drawing.Point(12, 103);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(761, 276);
            this.dgv1.TabIndex = 3;
            // 
            // _personalCard
            // 
            this._personalCard.HeaderText = "_personalCard";
            this._personalCard.Name = "_personalCard";
            this._personalCard.ReadOnly = true;
            this._personalCard.Visible = false;
            // 
            // _date
            // 
            this._date.DataPropertyName = "_date";
            this._date.HeaderText = "วันที่";
            this._date.Name = "_date";
            this._date.ReadOnly = true;
            // 
            // _timein
            // 
            this._timein.DataPropertyName = "_timein";
            this._timein.HeaderText = "เวลาเข้า";
            this._timein.Name = "_timein";
            this._timein.ReadOnly = true;
            // 
            // _timeout
            // 
            this._timeout.DataPropertyName = "_timeout";
            this._timeout.HeaderText = "เวลาออก";
            this._timeout.Name = "_timeout";
            this._timeout.ReadOnly = true;
            // 
            // _leave
            // 
            this._leave.DataPropertyName = "_leave";
            this._leave.HeaderText = "ขาดงาน";
            this._leave.Name = "_leave";
            this._leave.ReadOnly = true;
            // 
            // _late
            // 
            this._late.DataPropertyName = "_late";
            this._late.HeaderText = "เข้าสาย >30 นาที";
            this._late.Name = "_late";
            this._late.ReadOnly = true;
            // 
            // _latecount
            // 
            this._latecount.DataPropertyName = "_latecount";
            this._latecount.HeaderText = "เข้าสาย(นาที)";
            this._latecount.Name = "_latecount";
            this._latecount.ReadOnly = true;
            // 
            // _early
            // 
            this._early.DataPropertyName = "_early";
            this._early.HeaderText = "ออกก่อน";
            this._early.Name = "_early";
            this._early.ReadOnly = true;
            // 
            // _earlycount
            // 
            this._earlycount.DataPropertyName = "_earlycount";
            this._earlycount.HeaderText = "ออกก่อน(นาที)";
            this._earlycount.Name = "_earlycount";
            this._earlycount.ReadOnly = true;
            // 
            // _ot
            // 
            this._ot.DataPropertyName = "_ot";
            this._ot.HeaderText = "OT";
            this._ot.Name = "_ot";
            this._ot.ReadOnly = true;
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
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "คำนวณเงืนเดือน";
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
            this.btnprint.Text = "บันทึกเงินเดือน";
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
            this.btnshow.Text = "คำนวณเงินเดือน";
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
            this.progressBarX1.Location = new System.Drawing.Point(12, 409);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(761, 23);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressBarX1.TabIndex = 5;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "ขาดงาน :";
            // 
            // txtleave
            // 
            this.txtleave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtleave.Border.Class = "TextBoxBorder";
            this.txtleave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtleave.Location = new System.Drawing.Point(67, 385);
            this.txtleave.Name = "txtleave";
            this.txtleave.Size = new System.Drawing.Size(43, 20);
            this.txtleave.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "เข้าสาย > 30 นาที :";
            // 
            // txtlate
            // 
            this.txtlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtlate.Border.Class = "TextBoxBorder";
            this.txtlate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlate.Location = new System.Drawing.Point(218, 385);
            this.txtlate.Name = "txtlate";
            this.txtlate.Size = new System.Drawing.Size(43, 20);
            this.txtlate.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "เข้าสาย (นาที) :";
            // 
            // txtlatecount
            // 
            this.txtlatecount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtlatecount.Border.Class = "TextBoxBorder";
            this.txtlatecount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlatecount.Location = new System.Drawing.Point(349, 385);
            this.txtlatecount.Name = "txtlatecount";
            this.txtlatecount.Size = new System.Drawing.Size(43, 20);
            this.txtlatecount.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ออกก่อน :";
            // 
            // txtearly
            // 
            this.txtearly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtearly.Border.Class = "TextBoxBorder";
            this.txtearly.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtearly.Location = new System.Drawing.Point(451, 385);
            this.txtearly.Name = "txtearly";
            this.txtearly.Size = new System.Drawing.Size(43, 20);
            this.txtearly.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "ออกก่อน (นาที) :";
            // 
            // txtearlycount
            // 
            this.txtearlycount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtearlycount.Border.Class = "TextBoxBorder";
            this.txtearlycount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtearlycount.Location = new System.Drawing.Point(588, 385);
            this.txtearlycount.Name = "txtearlycount";
            this.txtearlycount.Size = new System.Drawing.Size(43, 20);
            this.txtearlycount.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(637, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "OT (นาที) :";
            // 
            // txtot
            // 
            this.txtot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtot.Border.Class = "TextBoxBorder";
            this.txtot.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtot.Location = new System.Drawing.Point(700, 385);
            this.txtot.Name = "txtot";
            this.txtot.Size = new System.Drawing.Size(43, 20);
            this.txtot.TabIndex = 33;
            // 
            // salarypaymentoneperson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 444);
            this.Controls.Add(this.txtlate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlatecount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtot);
            this.Controls.Add(this.txtearlycount);
            this.Controls.Add(this.txtearly);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtleave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "salarypaymentoneperson";
            this.Text = "จ่ายเงินเดือนรายบุคคล";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnprint;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpersonalCard;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtleave;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlate;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlatecount;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtearly;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtearlycount;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtot;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn _date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timein;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn _leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn _late;
        private System.Windows.Forms.DataGridViewTextBoxColumn _latecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _early;
        private System.Windows.Forms.DataGridViewTextBoxColumn _earlycount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ot;
    }
}