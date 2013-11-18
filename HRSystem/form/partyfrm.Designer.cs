namespace HRSystem.form
{
    partial class partyfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this._status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._statusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._partyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvParty = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnsearch = new DevComponents.DotNetBar.ButtonX();
            this.txtsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // _status
            // 
            this._status.DataPropertyName = "status";
            this._status.HeaderText = "_status";
            this._status.Name = "_status";
            this._status.ReadOnly = true;
            this._status.Visible = false;
            // 
            // _statusName
            // 
            this._statusName.DataPropertyName = "statusName";
            this._statusName.HeaderText = "สถานะ";
            this._statusName.Name = "_statusName";
            this._statusName.ReadOnly = true;
            // 
            // _name
            // 
            this._name.DataPropertyName = "name";
            this._name.HeaderText = "ฝ่าย";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            // 
            // _partyID
            // 
            this._partyID.DataPropertyName = "partyID";
            this._partyID.HeaderText = "รหัสฝ่าย";
            this._partyID.Name = "_partyID";
            this._partyID.ReadOnly = true;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParty.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvParty.Location = new System.Drawing.Point(12, 74);
            this.dgvParty.Name = "dgvParty";
            this.dgvParty.ReadOnly = true;
            this.dgvParty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParty.Size = new System.Drawing.Size(412, 150);
            this.dgvParty.TabIndex = 18;
            this.dgvParty.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParty_CellMouseDoubleClick);
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
            this.groupBox1.Size = new System.Drawing.Size(412, 49);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // partyfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 235);
            this.Controls.Add(this.dgvParty);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "partyfrm";
            this.Text = "ค้นหาฝ่าย";
            this.Load += new System.EventHandler(this.partyfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _status;
        private System.Windows.Forms.DataGridViewTextBoxColumn _statusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _partyID;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvParty;
        private DevComponents.DotNetBar.ButtonX btnsearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}