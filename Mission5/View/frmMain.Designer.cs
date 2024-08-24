namespace Mission5
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblOverdueFee = new System.Windows.Forms.Label();
            this.lblDaysOfOverdue = new System.Windows.Forms.Label();
            this.lblNumOfOverdue = new System.Windows.Forms.Label();
            this.lblNumOfAvailable = new System.Windows.Forms.Label();
            this.lblNumOfCheckOut = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.lblMemberId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchBookCopy = new System.Windows.Forms.Button();
            this.txtBookCopyCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpMemberInfo.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblOverdueFee);
            this.grpMemberInfo.Controls.Add(this.lblDaysOfOverdue);
            this.grpMemberInfo.Controls.Add(this.lblNumOfOverdue);
            this.grpMemberInfo.Controls.Add(this.lblNumOfAvailable);
            this.grpMemberInfo.Controls.Add(this.lblNumOfCheckOut);
            this.grpMemberInfo.Controls.Add(this.label11);
            this.grpMemberInfo.Controls.Add(this.label10);
            this.grpMemberInfo.Controls.Add(this.label9);
            this.grpMemberInfo.Controls.Add(this.label8);
            this.grpMemberInfo.Controls.Add(this.label7);
            this.grpMemberInfo.Controls.Add(this.lblPhoneNo);
            this.grpMemberInfo.Controls.Add(this.lblMemberName);
            this.grpMemberInfo.Controls.Add(this.btnSearchMember);
            this.grpMemberInfo.Controls.Add(this.lblMemberId);
            this.grpMemberInfo.Controls.Add(this.label3);
            this.grpMemberInfo.Controls.Add(this.label2);
            this.grpMemberInfo.Controls.Add(this.label1);
            this.grpMemberInfo.Controls.Add(this.linkLabel1);
            this.grpMemberInfo.Location = new System.Drawing.Point(15, 17);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMemberInfo.Size = new System.Drawing.Size(285, 334);
            this.grpMemberInfo.TabIndex = 0;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Informasi anggota";
            // 
            // lblOverdueFee
            // 
            this.lblOverdueFee.BackColor = System.Drawing.SystemColors.Window;
            this.lblOverdueFee.Location = new System.Drawing.Point(122, 285);
            this.lblOverdueFee.Name = "lblOverdueFee";
            this.lblOverdueFee.Size = new System.Drawing.Size(142, 23);
            this.lblOverdueFee.TabIndex = 20;
            // 
            // lblDaysOfOverdue
            // 
            this.lblDaysOfOverdue.BackColor = System.Drawing.SystemColors.Window;
            this.lblDaysOfOverdue.Location = new System.Drawing.Point(122, 247);
            this.lblDaysOfOverdue.Name = "lblDaysOfOverdue";
            this.lblDaysOfOverdue.Size = new System.Drawing.Size(142, 23);
            this.lblDaysOfOverdue.TabIndex = 19;
            this.lblDaysOfOverdue.Click += new System.EventHandler(this.lblDaysOfOverdue_Click);
            // 
            // lblNumOfOverdue
            // 
            this.lblNumOfOverdue.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumOfOverdue.Location = new System.Drawing.Point(121, 206);
            this.lblNumOfOverdue.Name = "lblNumOfOverdue";
            this.lblNumOfOverdue.Size = new System.Drawing.Size(142, 23);
            this.lblNumOfOverdue.TabIndex = 18;
            this.lblNumOfOverdue.Click += new System.EventHandler(this.lblNumOfOverdue_Click);
            // 
            // lblNumOfAvailable
            // 
            this.lblNumOfAvailable.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumOfAvailable.Location = new System.Drawing.Point(122, 166);
            this.lblNumOfAvailable.Name = "lblNumOfAvailable";
            this.lblNumOfAvailable.Size = new System.Drawing.Size(142, 23);
            this.lblNumOfAvailable.TabIndex = 17;
            // 
            // lblNumOfCheckOut
            // 
            this.lblNumOfCheckOut.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumOfCheckOut.Location = new System.Drawing.Point(122, 135);
            this.lblNumOfCheckOut.Name = "lblNumOfCheckOut";
            this.lblNumOfCheckOut.Size = new System.Drawing.Size(142, 23);
            this.lblNumOfCheckOut.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(10, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 35);
            this.label11.TabIndex = 15;
            this.label11.Text = "Biaya Keterlambatan";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(9, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 35);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Hari Jatuh Tempo";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(9, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 33);
            this.label9.TabIndex = 13;
            this.label9.Text = "Jml Jatuh Tempo";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(9, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 35);
            this.label8.TabIndex = 12;
            this.label8.Text = "Jml yang bisa dipinjam";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(9, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jml Peminjaman";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.BackColor = System.Drawing.SystemColors.Window;
            this.lblPhoneNo.Location = new System.Drawing.Point(121, 93);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(142, 23);
            this.lblPhoneNo.TabIndex = 10;
            // 
            // lblMemberName
            // 
            this.lblMemberName.BackColor = System.Drawing.SystemColors.Window;
            this.lblMemberName.Location = new System.Drawing.Point(122, 58);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(142, 23);
            this.lblMemberName.TabIndex = 9;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(189, 22);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMember.TabIndex = 8;
            this.btnSearchMember.Text = "Cari";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // lblMemberId
            // 
            this.lblMemberId.Location = new System.Drawing.Point(121, 23);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(62, 22);
            this.lblMemberId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nomor HP";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Anggota";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(6, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "                                                 ";
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.lblPublisher);
            this.grpBookInfo.Controls.Add(this.lblTitle);
            this.grpBookInfo.Controls.Add(this.btnSearchBookCopy);
            this.grpBookInfo.Controls.Add(this.txtBookCopyCode);
            this.grpBookInfo.Controls.Add(this.label6);
            this.grpBookInfo.Controls.Add(this.label5);
            this.grpBookInfo.Controls.Add(this.label4);
            this.grpBookInfo.Location = new System.Drawing.Point(306, 17);
            this.grpBookInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBookInfo.Size = new System.Drawing.Size(344, 141);
            this.grpBookInfo.TabIndex = 17;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Informasi buku";
            // 
            // lblPublisher
            // 
            this.lblPublisher.BackColor = System.Drawing.SystemColors.Window;
            this.lblPublisher.Location = new System.Drawing.Point(149, 93);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(177, 23);
            this.lblPublisher.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(149, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 23);
            this.lblTitle.TabIndex = 11;
            // 
            // btnSearchBookCopy
            // 
            this.btnSearchBookCopy.Location = new System.Drawing.Point(251, 21);
            this.btnSearchBookCopy.Name = "btnSearchBookCopy";
            this.btnSearchBookCopy.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBookCopy.TabIndex = 15;
            this.btnSearchBookCopy.Text = "Cari";
            this.btnSearchBookCopy.UseVisualStyleBackColor = true;
            this.btnSearchBookCopy.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtBookCopyCode
            // 
            this.txtBookCopyCode.Location = new System.Drawing.Point(149, 22);
            this.txtBookCopyCode.Name = "txtBookCopyCode";
            this.txtBookCopyCode.Size = new System.Drawing.Size(96, 22);
            this.txtBookCopyCode.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Penerbit";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nama Buku";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "No. Registrasi Buku";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBookList.Location = new System.Drawing.Point(15, 359);
            this.dgvBookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBookList.MultiSelect = false;
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(703, 200);
            this.dgvBookList.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CheckOutId";
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "ID Peminjaman";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookCopyCode";
            this.Column2.FillWeight = 110F;
            this.Column2.HeaderText = "Nomor registrasi buku";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Title";
            this.Column3.HeaderText = "Nama buku";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CheckOutDate";
            dataGridViewCellStyle4.Format = "yyyy-MM-dd HH:mm";
            dataGridViewCellStyle4.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Tanggal peminjaman";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DueDate";
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Tanggal rencana pengembalian";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OverdueDays";
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "Tanggal jatuh tempo pengembalian";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "OverdueCharge";
            this.Column7.FillWeight = 65F;
            this.Column7.HeaderText = "Biaya keterlambatan";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 65;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(327, 204);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(151, 83);
            this.btnCheckOut.TabIndex = 19;
            this.btnCheckOut.Text = "Peminjaman";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(499, 204);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 83);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Pengembalian";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(320, 573);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 45);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Tutup";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 635);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.grpMemberInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peminjaman/pengembalian buku";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox lblMemberId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOverdueFee;
        private System.Windows.Forms.Label lblDaysOfOverdue;
        private System.Windows.Forms.Label lblNumOfOverdue;
        private System.Windows.Forms.Label lblNumOfAvailable;
        private System.Windows.Forms.Label lblNumOfCheckOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchBookCopy;
        private System.Windows.Forms.TextBox txtBookCopyCode;
    }
}