namespace HRSystem.form
{
    partial class personalfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new DevComponents.DotNetBar.ButtonX();
            this.txtsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this._personalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personalCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._national = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._militaryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._statusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 49);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // btnsearch
            // 
            this.btnsearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearch.Location = new System.Drawing.Point(179, 19);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(39, 20);
            this.btnsearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "ค้นหา";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            // 
            // 
            // 
            this.txtsearch.Border.Class = "TextBoxBorder";
            this.txtsearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsearch.Location = new System.Drawing.Point(6, 19);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(167, 20);
            this.txtsearch.TabIndex = 1;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._personalID,
            this._personalCode,
            this._personalCard,
            this._title,
            this._name,
            this._lastname,
            this._nickname,
            this._sex,
            this._height,
            this._weight,
            this._bloodGroup,
            this._national,
            this._nationality,
            this._religion,
            this._personalStatus,
            this._birthdate,
            this._militaryStatus,
            this._photo,
            this._statusName,
            this._status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv1.Location = new System.Drawing.Point(12, 74);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(721, 150);
            this.dgv1.TabIndex = 26;
            this.dgv1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseDoubleClick);
            // 
            // _personalID
            // 
            this._personalID.DataPropertyName = "personalID";
            this._personalID.HeaderText = "ลำดับ";
            this._personalID.Name = "_personalID";
            this._personalID.ReadOnly = true;
            this._personalID.Width = 60;
            // 
            // _personalCode
            // 
            this._personalCode.DataPropertyName = "personalCode";
            this._personalCode.HeaderText = "รหัสพนักงาน";
            this._personalCode.Name = "_personalCode";
            this._personalCode.ReadOnly = true;
            this._personalCode.Width = 60;
            // 
            // _personalCard
            // 
            this._personalCard.DataPropertyName = "personalCard";
            this._personalCard.HeaderText = "รหัสบัตร";
            this._personalCard.Name = "_personalCard";
            this._personalCard.ReadOnly = true;
            this._personalCard.Width = 60;
            // 
            // _title
            // 
            this._title.DataPropertyName = "title";
            this._title.HeaderText = "คำนำหน้า";
            this._title.Name = "_title";
            this._title.ReadOnly = true;
            this._title.Width = 30;
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
            // _nickname
            // 
            this._nickname.DataPropertyName = "nickname";
            this._nickname.HeaderText = "ชื่อเล่น";
            this._nickname.Name = "_nickname";
            this._nickname.ReadOnly = true;
            // 
            // _sex
            // 
            this._sex.DataPropertyName = "sex";
            this._sex.HeaderText = "เพศ";
            this._sex.Name = "_sex";
            this._sex.ReadOnly = true;
            this._sex.Width = 30;
            // 
            // _height
            // 
            this._height.DataPropertyName = "height";
            this._height.HeaderText = "ส่วนสูง";
            this._height.Name = "_height";
            this._height.ReadOnly = true;
            this._height.Width = 30;
            // 
            // _weight
            // 
            this._weight.DataPropertyName = "weight";
            this._weight.HeaderText = "น้ำหนัก";
            this._weight.Name = "_weight";
            this._weight.ReadOnly = true;
            this._weight.Width = 30;
            // 
            // _bloodGroup
            // 
            this._bloodGroup.DataPropertyName = "bloodGroup";
            this._bloodGroup.HeaderText = "หมู่เลือด";
            this._bloodGroup.Name = "_bloodGroup";
            this._bloodGroup.ReadOnly = true;
            this._bloodGroup.Width = 30;
            // 
            // _national
            // 
            this._national.DataPropertyName = "national";
            this._national.HeaderText = "เชื่อชาติ";
            this._national.Name = "_national";
            this._national.ReadOnly = true;
            this._national.Width = 60;
            // 
            // _nationality
            // 
            this._nationality.DataPropertyName = "nationality";
            this._nationality.HeaderText = "สัญชาติ";
            this._nationality.Name = "_nationality";
            this._nationality.ReadOnly = true;
            this._nationality.Width = 60;
            // 
            // _religion
            // 
            this._religion.DataPropertyName = "religion";
            this._religion.HeaderText = "ศาสนา";
            this._religion.Name = "_religion";
            this._religion.ReadOnly = true;
            this._religion.Width = 60;
            // 
            // _personalStatus
            // 
            this._personalStatus.DataPropertyName = "personalStatus";
            this._personalStatus.HeaderText = "สถานะ";
            this._personalStatus.Name = "_personalStatus";
            this._personalStatus.ReadOnly = true;
            this._personalStatus.Width = 60;
            // 
            // _birthdate
            // 
            this._birthdate.DataPropertyName = "birthdate";
            this._birthdate.HeaderText = "วันเกิด";
            this._birthdate.Name = "_birthdate";
            this._birthdate.ReadOnly = true;
            this._birthdate.Width = 60;
            // 
            // _militaryStatus
            // 
            this._militaryStatus.DataPropertyName = "militaryStatus";
            this._militaryStatus.HeaderText = "สถานะภาพทางทหาร";
            this._militaryStatus.Name = "_militaryStatus";
            this._militaryStatus.ReadOnly = true;
            this._militaryStatus.Width = 60;
            // 
            // _photo
            // 
            this._photo.DataPropertyName = "photo";
            this._photo.HeaderText = "_photo";
            this._photo.Name = "_photo";
            this._photo.ReadOnly = true;
            this._photo.Visible = false;
            // 
            // _statusName
            // 
            this._statusName.DataPropertyName = "statusName";
            this._statusName.HeaderText = "สถานะ";
            this._statusName.Name = "_statusName";
            this._statusName.ReadOnly = true;
            this._statusName.Width = 60;
            // 
            // _status
            // 
            this._status.DataPropertyName = "status";
            this._status.HeaderText = "_status";
            this._status.Name = "_status";
            this._status.ReadOnly = true;
            this._status.Visible = false;
            // 
            // personalfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.DoubleBuffered = true;
            this.Name = "personalfrm";
            this.Text = "ค้นหาข้อมูลพนักงาน";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnsearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn _title;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn _height;
        private System.Windows.Forms.DataGridViewTextBoxColumn _weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn _national;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn _religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn _birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _militaryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn _photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _statusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _status;
    }
}