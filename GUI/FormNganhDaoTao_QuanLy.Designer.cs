namespace QuanLySinhVien_Thi.GUI
{
	partial class FormNganhDaoTao_QuanLy
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNganhDaoTao_QuanLy));
			toolStrip1 = new ToolStrip();
			btn_NapDanhSach = new ToolStripButton();
			btn_BoSung = new ToolStripButton();
			btn_Sua = new ToolStripButton();
			btn_Xoa = new ToolStripButton();
			grdNganhDaoTao = new DataGridView();
			colMaNganh = new DataGridViewTextBoxColumn();
			colTenNganh = new DataGridViewTextBoxColumn();
			colSoSinhVien = new DataGridViewTextBoxColumn();
			toolStrip2 = new ToolStrip();
			lblThongKe = new ToolStripLabel();
			bsNganhDaoTao = new BindingSource(components);
			toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)grdNganhDaoTao).BeginInit();
			toolStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)bsNganhDaoTao).BeginInit();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(24, 24);
			toolStrip1.Items.AddRange(new ToolStripItem[] { btn_NapDanhSach, btn_BoSung, btn_Sua, btn_Xoa });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 34);
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
			// 
			// btn_Sua
			// 
			btn_Sua.Image = (Image)resources.GetObject("btn_Sua.Image");
			btn_Sua.ImageTransparentColor = Color.Magenta;
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(70, 29);
			btn_Sua.Text = "Sửa";
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
			// grdNganhDaoTao
			// 
			grdNganhDaoTao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdNganhDaoTao.Columns.AddRange(new DataGridViewColumn[] { colMaNganh, colTenNganh, colSoSinhVien });
			grdNganhDaoTao.Location = new Point(12, 54);
			grdNganhDaoTao.Name = "grdNganhDaoTao";
			grdNganhDaoTao.RowHeadersWidth = 62;
			grdNganhDaoTao.Size = new Size(776, 308);
			grdNganhDaoTao.TabIndex = 1;
			// 
			// colMaNganh
			// 
			colMaNganh.DataPropertyName = "maNganhDaoTao";
			colMaNganh.HeaderText = "Mã ngành";
			colMaNganh.MinimumWidth = 8;
			colMaNganh.Name = "colMaNganh";
			colMaNganh.Width = 150;
			// 
			// colTenNganh
			// 
			colTenNganh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colTenNganh.DataPropertyName = "tenNganhDaoTao";
			colTenNganh.HeaderText = "Tên ngành";
			colTenNganh.MinimumWidth = 8;
			colTenNganh.Name = "colTenNganh";
			// 
			// colSoSinhVien
			// 
			colSoSinhVien.DataPropertyName = "soLuongSinhVien";
			colSoSinhVien.HeaderText = "Số sinh viên";
			colSoSinhVien.MinimumWidth = 8;
			colSoSinhVien.Name = "colSoSinhVien";
			colSoSinhVien.Width = 150;
			// 
			// toolStrip2
			// 
			toolStrip2.Dock = DockStyle.Bottom;
			toolStrip2.ImageScalingSize = new Size(24, 24);
			toolStrip2.Items.AddRange(new ToolStripItem[] { lblThongKe });
			toolStrip2.Location = new Point(0, 420);
			toolStrip2.Name = "toolStrip2";
			toolStrip2.Size = new Size(800, 30);
			toolStrip2.TabIndex = 2;
			toolStrip2.Text = "toolStrip2";
			// 
			// lblThongKe
			// 
			lblThongKe.Name = "lblThongKe";
			lblThongKe.Size = new Size(131, 25);
			lblThongKe.Text = "toolStripLabel1";
			// 
			// FormNganhDaoTao_QuanLy
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(toolStrip2);
			Controls.Add(grdNganhDaoTao);
			Controls.Add(toolStrip1);
			Name = "FormNganhDaoTao_QuanLy";
			Text = "FormNganhDaoTao_QuanLy";
			Load += FormNganhDaoTao_QuanLy_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)grdNganhDaoTao).EndInit();
			toolStrip2.ResumeLayout(false);
			toolStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)bsNganhDaoTao).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripButton btn_NapDanhSach;
		private ToolStripButton btn_BoSung;
		private ToolStripButton btn_Sua;
		private ToolStripButton btn_Xoa;
		private DataGridView grdNganhDaoTao;
		private ToolStrip toolStrip2;
		private ToolStripLabel lblThongKe;
		private BindingSource bsNganhDaoTao;
		private DataGridViewTextBoxColumn colMaNganh;
		private DataGridViewTextBoxColumn colTenNganh;
		private DataGridViewTextBoxColumn colSoSinhVien;
	}
}