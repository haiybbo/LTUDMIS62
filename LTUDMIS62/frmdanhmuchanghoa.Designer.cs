namespace LTUDMIS62
{
    partial class frmdanhmuchanghoa
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.manhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtManhom = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtDgVND = new System.Windows.Forms.TextBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.lblManhom = new System.Windows.Forms.Label();
            this.lblMahang = new System.Windows.Forms.Label();
            this.lblTenhang = new System.Windows.Forms.Label();
            this.lblDvt = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblNsx = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.comTentruong = new System.Windows.Forms.ComboBox();
            this.comGiatri = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lbltentruong = new System.Windows.Forms.Label();
            this.lblgiatri = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhom,
            this.MaHH,
            this.TenHH,
            this.Dvt,
            this.dgvnd,
            this.Sanxuat});
            this.grdData.Location = new System.Drawing.Point(23, 6);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 82;
            this.grdData.RowTemplate.Height = 33;
            this.grdData.Size = new System.Drawing.Size(1193, 758);
            this.grdData.TabIndex = 0;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // manhom
            // 
            this.manhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.manhom.DataPropertyName = "MaNhom";
            this.manhom.HeaderText = "Mã nhóm";
            this.manhom.MinimumWidth = 10;
            this.manhom.Name = "manhom";
            this.manhom.Width = 146;
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã hàng";
            this.MaHH.MinimumWidth = 10;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 200;
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng";
            this.TenHH.MinimumWidth = 10;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 200;
            // 
            // Dvt
            // 
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Đvt";
            this.Dvt.MinimumWidth = 10;
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 200;
            // 
            // dgvnd
            // 
            this.dgvnd.DataPropertyName = "Dgvnd";
            this.dgvnd.HeaderText = "Đơn giá";
            this.dgvnd.MinimumWidth = 10;
            this.dgvnd.Name = "dgvnd";
            this.dgvnd.Width = 200;
            // 
            // Sanxuat
            // 
            this.Sanxuat.DataPropertyName = "Sanxuat";
            this.Sanxuat.HeaderText = "Sản xuất";
            this.Sanxuat.MinimumWidth = 10;
            this.Sanxuat.Name = "Sanxuat";
            this.Sanxuat.Width = 200;
            // 
            // txtManhom
            // 
            this.txtManhom.Location = new System.Drawing.Point(1441, 269);
            this.txtManhom.Multiline = true;
            this.txtManhom.Name = "txtManhom";
            this.txtManhom.Size = new System.Drawing.Size(643, 53);
            this.txtManhom.TabIndex = 1;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(1441, 360);
            this.txtMaHH.Multiline = true;
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(643, 53);
            this.txtMaHH.TabIndex = 1;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(1441, 446);
            this.txtTenHH.Multiline = true;
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(643, 53);
            this.txtTenHH.TabIndex = 1;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(1441, 532);
            this.txtDVT.Multiline = true;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(643, 53);
            this.txtDVT.TabIndex = 1;
            // 
            // txtDgVND
            // 
            this.txtDgVND.Location = new System.Drawing.Point(1441, 621);
            this.txtDgVND.Multiline = true;
            this.txtDgVND.Name = "txtDgVND";
            this.txtDgVND.Size = new System.Drawing.Size(643, 53);
            this.txtDgVND.TabIndex = 1;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(1441, 706);
            this.txtNuocSX.Multiline = true;
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(643, 53);
            this.txtNuocSX.TabIndex = 1;
            // 
            // lblManhom
            // 
            this.lblManhom.AutoSize = true;
            this.lblManhom.Location = new System.Drawing.Point(1261, 297);
            this.lblManhom.Name = "lblManhom";
            this.lblManhom.Size = new System.Drawing.Size(101, 25);
            this.lblManhom.TabIndex = 2;
            this.lblManhom.Text = "Mã nhóm";
            // 
            // lblMahang
            // 
            this.lblMahang.AutoSize = true;
            this.lblMahang.Location = new System.Drawing.Point(1261, 388);
            this.lblMahang.Name = "lblMahang";
            this.lblMahang.Size = new System.Drawing.Size(96, 25);
            this.lblMahang.TabIndex = 2;
            this.lblMahang.Text = "Mã hàng";
            // 
            // lblTenhang
            // 
            this.lblTenhang.AutoSize = true;
            this.lblTenhang.Location = new System.Drawing.Point(1261, 474);
            this.lblTenhang.Name = "lblTenhang";
            this.lblTenhang.Size = new System.Drawing.Size(103, 25);
            this.lblTenhang.TabIndex = 2;
            this.lblTenhang.Text = "Tên hàng";
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Location = new System.Drawing.Point(1261, 560);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(114, 25);
            this.lblDvt.TabIndex = 2;
            this.lblDvt.Text = "Đơn vị tính";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(1261, 649);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(86, 25);
            this.lblDongia.TabIndex = 2;
            this.lblDongia.Text = "Đơn giá";
            // 
            // lblNsx
            // 
            this.lblNsx.AutoSize = true;
            this.lblNsx.Location = new System.Drawing.Point(1261, 734);
            this.lblNsx.Name = "lblNsx";
            this.lblNsx.Size = new System.Drawing.Size(150, 25);
            this.lblNsx.TabIndex = 2;
            this.lblNsx.Text = "Nước sản xuất";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(327, 783);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(95, 54);
            this.btnfirst.TabIndex = 3;
            this.btnfirst.Text = "Đầu";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(454, 783);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(101, 54);
            this.btnPrv.TabIndex = 3;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(587, 783);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(94, 54);
            this.btnnext.TabIndex = 3;
            this.btnnext.Text = "Sau";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(713, 783);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(103, 54);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = "Cuối";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // comTentruong
            // 
            this.comTentruong.FormattingEnabled = true;
            this.comTentruong.Items.AddRange(new object[] {
            "MaHH",
            "TenHH",
            "Manhom",
            "NuocSX"});
            this.comTentruong.Location = new System.Drawing.Point(1266, 138);
            this.comTentruong.Name = "comTentruong";
            this.comTentruong.Size = new System.Drawing.Size(286, 33);
            this.comTentruong.TabIndex = 4;
            this.comTentruong.SelectedIndexChanged += new System.EventHandler(this.comTentruong_SelectedIndexChanged);
            // 
            // comGiatri
            // 
            this.comGiatri.FormattingEnabled = true;
            this.comGiatri.Location = new System.Drawing.Point(1582, 138);
            this.comGiatri.Name = "comGiatri";
            this.comGiatri.Size = new System.Drawing.Size(502, 33);
            this.comGiatri.TabIndex = 4;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("#9Slide01 Tieu de ngan", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFilter.Location = new System.Drawing.Point(1259, 42);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(184, 41);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Lọc dữ liệu";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFilter.UseMnemonic = false;
            // 
            // lbltentruong
            // 
            this.lbltentruong.AutoSize = true;
            this.lbltentruong.Location = new System.Drawing.Point(1261, 101);
            this.lbltentruong.Name = "lbltentruong";
            this.lbltentruong.Size = new System.Drawing.Size(116, 25);
            this.lbltentruong.TabIndex = 2;
            this.lbltentruong.Text = "Tên trường";
            // 
            // lblgiatri
            // 
            this.lblgiatri.AutoSize = true;
            this.lblgiatri.Location = new System.Drawing.Point(1577, 101);
            this.lblgiatri.Name = "lblgiatri";
            this.lblgiatri.Size = new System.Drawing.Size(69, 25);
            this.lblgiatri.TabIndex = 2;
            this.lblgiatri.Text = "Giá trị";
            // 
            // btnFilter
            // 
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.Location = new System.Drawing.Point(1646, 189);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(180, 48);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Lọc dữ liệu";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClearFilter.Location = new System.Drawing.Point(1847, 189);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(237, 48);
            this.btnClearFilter.TabIndex = 6;
            this.btnClearFilter.Text = "Huỷ lọc dữ liệu";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1089, 876);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 54);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1291, 877);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 53);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1501, 877);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(176, 53);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1704, 876);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 54);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1908, 876);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(176, 54);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1360, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(848, 783);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 54);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmdanhmuchanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2144, 967);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.comGiatri);
            this.Controls.Add(this.comTentruong);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.lblNsx);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.lblDvt);
            this.Controls.Add(this.lblTenhang);
            this.Controls.Add(this.lblMahang);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblgiatri);
            this.Controls.Add(this.lbltentruong);
            this.Controls.Add(this.lblManhom);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtDgVND);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.txtManhom);
            this.Controls.Add(this.grdData);
            this.Name = "frmdanhmuchanghoa";
            this.Text = "frmdanhmuchanghoa";
            this.Load += new System.EventHandler(this.frmdanhmuchanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtManhom;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtDgVND;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.Label lblManhom;
        private System.Windows.Forms.Label lblMahang;
        private System.Windows.Forms.Label lblTenhang;
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblNsx;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.ComboBox comTentruong;
        private System.Windows.Forms.ComboBox comGiatri;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lbltentruong;
        private System.Windows.Forms.Label lblgiatri;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sanxuat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExit;
    }
}