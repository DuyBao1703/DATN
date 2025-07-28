namespace GUI_DATN
{
    partial class FrmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXoaKhachHang = new Guna.UI.WinForms.GunaButton();
            this.btnSuaKhachHang = new Guna.UI.WinForms.GunaButton();
            this.btnThemKhachHang = new Guna.UI.WinForms.GunaButton();
            this.btnHienThiKhachHang = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1185, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng ";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(812, 104);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(260, 33);
            this.cbGioiTinh.TabIndex = 14;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(812, 41);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(260, 30);
            this.txtCCCD.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(707, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(707, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "CCND";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(242, 181);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(299, 30);
            this.txtSoDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(242, 235);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(299, 30);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(242, 112);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(299, 30);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(242, 46);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(299, 30);
            this.txtMaKH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(41, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(41, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1187, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeight = 25;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(4, 28);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1179, 291);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvKhachHang.ThemeStyle.ReadOnly = false;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangXe_CellClick);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.AnimationHoverSpeed = 0.07F;
            this.btnXoaKhachHang.AnimationSpeed = 0.03F;
            this.btnXoaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaKhachHang.BaseColor = System.Drawing.Color.DarkGray;
            this.btnXoaKhachHang.BorderColor = System.Drawing.Color.Black;
            this.btnXoaKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhachHang.ForeColor = System.Drawing.Color.Red;
//            this.btnXoaKhachHang.Image = global::GUI_DATN.Properties.Resources._3669361_delete_ic_icon;
            this.btnXoaKhachHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaKhachHang.Location = new System.Drawing.Point(597, 397);
            this.btnXoaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnXoaKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaKhachHang.OnHoverImage = null;
            this.btnXoaKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaKhachHang.Radius = 2;
            this.btnXoaKhachHang.Size = new System.Drawing.Size(146, 52);
            this.btnXoaKhachHang.TabIndex = 26;
            this.btnXoaKhachHang.Text = "Xóa";
            this.btnXoaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.AnimationHoverSpeed = 0.07F;
            this.btnSuaKhachHang.AnimationSpeed = 0.03F;
            this.btnSuaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaKhachHang.BaseColor = System.Drawing.Color.DarkGray;
            this.btnSuaKhachHang.BorderColor = System.Drawing.Color.Black;
            this.btnSuaKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhachHang.ForeColor = System.Drawing.Color.Yellow;
//            this.btnSuaKhachHang.Image = global::GUI_DATN.Properties.Resources._5402373_write_modify_tool_edit_pen_icon;
            this.btnSuaKhachHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaKhachHang.Location = new System.Drawing.Point(411, 397);
            this.btnSuaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnSuaKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaKhachHang.OnHoverImage = null;
            this.btnSuaKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaKhachHang.Radius = 2;
            this.btnSuaKhachHang.Size = new System.Drawing.Size(148, 52);
            this.btnSuaKhachHang.TabIndex = 25;
            this.btnSuaKhachHang.Text = "Sửa";
            this.btnSuaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnSuaKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.AnimationHoverSpeed = 0.07F;
            this.btnThemKhachHang.AnimationSpeed = 0.03F;
            this.btnThemKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnThemKhachHang.BaseColor = System.Drawing.Color.DarkGray;
            this.btnThemKhachHang.BorderColor = System.Drawing.Color.Black;
            this.btnThemKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.ForeColor = System.Drawing.Color.Lime;
//            this.btnThemKhachHang.Image = global::GUI_DATN.Properties.Resources._106230_add_icon;
            this.btnThemKhachHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemKhachHang.Location = new System.Drawing.Point(237, 397);
            this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnThemKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemKhachHang.OnHoverImage = null;
            this.btnThemKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemKhachHang.Radius = 2;
            this.btnThemKhachHang.Size = new System.Drawing.Size(148, 52);
            this.btnThemKhachHang.TabIndex = 24;
            this.btnThemKhachHang.Text = "Thêm";
            this.btnThemKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // btnHienThiKhachHang
            // 
            this.btnHienThiKhachHang.AnimationHoverSpeed = 0.07F;
            this.btnHienThiKhachHang.AnimationSpeed = 0.03F;
            this.btnHienThiKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnHienThiKhachHang.BaseColor = System.Drawing.Color.DarkGray;
            this.btnHienThiKhachHang.BorderColor = System.Drawing.Color.Black;
            this.btnHienThiKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHienThiKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnHienThiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiKhachHang.ForeColor = System.Drawing.Color.Cyan;
//            this.btnHienThiKhachHang.Image = global::GUI_DATN.Properties.Resources._211882_refresh_icon;
            this.btnHienThiKhachHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHienThiKhachHang.Location = new System.Drawing.Point(768, 397);
            this.btnHienThiKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThiKhachHang.Name = "btnHienThiKhachHang";
            this.btnHienThiKhachHang.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHienThiKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHienThiKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHienThiKhachHang.OnHoverImage = null;
            this.btnHienThiKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnHienThiKhachHang.Radius = 2;
            this.btnHienThiKhachHang.Size = new System.Drawing.Size(146, 52);
            this.btnHienThiKhachHang.TabIndex = 29;
            this.btnHienThiKhachHang.Text = "Hiển Thị";
            this.btnHienThiKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHienThiKhachHang.Click += new System.EventHandler(this.btnHienThiKhachHang_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 817);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaKhachHang);
            this.Controls.Add(this.btnSuaKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemKhachHang);
            this.Controls.Add(this.btnHienThiKhachHang);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvKhachHang;
        private Guna.UI.WinForms.GunaButton btnXoaKhachHang;
        private Guna.UI.WinForms.GunaButton btnSuaKhachHang;
        private Guna.UI.WinForms.GunaButton btnThemKhachHang;
        private Guna.UI.WinForms.GunaButton btnHienThiKhachHang;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}