namespace HRSystem.form
{
    partial class users
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.rdostatus2 = new System.Windows.Forms.RadioButton();
            this.txtuserID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtlastname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdostatus1 = new System.Windows.Forms.RadioButton();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnsearch = new DevComponents.DotNetBar.ButtonX();
            this.txtsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd = new DevComponents.DotNetBar.ButtonX();
            this.btncancel = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.btnedit = new DevComponents.DotNetBar.ButtonX();
            this.btndelete = new DevComponents.DotNetBar.ButtonX();
            this._userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._statusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 110);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(37, 15);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "สถานะ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.rdostatus2);
            this.groupBox2.Controls.Add(this.txtuserID);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.txtlastname);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.rdostatus1);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 135);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "จัดการข้อมูลผู้ใช้";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 19);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(43, 15);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "รหัสผู้ใช้ :";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(219, 78);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(44, 15);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "รหัสผ่าน :";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(6, 78);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(43, 15);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "นามสกุล :";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(219, 50);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(37, 15);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "ชื่อผู้ใช้ :";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 50);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(20, 15);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "ชื่อ :";
            // 
            // rdostatus2
            // 
            this.rdostatus2.AutoSize = true;
            this.rdostatus2.Location = new System.Drawing.Point(135, 110);
            this.rdostatus2.Name = "rdostatus2";
            this.rdostatus2.Size = new System.Drawing.Size(69, 17);
            this.rdostatus2.TabIndex = 10;
            this.rdostatus2.Text = "ไม่ใช้งาน";
            this.rdostatus2.UseVisualStyleBackColor = true;
            // 
            // txtuserID
            // 
            // 
            // 
            // 
            this.txtuserID.Border.Class = "TextBoxBorder";
            this.txtuserID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtuserID.Enabled = false;
            this.txtuserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtuserID.Location = new System.Drawing.Point(73, 19);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.Size = new System.Drawing.Size(128, 22);
            this.txtuserID.TabIndex = 0;
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpassword.Location = new System.Drawing.Point(286, 75);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(128, 22);
            this.txtpassword.TabIndex = 0;
            // 
            // txtlastname
            // 
            // 
            // 
            // 
            this.txtlastname.Border.Class = "TextBoxBorder";
            this.txtlastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtlastname.Location = new System.Drawing.Point(73, 75);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(128, 22);
            this.txtlastname.TabIndex = 0;
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.Border.Class = "TextBoxBorder";
            this.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtusername.Location = new System.Drawing.Point(286, 47);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(128, 22);
            this.txtusername.TabIndex = 0;
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtname.Location = new System.Drawing.Point(73, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(128, 22);
            this.txtname.TabIndex = 0;
            // 
            // rdostatus1
            // 
            this.rdostatus1.AutoSize = true;
            this.rdostatus1.Checked = true;
            this.rdostatus1.Location = new System.Drawing.Point(73, 109);
            this.rdostatus1.Name = "rdostatus1";
            this.rdostatus1.Size = new System.Drawing.Size(56, 17);
            this.rdostatus1.TabIndex = 10;
            this.rdostatus1.TabStop = true;
            this.rdostatus1.Text = "ใช้งาน";
            this.rdostatus1.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._userID,
            this._name,
            this._lastname,
            this._username,
            this._password,
            this._statusName,
            this._status});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv1.Location = new System.Drawing.Point(12, 74);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(545, 150);
            this.dgv1.TabIndex = 34;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParty_CellMouseClick);
            // 
            // btnsearch
            // 
            this.btnsearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearch.Location = new System.Drawing.Point(179, 19);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(39, 20);
            this.btnsearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearch.TabIndex = 1;
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
            this.txtsearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 49);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // btnadd
            // 
            this.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnadd.Image = global::HRSystem.Properties.Resources.linedpaperplus32;
            this.btnadd.Location = new System.Drawing.Point(12, 373);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 67);
            this.btnadd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnadd.TabIndex = 32;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncancel.Image = global::HRSystem.Properties.Resources.undo2;
            this.btncancel.Location = new System.Drawing.Point(336, 373);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 67);
            this.btncancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncancel.TabIndex = 28;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Image = global::HRSystem.Properties.Resources.notecheck32;
            this.btnsave.Location = new System.Drawing.Point(255, 373);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 67);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnedit.Image = global::HRSystem.Properties.Resources.linedpaperpencil32;
            this.btnedit.Location = new System.Drawing.Point(93, 373);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 67);
            this.btnedit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnedit.TabIndex = 31;
            this.btnedit.Text = "Edit";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndelete.Image = global::HRSystem.Properties.Resources.linedpaperminus32;
            this.btndelete.Location = new System.Drawing.Point(174, 373);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 67);
            this.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // _userID
            // 
            this._userID.DataPropertyName = "userID";
            this._userID.HeaderText = "รหัสผู้ใช้";
            this._userID.Name = "_userID";
            this._userID.ReadOnly = true;
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
            // _username
            // 
            this._username.DataPropertyName = "username";
            this._username.HeaderText = "ชื่อผู้ใช้";
            this._username.Name = "_username";
            this._username.ReadOnly = true;
            // 
            // _password
            // 
            this._password.DataPropertyName = "password";
            this._password.HeaderText = "_password";
            this._password.Name = "_password";
            this._password.ReadOnly = true;
            this._password.Visible = false;
            // 
            // _statusName
            // 
            this._statusName.DataPropertyName = "statusName";
            this._statusName.HeaderText = "สถานะ";
            this._statusName.Name = "_statusName";
            this._statusName.ReadOnly = true;
            // 
            // _status
            // 
            this._status.DataPropertyName = "status";
            this._status.HeaderText = "_status";
            this._status.Name = "_status";
            this._status.ReadOnly = true;
            this._status.Visible = false;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 452);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndelete);
            this.DoubleBuffered = true;
            this.Name = "users";
            this.Text = "ข้อมูลผู้ใช้งานในระบบ";
            this.Load += new System.EventHandler(this.users_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnadd;
        private DevComponents.DotNetBar.ButtonX btncancel;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX btnedit;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton rdostatus2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtuserID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        private System.Windows.Forms.RadioButton rdostatus1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        private DevComponents.DotNetBar.ButtonX btnsearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btndelete;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlastname;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn _userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn _username;
        private System.Windows.Forms.DataGridViewTextBoxColumn _password;
        private System.Windows.Forms.DataGridViewTextBoxColumn _statusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _status;
    }
}