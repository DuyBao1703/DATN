namespace GUI_DATN
{
    partial class FrmHangXe
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
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.txtNamThanhLap = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHangXe = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXoaNhanVien = new Guna.UI.WinForms.GunaButton();
            this.btnSuaNhanVien = new Guna.UI.WinForms.GunaButton();
            this.btnThemNhanVien = new Guna.UI.WinForms.GunaButton();
            this.btnHienThiNhanVien = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuocGia);
            this.groupBox1.Controls.Add(this.txtNamThanhLap);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtMaHang);
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
            this.groupBox1.Size = new System.Drawing.Size(1336, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hãng xe ";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(900, 50);
            this.txtQuocGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(198, 30);
            this.txtQuocGia.TabIndex = 9;
            // 
            // txtNamThanhLap
            // 
            this.txtNamThanhLap.Location = new System.Drawing.Point(900, 110);
            this.txtNamThanhLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamThanhLap.Name = "txtNamThanhLap";
            this.txtNamThanhLap.Size = new System.Drawing.Size(198, 30);
            this.txtNamThanhLap.TabIndex = 5;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(242, 112);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(198, 30);
            this.txtTenHang.TabIndex = 2;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(242, 46);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(198, 30);
            this.txtMaHang.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(704, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm thành lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(704, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quốc gia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(46, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hãng xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hãng xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHangXe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1348, 541);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hãng xe";
            // 
            // dgvHangXe
            // 
            this.dgvHangXe.AllowUserToAddRows = false;
            this.dgvHangXe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvHangXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHangXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangXe.ColumnHeadersHeight = 25;
            this.dgvHangXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangXe.EnableHeadersVisualStyles = false;
            this.dgvHangXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvHangXe.Location = new System.Drawing.Point(4, 28);
            this.dgvHangXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHangXe.Name = "dgvHangXe";
            this.dgvHangXe.RowHeadersVisible = false;
            this.dgvHangXe.RowHeadersWidth = 62;
            this.dgvHangXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangXe.Size = new System.Drawing.Size(1340, 508);
            this.dgvHangXe.TabIndex = 0;
            this.dgvHangXe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dgvHangXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvHangXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHangXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHangXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHangXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHangXe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvHangXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvHangXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvHangXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHangXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHangXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHangXe.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvHangXe.ThemeStyle.ReadOnly = false;
            this.dgvHangXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvHangXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHangXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHangXe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHangXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvHangXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHangXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangXe_CellClick);
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
            this.btnXoaNhanVien.Location = new System.Drawing.Point(543, 283);
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
            this.btnSuaNhanVien.Location = new System.Drawing.Point(357, 283);
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
            this.btnThemNhanVien.Location = new System.Drawing.Point(183, 283);
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
            this.btnHienThiNhanVien.Location = new System.Drawing.Point(714, 283);
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
            // FrmHangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 911);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.btnHienThiNhanVien);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHangXe";
            this.Text = "FrmHangXe";
            this.Load += new System.EventHandler(this.FrmHangXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNamThanhLap;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvHangXe;
        private Guna.UI.WinForms.GunaButton btnXoaNhanVien;
        private Guna.UI.WinForms.GunaButton btnSuaNhanVien;
        private Guna.UI.WinForms.GunaButton btnThemNhanVien;
        private Guna.UI.WinForms.GunaButton btnHienThiNhanVien;
        private System.Windows.Forms.TextBox txtQuocGia;
    }
}