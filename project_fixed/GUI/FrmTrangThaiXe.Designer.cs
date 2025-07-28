namespace GUI_DATN
{
    partial class FrmTrangThaiXe
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenTrangThai = new System.Windows.Forms.TextBox();
            this.txtMaTrangThai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTrangThaiXe = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXoaTrangThai = new Guna.UI.WinForms.GunaButton();
            this.btnSuaTrangThai = new Guna.UI.WinForms.GunaButton();
            this.btnThemTrangThai = new Guna.UI.WinForms.GunaButton();
            this.btnHienThiTrangThai = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThaiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtTenTrangThai);
            this.groupBox1.Controls.Add(this.txtMaTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1062, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trạng thái xe ";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(777, 55);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(198, 30);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtTenTrangThai
            // 
            this.txtTenTrangThai.Location = new System.Drawing.Point(242, 112);
            this.txtTenTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTrangThai.Name = "txtTenTrangThai";
            this.txtTenTrangThai.Size = new System.Drawing.Size(198, 30);
            this.txtTenTrangThai.TabIndex = 2;
            // 
            // txtMaTrangThai
            // 
            this.txtMaTrangThai.Location = new System.Drawing.Point(242, 46);
            this.txtMaTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaTrangThai.Name = "txtMaTrangThai";
            this.txtMaTrangThai.Size = new System.Drawing.Size(198, 30);
            this.txtMaTrangThai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(581, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(46, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên trạng thái xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trạng thái xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTrangThaiXe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 421);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1064, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách trạng thái xe";
            // 
            // dgvTrangThaiXe
            // 
            this.dgvTrangThaiXe.AllowUserToAddRows = false;
            this.dgvTrangThaiXe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvTrangThaiXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrangThaiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrangThaiXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrangThaiXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrangThaiXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrangThaiXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTrangThaiXe.ColumnHeadersHeight = 25;
            this.dgvTrangThaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrangThaiXe.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTrangThaiXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrangThaiXe.EnableHeadersVisualStyles = false;
            this.dgvTrangThaiXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvTrangThaiXe.Location = new System.Drawing.Point(4, 28);
            this.dgvTrangThaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTrangThaiXe.Name = "dgvTrangThaiXe";
            this.dgvTrangThaiXe.RowHeadersVisible = false;
            this.dgvTrangThaiXe.RowHeadersWidth = 62;
            this.dgvTrangThaiXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrangThaiXe.Size = new System.Drawing.Size(1056, 232);
            this.dgvTrangThaiXe.TabIndex = 0;
            this.dgvTrangThaiXe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dgvTrangThaiXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvTrangThaiXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTrangThaiXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTrangThaiXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTrangThaiXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTrangThaiXe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrangThaiXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvTrangThaiXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvTrangThaiXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvTrangThaiXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTrangThaiXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTrangThaiXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTrangThaiXe.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvTrangThaiXe.ThemeStyle.ReadOnly = false;
            this.dgvTrangThaiXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvTrangThaiXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTrangThaiXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTrangThaiXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTrangThaiXe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTrangThaiXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvTrangThaiXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTrangThaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangXe_CellClick);
            // 
            // btnXoaTrangThai
            // 
            this.btnXoaTrangThai.AnimationHoverSpeed = 0.07F;
            this.btnXoaTrangThai.AnimationSpeed = 0.03F;
            this.btnXoaTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaTrangThai.BaseColor = System.Drawing.Color.DarkGray;
            this.btnXoaTrangThai.BorderColor = System.Drawing.Color.Black;
            this.btnXoaTrangThai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTrangThai.ForeColor = System.Drawing.Color.Red;
//            this.btnXoaTrangThai.Image = global::GUI_DATN.Properties.Resources._3669361_delete_ic_icon;
            this.btnXoaTrangThai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaTrangThai.Location = new System.Drawing.Point(515, 297);
            this.btnXoaTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaTrangThai.Name = "btnXoaTrangThai";
            this.btnXoaTrangThai.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnXoaTrangThai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaTrangThai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaTrangThai.OnHoverImage = null;
            this.btnXoaTrangThai.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaTrangThai.Radius = 2;
            this.btnXoaTrangThai.Size = new System.Drawing.Size(146, 52);
            this.btnXoaTrangThai.TabIndex = 26;
            this.btnXoaTrangThai.Text = "Xóa";
            this.btnXoaTrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaTrangThai.Click += new System.EventHandler(this.btnXoaTrangThai_Click);
            // 
            // btnSuaTrangThai
            // 
            this.btnSuaTrangThai.AnimationHoverSpeed = 0.07F;
            this.btnSuaTrangThai.AnimationSpeed = 0.03F;
            this.btnSuaTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaTrangThai.BaseColor = System.Drawing.Color.DarkGray;
            this.btnSuaTrangThai.BorderColor = System.Drawing.Color.Black;
            this.btnSuaTrangThai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTrangThai.ForeColor = System.Drawing.Color.Yellow;
//            this.btnSuaTrangThai.Image = global::GUI_DATN.Properties.Resources._5402373_write_modify_tool_edit_pen_icon;
            this.btnSuaTrangThai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaTrangThai.Location = new System.Drawing.Point(329, 297);
            this.btnSuaTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaTrangThai.Name = "btnSuaTrangThai";
            this.btnSuaTrangThai.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnSuaTrangThai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaTrangThai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaTrangThai.OnHoverImage = null;
            this.btnSuaTrangThai.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaTrangThai.Radius = 2;
            this.btnSuaTrangThai.Size = new System.Drawing.Size(148, 52);
            this.btnSuaTrangThai.TabIndex = 25;
            this.btnSuaTrangThai.Text = "Sửa";
            this.btnSuaTrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuaTrangThai.Click += new System.EventHandler(this.btnSuaTrangThai_Click);
            // 
            // btnThemTrangThai
            // 
            this.btnThemTrangThai.AnimationHoverSpeed = 0.07F;
            this.btnThemTrangThai.AnimationSpeed = 0.03F;
            this.btnThemTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.btnThemTrangThai.BaseColor = System.Drawing.Color.DarkGray;
            this.btnThemTrangThai.BorderColor = System.Drawing.Color.Black;
            this.btnThemTrangThai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTrangThai.ForeColor = System.Drawing.Color.Lime;
//            this.btnThemTrangThai.Image = global::GUI_DATN.Properties.Resources._106230_add_icon;
            this.btnThemTrangThai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemTrangThai.Location = new System.Drawing.Point(155, 297);
            this.btnThemTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemTrangThai.Name = "btnThemTrangThai";
            this.btnThemTrangThai.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnThemTrangThai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemTrangThai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemTrangThai.OnHoverImage = null;
            this.btnThemTrangThai.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemTrangThai.Radius = 2;
            this.btnThemTrangThai.Size = new System.Drawing.Size(148, 52);
            this.btnThemTrangThai.TabIndex = 24;
            this.btnThemTrangThai.Text = "Thêm";
            this.btnThemTrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemTrangThai.Click += new System.EventHandler(this.btnThemTrangThai_Click);
            // 
            // btnHienThiTrangThai
            // 
            this.btnHienThiTrangThai.AnimationHoverSpeed = 0.07F;
            this.btnHienThiTrangThai.AnimationSpeed = 0.03F;
            this.btnHienThiTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.btnHienThiTrangThai.BaseColor = System.Drawing.Color.DarkGray;
            this.btnHienThiTrangThai.BorderColor = System.Drawing.Color.Black;
            this.btnHienThiTrangThai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHienThiTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.btnHienThiTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTrangThai.ForeColor = System.Drawing.Color.Cyan;
//            this.btnHienThiTrangThai.Image = global::GUI_DATN.Properties.Resources._211882_refresh_icon;
            this.btnHienThiTrangThai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHienThiTrangThai.Location = new System.Drawing.Point(686, 297);
            this.btnHienThiTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThiTrangThai.Name = "btnHienThiTrangThai";
            this.btnHienThiTrangThai.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHienThiTrangThai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHienThiTrangThai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHienThiTrangThai.OnHoverImage = null;
            this.btnHienThiTrangThai.OnPressedColor = System.Drawing.Color.Black;
            this.btnHienThiTrangThai.Radius = 2;
            this.btnHienThiTrangThai.Size = new System.Drawing.Size(146, 52);
            this.btnHienThiTrangThai.TabIndex = 29;
            this.btnHienThiTrangThai.Text = "Hiển Thị";
            this.btnHienThiTrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHienThiTrangThai.Click += new System.EventHandler(this.btnHienThiTrangThai_Click);
            // 
            // FrmTrangThaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaTrangThai);
            this.Controls.Add(this.btnSuaTrangThai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemTrangThai);
            this.Controls.Add(this.btnHienThiTrangThai);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTrangThaiXe";
            this.Text = "FrmTrangThaiXe";
            this.Load += new System.EventHandler(this.FrmTrangThaiXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThaiXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenTrangThai;
        private System.Windows.Forms.TextBox txtMaTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvTrangThaiXe;
        private Guna.UI.WinForms.GunaButton btnXoaTrangThai;
        private Guna.UI.WinForms.GunaButton btnSuaTrangThai;
        private Guna.UI.WinForms.GunaButton btnThemTrangThai;
        private Guna.UI.WinForms.GunaButton btnHienThiTrangThai;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}