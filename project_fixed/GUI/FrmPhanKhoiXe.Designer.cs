namespace GUI_DATN
{
    partial class FrmPhanKhoiXe
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
            this.txtDungTich = new System.Windows.Forms.TextBox();
            this.txtMaPhanKhoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhanKhoiXe = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXoaPhanKhoi = new Guna.UI.WinForms.GunaButton();
            this.btnSuaPhanKhoi = new Guna.UI.WinForms.GunaButton();
            this.btnThemPhanKhoi = new Guna.UI.WinForms.GunaButton();
            this.btnHienThiPhanKhoi = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanKhoiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.txtDungTich);
            this.groupBox1.Controls.Add(this.txtMaPhanKhoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1237, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phân khối xe ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(783, 62);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(270, 30);
            this.txtMoTa.TabIndex = 9;
            // 
            // txtDungTich
            // 
            this.txtDungTich.Location = new System.Drawing.Point(374, 128);
            this.txtDungTich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDungTich.Name = "txtDungTich";
            this.txtDungTich.Size = new System.Drawing.Size(198, 30);
            this.txtDungTich.TabIndex = 2;
            // 
            // txtMaPhanKhoi
            // 
            this.txtMaPhanKhoi.Location = new System.Drawing.Point(374, 62);
            this.txtMaPhanKhoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPhanKhoi.Name = "txtMaPhanKhoi";
            this.txtMaPhanKhoi.Size = new System.Drawing.Size(198, 30);
            this.txtMaPhanKhoi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(688, 65);
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
            this.label2.Location = new System.Drawing.Point(180, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dung tích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(178, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phân khối xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhanKhoiXe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 421);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1248, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phân khối xe";
            // 
            // dgvPhanKhoiXe
            // 
            this.dgvPhanKhoiXe.AllowUserToAddRows = false;
            this.dgvPhanKhoiXe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvPhanKhoiXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhanKhoiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanKhoiXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhanKhoiXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhanKhoiXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanKhoiXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhanKhoiXe.ColumnHeadersHeight = 25;
            this.dgvPhanKhoiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanKhoiXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhanKhoiXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanKhoiXe.EnableHeadersVisualStyles = false;
            this.dgvPhanKhoiXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvPhanKhoiXe.Location = new System.Drawing.Point(4, 28);
            this.dgvPhanKhoiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPhanKhoiXe.Name = "dgvPhanKhoiXe";
            this.dgvPhanKhoiXe.RowHeadersVisible = false;
            this.dgvPhanKhoiXe.RowHeadersWidth = 62;
            this.dgvPhanKhoiXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanKhoiXe.Size = new System.Drawing.Size(1240, 232);
            this.dgvPhanKhoiXe.TabIndex = 0;
            this.dgvPhanKhoiXe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dgvPhanKhoiXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvPhanKhoiXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhanKhoiXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhanKhoiXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhanKhoiXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhanKhoiXe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanKhoiXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvPhanKhoiXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvPhanKhoiXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvPhanKhoiXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanKhoiXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhanKhoiXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhanKhoiXe.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvPhanKhoiXe.ThemeStyle.ReadOnly = false;
            this.dgvPhanKhoiXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvPhanKhoiXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhanKhoiXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanKhoiXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPhanKhoiXe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPhanKhoiXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvPhanKhoiXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPhanKhoiXe.CellBorderStyleChanged += new System.EventHandler(this.dgvPhanKhoiXe_CellBorderStyleChanged);
            this.dgvPhanKhoiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangXe_CellClick);
            // 
            // btnXoaPhanKhoi
            // 
            this.btnXoaPhanKhoi.AnimationHoverSpeed = 0.07F;
            this.btnXoaPhanKhoi.AnimationSpeed = 0.03F;
            this.btnXoaPhanKhoi.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaPhanKhoi.BaseColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhanKhoi.BorderColor = System.Drawing.Color.Black;
            this.btnXoaPhanKhoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaPhanKhoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaPhanKhoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanKhoi.ForeColor = System.Drawing.Color.Red;
//            this.btnXoaPhanKhoi.Image = global::GUI_DATN.Properties.Resources._3669361_delete_ic_icon;
            this.btnXoaPhanKhoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaPhanKhoi.Location = new System.Drawing.Point(630, 297);
            this.btnXoaPhanKhoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaPhanKhoi.Name = "btnXoaPhanKhoi";
            this.btnXoaPhanKhoi.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnXoaPhanKhoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaPhanKhoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaPhanKhoi.OnHoverImage = null;
            this.btnXoaPhanKhoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaPhanKhoi.Radius = 2;
            this.btnXoaPhanKhoi.Size = new System.Drawing.Size(146, 52);
            this.btnXoaPhanKhoi.TabIndex = 26;
            this.btnXoaPhanKhoi.Text = "Xóa";
            this.btnXoaPhanKhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaPhanKhoi.Click += new System.EventHandler(this.btnXoaPhanKhoi_Click);
            // 
            // btnSuaPhanKhoi
            // 
            this.btnSuaPhanKhoi.AnimationHoverSpeed = 0.07F;
            this.btnSuaPhanKhoi.AnimationSpeed = 0.03F;
            this.btnSuaPhanKhoi.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaPhanKhoi.BaseColor = System.Drawing.Color.DarkGray;
            this.btnSuaPhanKhoi.BorderColor = System.Drawing.Color.Black;
            this.btnSuaPhanKhoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaPhanKhoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaPhanKhoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhanKhoi.ForeColor = System.Drawing.Color.Yellow;
//            this.btnSuaPhanKhoi.Image = global::GUI_DATN.Properties.Resources._5402373_write_modify_tool_edit_pen_icon;
            this.btnSuaPhanKhoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaPhanKhoi.Location = new System.Drawing.Point(444, 297);
            this.btnSuaPhanKhoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaPhanKhoi.Name = "btnSuaPhanKhoi";
            this.btnSuaPhanKhoi.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnSuaPhanKhoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaPhanKhoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaPhanKhoi.OnHoverImage = null;
            this.btnSuaPhanKhoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaPhanKhoi.Radius = 2;
            this.btnSuaPhanKhoi.Size = new System.Drawing.Size(148, 52);
            this.btnSuaPhanKhoi.TabIndex = 25;
            this.btnSuaPhanKhoi.Text = "Sửa";
            this.btnSuaPhanKhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuaPhanKhoi.Click += new System.EventHandler(this.btnSuaPhanKhoi_Click);
            // 
            // btnThemPhanKhoi
            // 
            this.btnThemPhanKhoi.AnimationHoverSpeed = 0.07F;
            this.btnThemPhanKhoi.AnimationSpeed = 0.03F;
            this.btnThemPhanKhoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemPhanKhoi.BaseColor = System.Drawing.Color.DarkGray;
            this.btnThemPhanKhoi.BorderColor = System.Drawing.Color.Black;
            this.btnThemPhanKhoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemPhanKhoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemPhanKhoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhanKhoi.ForeColor = System.Drawing.Color.Lime;
//            this.btnThemPhanKhoi.Image = global::GUI_DATN.Properties.Resources._106230_add_icon;
            this.btnThemPhanKhoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemPhanKhoi.Location = new System.Drawing.Point(270, 297);
            this.btnThemPhanKhoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemPhanKhoi.Name = "btnThemPhanKhoi";
            this.btnThemPhanKhoi.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnThemPhanKhoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemPhanKhoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemPhanKhoi.OnHoverImage = null;
            this.btnThemPhanKhoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemPhanKhoi.Radius = 2;
            this.btnThemPhanKhoi.Size = new System.Drawing.Size(148, 52);
            this.btnThemPhanKhoi.TabIndex = 24;
            this.btnThemPhanKhoi.Text = "Thêm";
            this.btnThemPhanKhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemPhanKhoi.Click += new System.EventHandler(this.btnThemPhanKhoi_Click);
            // 
            // btnHienThiPhanKhoi
            // 
            this.btnHienThiPhanKhoi.AnimationHoverSpeed = 0.07F;
            this.btnHienThiPhanKhoi.AnimationSpeed = 0.03F;
            this.btnHienThiPhanKhoi.BackColor = System.Drawing.Color.Transparent;
            this.btnHienThiPhanKhoi.BaseColor = System.Drawing.Color.DarkGray;
            this.btnHienThiPhanKhoi.BorderColor = System.Drawing.Color.Black;
            this.btnHienThiPhanKhoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHienThiPhanKhoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnHienThiPhanKhoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiPhanKhoi.ForeColor = System.Drawing.Color.Cyan;
//            this.btnHienThiPhanKhoi.Image = global::GUI_DATN.Properties.Resources._211882_refresh_icon;
            this.btnHienThiPhanKhoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHienThiPhanKhoi.Location = new System.Drawing.Point(801, 297);
            this.btnHienThiPhanKhoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThiPhanKhoi.Name = "btnHienThiPhanKhoi";
            this.btnHienThiPhanKhoi.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHienThiPhanKhoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHienThiPhanKhoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHienThiPhanKhoi.OnHoverImage = null;
            this.btnHienThiPhanKhoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnHienThiPhanKhoi.Radius = 2;
            this.btnHienThiPhanKhoi.Size = new System.Drawing.Size(146, 52);
            this.btnHienThiPhanKhoi.TabIndex = 29;
            this.btnHienThiPhanKhoi.Text = "Hiển Thị";
            this.btnHienThiPhanKhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHienThiPhanKhoi.Click += new System.EventHandler(this.btnHienThiPhanKhoi_Click);
            // 
            // FrmPhanKhoiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaPhanKhoi);
            this.Controls.Add(this.btnSuaPhanKhoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemPhanKhoi);
            this.Controls.Add(this.btnHienThiPhanKhoi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPhanKhoiXe";
            this.Text = "FrmPhanKhoiXe";
            this.Load += new System.EventHandler(this.FrmPhanKhoiXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanKhoiXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDungTich;
        private System.Windows.Forms.TextBox txtMaPhanKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvPhanKhoiXe;
        private Guna.UI.WinForms.GunaButton btnXoaPhanKhoi;
        private Guna.UI.WinForms.GunaButton btnSuaPhanKhoi;
        private Guna.UI.WinForms.GunaButton btnThemPhanKhoi;
        private Guna.UI.WinForms.GunaButton btnHienThiPhanKhoi;
        private System.Windows.Forms.TextBox txtMoTa;
    }
}