using QuanLySinhVien_Thi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_Thi.GUI
{
	public partial class FormSinhVien_BoSung : Form
	{
		public FormSinhVien_BoSung()
		{
			InitializeComponent();
		}

		private void btn_Huy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var maSinhVien = "";
			var hoDem = "";
			var ten = "";
			var gioiTinh = false;
			var ngaySinh = new DateTime(1999, 10, 12);
			var maNganhDaoTao = "";
			var ghiChu = "";

			// Validation
			try
			{
				maSinhVien = txtMaSinhVien.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show("Dữ liệu ID không hợp lệ. \n" + exc.Message);
				txtMaSinhVien.Focus();
				txtMaSinhVien.SelectAll();
				return;
			}

			try
			{
				hoDem = txtHoDem.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show("Dữ liệu Họ Đệm không hợp lệ. \n" + exc.Message);
				txtHoDem.Focus();
				txtHoDem.SelectAll();
				return;
			}

			try
			{
				ten = txtTen.Text;
			}
			catch (Exception exc)
			{
				MessageBox.Show("Dữ liệu Tên không hợp lệ. \n" + exc.Message);
				txtTen.Focus();
				txtTen.SelectAll();
				return;
			}

			try
			{
				gioiTinh = txtGioiTinh.SelectedItem?.ToString() == "Nam" ? true : false;
			}
			catch (Exception exc)
			{
				MessageBox.Show("Dữ liệu Giới Tính không hợp lệ. \n" + exc.Message);
				txtGioiTinh.Focus();
				txtGioiTinh.SelectAll();
				return;
			}

			ngaySinh = txtNgaySinh.Value;
			maNganhDaoTao = txtNganh?.SelectedValue?.ToString();
			ghiChu = txtGhiChu.Text;

			SinhVien sv = new SinhVien(maSinhVien, hoDem, ten, gioiTinh, ngaySinh, maNganhDaoTao, ghiChu);

			var sinhVienDAO = Program.GetSinhVienDAO();
			int n = sinhVienDAO.BoSung(sv);

			if(n > 0)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Không thêm được dữ liệu!!!");
			}
		}

		private void FormSinhVien_BoSung_Load(object sender, EventArgs e)
		{
			var nganhDaoTaoDAO = Program.GetNganhDaoTaoDAO();
			var lstNganhDaoTao = nganhDaoTaoDAO.GetDanhSachDanhMuc();

			txtNganh.DisplayMember = "TenNganhDaoTao";
			txtNganh.ValueMember = "MaNganhDaoTao";
			txtNganh.DataSource = lstNganhDaoTao;
		}
	}
}
