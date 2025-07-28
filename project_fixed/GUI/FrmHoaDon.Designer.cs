namespace GUI_DATN
{
    partial class FrmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXoaNhanVien = new Guna.UI.WinForms.GunaButton();
            this.btnSuaNhanVien = new Guna.UI.WinForms.GunaButton();
            this.btnThemNhanVien = new Guna.UI.WinForms.GunaButton();
            this.btnHienThiNhanVien = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayTao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.cbMaKH);
            this.groupBox1.Controls.Add(this.cbMaNV);
            this.groupBox1.Controls.Add(this.txtMaHD);
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
            this.groupBox1.Size = new System.Drawing.Size(1340, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn ";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(734, 112);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(242, 30);
            this.dtpNgayTao.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(607, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày tạo";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(734, 49);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(242, 30);
            this.dtpNgayBan.TabIndex = 7;
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(232, 170);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(277, 33);
            this.cbMaKH.TabIndex = 6;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(232, 109);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(277, 33);
            this.cbMaNV.TabIndex = 5;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(232, 51);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(277, 30);
            this.txtMaHD.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(607, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(45, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(45, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 421);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1346, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDon.ColumnHeadersHeight = 25;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(4, 28);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1338, 232);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangXe_CellClick);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.AnimationHoverSpeed = 0.07F;
            this.btnXoaNhanVien.AnimationSpeed = 0.03F;
            this.btnXoaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaNhanVien.BaseColor = System.Drawing.Color.DarkGray;
            this.btnXoaNhanVien.BorderColor = System.Drawing.Color.Black;
            this.btnXoaNhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanVien.ForeColor = System.Drawing.Color.Red;
//            this.btnXoaNhanVien.Image = global::GUI_DATN.Properties.Resources._3669361_delete_ic_icon;
            this.btnXoaNhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaNhanVien.Location = new System.Drawing.Point(514, 328);
            this.btnXoaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnXoaNhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaNhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaNhanVien.OnHoverImage = null;
            this.btnXoaNhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaNhanVien.Radius = 2;
            this.btnXoaNhanVien.Size = new System.Drawing.Size(146, 52);
            this.btnXoaNhanVien.TabIndex = 26;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.AnimationHoverSpeed = 0.07F;
            this.btnSuaNhanVien.AnimationSpeed = 0.03F;
            this.btnSuaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaNhanVien.BaseColor = System.Drawing.Color.DarkGray;
            this.btnSuaNhanVien.BorderColor = System.Drawing.Color.Black;
            this.btnSuaNhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhanVien.ForeColor = System.Drawing.Color.Yellow;
//            this.btnSuaNhanVien.Image = global::GUI_DATN.Properties.Resources._5402373_write_modify_tool_edit_pen_icon;
            this.btnSuaNhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaNhanVien.Location = new System.Drawing.Point(328, 328);
            this.btnSuaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnSuaNhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaNhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaNhanVien.OnHoverImage = null;
            this.btnSuaNhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaNhanVien.Radius = 2;
            this.btnSuaNhanVien.Size = new System.Drawing.Size(148, 52);
            this.btnSuaNhanVien.TabIndex = 25;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.AnimationHoverSpeed = 0.07F;
            this.btnThemNhanVien.AnimationSpeed = 0.03F;
            this.btnThemNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhanVien.BaseColor = System.Drawing.Color.DarkGray;
            this.btnThemNhanVien.BorderColor = System.Drawing.Color.Black;
            this.btnThemNhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.Lime;
//            this.btnThemNhanVien.Image = global::GUI_DATN.Properties.Resources._106230_add_icon;
            this.btnThemNhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemNhanVien.Location = new System.Drawing.Point(154, 328);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnThemNhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemNhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.OnHoverImage = null;
            this.btnThemNhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemNhanVien.Radius = 2;
            this.btnThemNhanVien.Size = new System.Drawing.Size(148, 52);
            this.btnThemNhanVien.TabIndex = 24;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // btnHienThiNhanVien
            // 
            this.btnHienThiNhanVien.AnimationHoverSpeed = 0.07F;
            this.btnHienThiNhanVien.AnimationSpeed = 0.03F;
            this.btnHienThiNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnHienThiNhanVien.BaseColor = System.Drawing.Color.DarkGray;
            this.btnHienThiNhanVien.BorderColor = System.Drawing.Color.Black;
            this.btnHienThiNhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHienThiNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btnHienThiNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiNhanVien.ForeColor = System.Drawing.Color.Cyan;
//            this.btnHienThiNhanVien.Image = global::GUI_DATN.Properties.Resources._211882_refresh_icon;
            this.btnHienThiNhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHienThiNhanVien.Location = new System.Drawing.Point(685, 328);
            this.btnHienThiNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThiNhanVien.Name = "btnHienThiNhanVien";
            this.btnHienThiNhanVien.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHienThiNhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHienThiNhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHienThiNhanVien.OnHoverImage = null;
            this.btnHienThiNhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btnHienThiNhanVien.Radius = 2;
            this.btnHienThiNhanVien.Size = new System.Drawing.Size(146, 52);
            this.btnHienThiNhanVien.TabIndex = 29;
            this.btnHienThiNhanVien.Text = "Hiển Thị";
            this.btnHienThiNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHienThiNhanVien.Click += new System.EventHandler(this.btnHienThiNhanVien_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.DarkGray;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Lime;
//            this.gunaButton1.Image = global::GUI_DATN.Properties.Resources._106230_add_icon;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(868, 328);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 2;
            this.gunaButton1.Size = new System.Drawing.Size(222, 52);
            this.gunaButton1.TabIndex = 30;
            this.gunaButton1.Text = "Chi tiết hóa đơn";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 705);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.btnHienThiNhanVien);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvHoaDon;
        private Guna.UI.WinForms.GunaButton btnXoaNhanVien;
        private Guna.UI.WinForms.GunaButton btnSuaNhanVien;
        private Guna.UI.WinForms.GunaButton btnThemNhanVien;
        private Guna.UI.WinForms.GunaButton btnHienThiNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}