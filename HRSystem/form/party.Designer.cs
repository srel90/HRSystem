﻿namespace HRSystem.form
{
    partial class party
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new DevComponents.DotNetBar.ButtonX();
            this.txtsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvParty = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this._partyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._statusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdostatus1 = new System.Windows.Forms.RadioButton();
            this.rdostatus2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtpartyID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btncancel = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.btndelete = new DevComponents.DotNetBar.ButtonX();
            this.btnedit = new DevComponents.DotNetBar.ButtonX();
            this.btnadd = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(412, 49);
            this.groupBox1.TabIndex = 7;
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
            // dgvParty
            // 
            this.dgvParty.AllowUserToAddRows = false;
            this.dgvParty.AllowUserToDeleteRows = false;
            this.dgvParty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._partyID,
            this._name,
            this._statusName,
            this._status});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParty.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParty.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvParty.Location = new System.Drawing.Point(12, 74);
            this.dgvParty.Name = "dgvParty";
            this.dgvParty.ReadOnly = true;
            this.dgvParty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParty.Size = new System.Drawing.Size(412, 150);
            this.dgvParty.TabIndex = 8;
            this.dgvParty.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParty_CellMouseClick);
            // 
            // _partyID
            // 
            this._partyID.DataPropertyName = "partyID";
            this._partyID.HeaderText = "รหัสฝ่าย";
            this._partyID.Name = "_partyID";
            this._partyID.ReadOnly = true;
            // 
            // _name
            // 
            this._name.DataPropertyName = "name";
            this._name.HeaderText = "ฝ่าย";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
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
            this.labelX1.Size = new System.Drawing.Size(37, 15);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "ชื่อฝ่าย :";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 76);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(37, 15);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "สถานะ :";
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtname.Location = new System.Drawing.Point(49, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(128, 22);
            this.txtname.TabIndex = 0;
            // 
            // rdostatus1
            // 
            this.rdostatus1.AutoSize = true;
            this.rdostatus1.Checked = true;
            this.rdostatus1.Location = new System.Drawing.Point(49, 75);
            this.rdostatus1.Name = "rdostatus1";
            this.rdostatus1.Size = new System.Drawing.Size(56, 17);
            this.rdostatus1.TabIndex = 10;
            this.rdostatus1.TabStop = true;
            this.rdostatus1.Text = "ใช้งาน";
            this.rdostatus1.UseVisualStyleBackColor = true;
            // 
            // rdostatus2
            // 
            this.rdostatus2.AutoSize = true;
            this.rdostatus2.Location = new System.Drawing.Point(111, 76);
            this.rdostatus2.Name = "rdostatus2";
            this.rdostatus2.Size = new System.Drawing.Size(69, 17);
            this.rdostatus2.TabIndex = 10;
            this.rdostatus2.Text = "ไม่ใช้งาน";
            this.rdostatus2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.rdostatus2);
            this.groupBox2.Controls.Add(this.txtpartyID);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.rdostatus1);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "จัดการข้อมูลฝ่าย";
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
            this.labelX3.Text = "รหัสฝ่าย :";
            // 
            // txtpartyID
            // 
            // 
            // 
            // 
            this.txtpartyID.Border.Class = "TextBoxBorder";
            this.txtpartyID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpartyID.Enabled = false;
            this.txtpartyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpartyID.Location = new System.Drawing.Point(49, 19);
            this.txtpartyID.Name = "txtpartyID";
            this.txtpartyID.Size = new System.Drawing.Size(128, 22);
            this.txtpartyID.TabIndex = 0;
            // 
            // btncancel
            // 
            this.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncancel.Image = global::HRSystem.Properties.Resources.undo2;
            this.btncancel.Location = new System.Drawing.Point(336, 345);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 67);
            this.btncancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "ยกเลิก";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Image = global::HRSystem.Properties.Resources.notecheck32;
            this.btnsave.Location = new System.Drawing.Point(255, 345);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 67);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "บันทึก";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndelete.Image = global::HRSystem.Properties.Resources.linedpaperminus32;
            this.btndelete.Location = new System.Drawing.Point(174, 345);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 67);
            this.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "ลบ";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnedit.Image = global::HRSystem.Properties.Resources.linedpaperpencil32;
            this.btnedit.Location = new System.Drawing.Point(93, 345);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 67);
            this.btnedit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "แก้ไข";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnadd.Image = global::HRSystem.Properties.Resources.linedpaperplus32;
            this.btnadd.Location = new System.Drawing.Point(12, 345);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 67);
            this.btnadd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "เพิ่ม";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvParty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.DoubleBuffered = true;
            this.Name = "party";
            this.Text = "ข้อมูลฝ่าย";
            this.Load += new System.EventHandler(this.party_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX btndelete;
        private DevComponents.DotNetBar.ButtonX btnedit;
        private DevComponents.DotNetBar.ButtonX btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnsearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvParty;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        private System.Windows.Forms.RadioButton rdostatus1;
        private System.Windows.Forms.RadioButton rdostatus2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btncancel;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpartyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _partyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _statusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _status;
    }
}