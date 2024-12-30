namespace QuanLySinhVien_Thi.GUI
{
	partial class FormSinhVien_QuanLy
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinhVien_QuanLy));
			toolStrip1 = new ToolStrip();
			btn_NapDanhSach = new ToolStripButton();
			btn_BoSung = new ToolStripButton();
			btn_Sua = new ToolStripButton();
			btn_Xoa = new ToolStripButton();
			btn_QuanLyNganhDaoTao = new ToolStripButton();
			grd_SinhVien = new DataGridView();
			bsSinhVien = new BindingSource(components);
			statusStrip1 = new StatusStrip();
			toolStrip2 = new ToolStrip();
			lblThongKe = new ToolStripLabel();
			colMaSinhVien = new DataGridViewTextBoxColumn();
			colHoTen = new DataGridViewTextBoxColumn();
			colGioiTinh = new DataGridViewCheckBoxColumn();
			colNgaySinh = new DataGridViewTextBoxColumn();
			colMaNganhDaoTao = new DataGridViewTextBoxColumn();
			colGhiChu = new DataGridViewTextBoxColumn();
			toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)grd_SinhVien).BeginInit();
			((System.ComponentModel.ISupportInitialize)bsSinhVien).BeginInit();
			toolStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(24, 24);
			toolStrip1.Items.AddRange(new ToolStripItem[] { btn_NapDanhSach, btn_BoSung, btn_Sua, btn_Xoa, btn_QuanLyNganhDaoTao });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1146, 34);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// btn_NapDanhSach
			// 
			btn_NapDanhSach.Image = (Image)resources.GetObject("btn_NapDanhSach.Image");
			btn_NapDanhSach.ImageTransparentColor = Color.Magenta;
			btn_NapDanhSach.Name = "btn_NapDanhSach";
			btn_NapDanhSach.Size = new Size(158, 29);
			btn_NapDanhSach.Text = "Nạp danh sách";
			btn_NapDanhSach.Click += btn_NapDanhSach_Click;
			// 
			// btn_BoSung
			// 
			btn_BoSung.Image = (Image)resources.GetObject("btn_BoSung.Image");
			btn_BoSung.ImageTransparentColor = Color.Magenta;
			btn_BoSung.Name = "btn_BoSung";
			btn_BoSung.Size = new Size(105, 29);
			btn_BoSung.Text = "Bổ sung";
			btn_BoSung.Click += btn_BoSung_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.Image = (Image)resources.GetObject("btn_Sua.Image");
			btn_Sua.ImageTransparentColor = Color.Magenta;
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(70, 29);
			btn_Sua.Text = "Sửa";
			btn_Sua.Click += btn_Sua_Click;
			// 
			// btn_Xoa
			// 
			btn_Xoa.Image = (Image)resources.GetObject("btn_Xoa.Image");
			btn_Xoa.ImageTransparentColor = Color.Magenta;
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(71, 29);
			btn_Xoa.Text = "Xóa";
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_QuanLyNganhDaoTao
			// 
			btn_QuanLyNganhDaoTao.Alignment = ToolStripItemAlignment.Right;
			btn_QuanLyNganhDaoTao.Image = (Image)resources.GetObject("btn_QuanLyNganhDaoTao.Image");
			btn_QuanLyNganhDaoTao.ImageAlign = ContentAlignment.MiddleRight;
			btn_QuanLyNganhDaoTao.ImageTransparentColor = Color.Magenta;
			btn_QuanLyNganhDaoTao.Name = "btn_QuanLyNganhDaoTao";
			btn_QuanLyNganhDaoTao.Size = new Size(223, 29);
			btn_QuanLyNganhDaoTao.Text = "Quản lý ngành đào tạo";
			btn_QuanLyNganhDaoTao.Click += btn_QuanLyNganhDaoTao_Click;
			// 
			// grd_SinhVien
			// 
			grd_SinhVien.AllowUserToAddRows = false;
			grd_SinhVien.AllowUserToDeleteRows = false;
			grd_SinhVien.AllowUserToResizeColumns = false;
			grd_SinhVien.AllowUserToResizeRows = false;
			grd_SinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grd_SinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSinhVien, colHoTen, colGioiTinh, colNgaySinh, colMaNganhDaoTao, colGhiChu });
			grd_SinhVien.Location = new Point(12, 50);
			grd_SinhVien.Name = "grd_SinhVien";
			grd_SinhVien.RowHeadersWidth = 62;
			grd_SinhVien.Size = new Size(1107, 322);
			grd_SinhVien.TabIndex = 1;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(24, 24);
			statusStrip1.Location = new Point(0, 462);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1146, 22);
			statusStrip1.TabIndex = 2;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStrip2
			// 
			toolStrip2.Dock = DockStyle.Bottom;
			toolStrip2.ImageScalingSize = new Size(24, 24);
			toolStrip2.Items.AddRange(new ToolStripItem[] { lblThongKe });
			toolStrip2.Location = new Point(0, 432);
			toolStrip2.Name = "toolStrip2";
			toolStrip2.Size = new Size(1146, 30);
			toolStrip2.TabIndex = 3;
			toolStrip2.Text = "toolStrip2";
			// 
			// lblThongKe
			// 
			lblThongKe.Name = "lblThongKe";
			lblThongKe.Size = new Size(179, 25);
			lblThongKe.Text = "toolStripStatusLabel1";
			// 
			// colMaSinhVien
			// 
			colMaSinhVien.DataPropertyName = "maSinhVien";
			colMaSinhVien.HeaderText = "Mã sinh viên";
			colMaSinhVien.MinimumWidth = 8;
			colMaSinhVien.Name = "colMaSinhVien";
			colMaSinhVien.Width = 150;
			// 
			// colHoTen
			// 
			colHoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colHoTen.DataPropertyName = "hoVaTen";
			colHoTen.HeaderText = "Họ và Tên";
			colHoTen.MinimumWidth = 8;
			colHoTen.Name = "colHoTen";
			// 
			// colGioiTinh
			// 
			colGioiTinh.DataPropertyName = "gioiTinh";
			colGioiTinh.HeaderText = "Giới tính";
			colGioiTinh.MinimumWidth = 8;
			colGioiTinh.Name = "colGioiTinh";
			colGioiTinh.Width = 150;
			// 
			// colNgaySinh
			// 
			colNgaySinh.DataPropertyName = "ngaySinh";
			colNgaySinh.HeaderText = "Ngày sinh";
			colNgaySinh.MinimumWidth = 8;
			colNgaySinh.Name = "colNgaySinh";
			colNgaySinh.Resizable = DataGridViewTriState.True;
			colNgaySinh.SortMode = DataGridViewColumnSortMode.NotSortable;
			colNgaySinh.Width = 120;
			// 
			// colMaNganhDaoTao
			// 
			colMaNganhDaoTao.DataPropertyName = "maNganhDaoTao";
			colMaNganhDaoTao.HeaderText = "Ngành đào tạo";
			colMaNganhDaoTao.MinimumWidth = 8;
			colMaNganhDaoTao.Name = "colMaNganhDaoTao";
			colMaNganhDaoTao.Resizable = DataGridViewTriState.True;
			colMaNganhDaoTao.SortMode = DataGridViewColumnSortMode.NotSortable;
			colMaNganhDaoTao.Width = 150;
			// 
			// colGhiChu
			// 
			colGhiChu.DataPropertyName = "ghiChu";
			colGhiChu.HeaderText = "Ghi Chú";
			colGhiChu.MinimumWidth = 8;
			colGhiChu.Name = "colGhiChu";
			colGhiChu.Resizable = DataGridViewTriState.True;
			colGhiChu.SortMode = DataGridViewColumnSortMode.NotSortable;
			colGhiChu.Width = 200;
			// 
			// FormSinhVien_QuanLy
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1146, 484);
			Controls.Add(toolStrip2);
			Controls.Add(statusStrip1);
			Controls.Add(grd_SinhVien);
			Controls.Add(toolStrip1);
			Name = "FormSinhVien_QuanLy";
			Text = "FormSinhVien_QuanLy";
			Load += FormSinhVien_QuanLy_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)grd_SinhVien).EndInit();
			((System.ComponentModel.ISupportInitialize)bsSinhVien).EndInit();
			toolStrip2.ResumeLayout(false);
			toolStrip2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripButton btn_NapDanhSach;
		private ToolStripButton btn_BoSung;
		private ToolStripButton btn_Sua;
		private ToolStripButton btn_Xoa;
		private ToolStripButton btn_QuanLyNganhDaoTao;
		private DataGridView grd_SinhVien;
		private BindingSource bsSinhVien;
		private StatusStrip statusStrip1;
		private ToolStrip toolStrip2;
		private ToolStripLabel lblThongKe;
		private DataGridViewTextBoxColumn colMaSinhVien;
		private DataGridViewTextBoxColumn colHoTen;
		private DataGridViewCheckBoxColumn colGioiTinh;
		private DataGridViewTextBoxColumn colNgaySinh;
		private DataGridViewTextBoxColumn colMaNganhDaoTao;
		private DataGridViewTextBoxColumn colGhiChu;
	}
}