namespace GUI_DATN
{
    partial class FrmLoaiXeMay
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
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenLoaiXe = new System.Windows.Forms.TextBox();
            this.txtMaLoaiXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiXe = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXoaLoaiXe = new Guna.UI.WinForms.GunaButton();
            this.btnSuaLoaiXe = new Guna.UI.WinForms.GunaButton();
            this.btnThemLoaiXe = new Guna.UI.WinForms.GunaButton();
            this.btnHienThiLoaiXe = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.txtTenLoaiXe);
            this.groupBox1.Controls.Add(this.txtMaLoaiXe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1329, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại xe máy ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(751, 49);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(256, 30);
            this.txtMoTa.TabIndex = 9;
            // 
            // txtTenLoaiXe
            // 
            this.txtTenLoaiXe.Location = new System.Drawing.Point(311, 114);
            this.txtTenLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLoaiXe.Name = "txtTenLoaiXe";
            this.txtTenLoaiXe.Size = new System.Drawing.Size(247, 30);
            this.txtTenLoaiXe.TabIndex = 2;
            // 
            // txtMaLoaiXe
            // 
            this.txtMaLoaiXe.Location = new System.Drawing.Point(311, 48);
            this.txtMaLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.Size = new System.Drawing.Size(247, 30);
            this.txtMaLoaiXe.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(651, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(115, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại xe máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(115, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại xe máy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLoaiXe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 399);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1346, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại xe máy";
            // 
            // dgvLoaiXe
            // 
            this.dgvLoaiXe.AllowUserToAddRows = false;
            this.dgvLoaiXe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvLoaiXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiXe.ColumnHeadersHeight = 25;
            this.dgvLoaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiXe.EnableHeadersVisualStyles = false;
            this.dgvLoaiXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvLoaiXe.Location = new System.Drawing.Point(4, 28);
            this.dgvLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLoaiXe.Name = "dgvLoaiXe";
            this.dgvLoaiXe.RowHeadersVisible = false;
            this.dgvLoaiXe.RowHeadersWidth = 62;
            this.dgvLoaiXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiXe.Size = new System.Drawing.Size(1338, 310);
            this.dgvLoaiXe.TabIndex = 0;
            this.dgvLoaiXe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dgvLoaiXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvLoaiXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLoaiXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLoaiXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLoaiXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLoaiXe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvLoaiXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvLoaiXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvLoaiXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLoaiXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoaiXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoaiXe.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvLoaiXe.ThemeStyle.ReadOnly = false;
            this.dgvLoaiXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvLoaiXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLoaiXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLoaiXe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLoaiXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvLoaiXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLoaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangXe_CellClick);
            // 
            // btnXoaLoaiXe
            // 
            this.btnXoaLoaiXe.AnimationHoverSpeed = 0.07F;
            this.btnXoaLoaiXe.AnimationSpeed = 0.03F;
            this.btnXoaLoaiXe.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaLoaiXe.BaseColor = System.Drawing.Color.DarkGray;
            this.btnXoaLoaiXe.BorderColor = System.Drawing.Color.Black;
            this.btnXoaLoaiXe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaLoaiXe.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiXe.ForeColor = System.Drawing.Color.Red;
//            this.btnXoaLoaiXe.Image = global::GUI_DATN.Properties.Resources._3669361_delete_ic_icon;
            this.btnXoaLoaiXe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaLoaiXe.Location = new System.Drawing.Point(678, 297);
            this.btnXoaLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaLoaiXe.Name = "btnXoaLoaiXe";
            this.btnXoaLoaiXe.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnXoaLoaiXe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaLoaiXe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiXe.OnHoverImage = null;
            this.btnXoaLoaiXe.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaLoaiXe.Radius = 2;
            this.btnXoaLoaiXe.Size = new System.Drawing.Size(146, 52);
            this.btnXoaLoaiXe.TabIndex = 26;
            this.btnXoaLoaiXe.Text = "Xóa";
            this.btnXoaLoaiXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaLoaiXe.Click += new System.EventHandler(this.btnXoaLoaiXe_Click);
            // 
            // btnSuaLoaiXe
            // 
            this.btnSuaLoaiXe.AnimationHoverSpeed = 0.07F;
            this.btnSuaLoaiXe.AnimationSpeed = 0.03F;
            this.btnSuaLoaiXe.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLoaiXe.BaseColor = System.Drawing.Color.DarkGray;
            this.btnSuaLoaiXe.BorderColor = System.Drawing.Color.Black;
            this.btnSuaLoaiXe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaLoaiXe.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiXe.ForeColor = System.Drawing.Color.Yellow;
//            this.btnSuaLoaiXe.Image = global::GUI_DATN.Properties.Resources._5402373_write_modify_tool_edit_pen_icon;
            this.btnSuaLoaiXe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaLoaiXe.Location = new System.Drawing.Point(492, 297);
            this.btnSuaLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaLoaiXe.Name = "btnSuaLoaiXe";
            this.btnSuaLoaiXe.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnSuaLoaiXe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaLoaiXe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaLoaiXe.OnHoverImage = null;
            this.btnSuaLoaiXe.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaLoaiXe.Radius = 2;
            this.btnSuaLoaiXe.Size = new System.Drawing.Size(148, 52);
            this.btnSuaLoaiXe.TabIndex = 25;
            this.btnSuaLoaiXe.Text = "Sửa";
            this.btnSuaLoaiXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuaLoaiXe.Click += new System.EventHandler(this.btnSuaLoaiXe_Click);
            // 
            // btnThemLoaiXe
            // 
            this.btnThemLoaiXe.AnimationHoverSpeed = 0.07F;
            this.btnThemLoaiXe.AnimationSpeed = 0.03F;
            this.btnThemLoaiXe.BackColor = System.Drawing.Color.Transparent;
            this.btnThemLoaiXe.BaseColor = System.Drawing.Color.DarkGray;
            this.btnThemLoaiXe.BorderColor = System.Drawing.Color.Black;
            this.btnThemLoaiXe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemLoaiXe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiXe.ForeColor = System.Drawing.Color.Lime;
//            this.btnThemLoaiXe.Image = global::GUI_DATN.Properties.Resources._106230_add_icon;
            this.btnThemLoaiXe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemLoaiXe.Location = new System.Drawing.Point(318, 297);
            this.btnThemLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemLoaiXe.Name = "btnThemLoaiXe";
            this.btnThemLoaiXe.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnThemLoaiXe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemLoaiXe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemLoaiXe.OnHoverImage = null;
            this.btnThemLoaiXe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemLoaiXe.Radius = 2;
            this.btnThemLoaiXe.Size = new System.Drawing.Size(148, 52);
            this.btnThemLoaiXe.TabIndex = 24;
            this.btnThemLoaiXe.Text = "Thêm";
            this.btnThemLoaiXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemLoaiXe.Click += new System.EventHandler(this.btnThemLoaiXe_Click);
            // 
            // btnHienThiLoaiXe
            // 
            this.btnHienThiLoaiXe.AnimationHoverSpeed = 0.07F;
            this.btnHienThiLoaiXe.AnimationSpeed = 0.03F;
            this.btnHienThiLoaiXe.BackColor = System.Drawing.Color.Transparent;
            this.btnHienThiLoaiXe.BaseColor = System.Drawing.Color.DarkGray;
            this.btnHienThiLoaiXe.BorderColor = System.Drawing.Color.Black;
            this.btnHienThiLoaiXe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHienThiLoaiXe.FocusedColor = System.Drawing.Color.Empty;
            this.btnHienThiLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiLoaiXe.ForeColor = System.Drawing.Color.Cyan;
//            this.btnHienThiLoaiXe.Image = global::GUI_DATN.Properties.Resources._211882_refresh_icon;
            this.btnHienThiLoaiXe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHienThiLoaiXe.Location = new System.Drawing.Point(849, 297);
            this.btnHienThiLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThiLoaiXe.Name = "btnHienThiLoaiXe";
            this.btnHienThiLoaiXe.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHienThiLoaiXe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHienThiLoaiXe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHienThiLoaiXe.OnHoverImage = null;
            this.btnHienThiLoaiXe.OnPressedColor = System.Drawing.Color.Black;
            this.btnHienThiLoaiXe.Radius = 2;
            this.btnHienThiLoaiXe.Size = new System.Drawing.Size(146, 52);
            this.btnHienThiLoaiXe.TabIndex = 29;
            this.btnHienThiLoaiXe.Text = "Hiển Thị";
            this.btnHienThiLoaiXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHienThiLoaiXe.Click += new System.EventHandler(this.btnHienThiLoaiXe_Click);
            // 
            // FrmLoaiXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 750);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaLoaiXe);
            this.Controls.Add(this.btnSuaLoaiXe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemLoaiXe);
            this.Controls.Add(this.btnHienThiLoaiXe);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLoaiXeMay";
            this.Text = "FrmLoaiXeMay";
            this.Load += new System.EventHandler(this.FrmLoaiXeMay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenLoaiXe;
        private System.Windows.Forms.TextBox txtMaLoaiXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvLoaiXe;
        private Guna.UI.WinForms.GunaButton btnXoaLoaiXe;
        private Guna.UI.WinForms.GunaButton btnSuaLoaiXe;
        private Guna.UI.WinForms.GunaButton btnThemLoaiXe;
        private Guna.UI.WinForms.GunaButton btnHienThiLoaiXe;
        private System.Windows.Forms.TextBox txtMoTa;
    }
}