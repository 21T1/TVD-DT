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
	public partial class FormSinhVien_ChinhSua : Form
	{
		public FormSinhVien_ChinhSua(SinhVien sv)
		{
			InitializeComponent();
			txtMaSinhVien.Text = sv.MaSinhVien;
			txtMaSinhVien.Enabled = false;
			txtHoDem.Text = sv.HoDem;
			txtTen.Text = sv.Ten;
			txtGioiTinh.Text = sv.GioiTinh ? "Nam" : "Nữ";
			txtNgaySinh.Value = sv.NgaySinh;

			var nganhDaoTaoDAO = Program.GetNganhDaoTaoDAO();
			var lstNganhDaoTao = nganhDaoTaoDAO.GetDanhSachDanhMuc();
			txtNganh.DataSource = lstNganhDaoTao;
			txtNganh.DisplayMember = "TenNganhDaoTao";
			txtNganh.ValueMember = "MaNganhDaoTao";

			//for (int i = 0; i < lstNganhDaoTao.Count; i++)
			//{
			//	if (lstNganhDaoTao[i].MaNganhDaoTao == sv.MaNganhDaoTao)
			//	{
			//		txtNganh.SelectedIndex = i;
			//		break;
			//	}
			//}
			foreach(var item in lstNganhDaoTao)
			{
				if(item.MaNganhDaoTao == sv.MaNganhDaoTao)
				{
					txtNganh.Text = item.TenNganhDaoTao.ToString();
				}
			}
			txtGhiChu.Text = sv.GhiChu;
		}

		private void btn_Huy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			var maSinhVien = txtMaSinhVien.Text;
			var hoDem = txtHoDem.Text;
			var ten = txtTen.Text;
			var gioiTinh = txtGioiTinh.SelectedValue?.ToString() == "Nam" ? true : false;
			var ngaySinh = txtNgaySinh.Value;
			var maNganhDaoTao = txtNganh?.SelectedValue?.ToString();
			var ghiChu = txtGhiChu.Text;

			//try
			//{
			//	hoDem = txtHoDem.Text;
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show($"Dữ liệu Mã Sinh Viên không hợp lệ.");
			//	txtMaSinhVien.Focus();
			//	txtMaSinhVien.SelectAll();
			//	return;
			//}

			//try
			//{
			//	gioiTinh = txtGioiTinh.SelectedItem.ToString() == "Nam" ? true : false;
			//}
			//catch (Exception exc)
			//{
			//	MessageBox.Show("Dữ liệu Giới Tính không hợp lệ. \n" + exc.Message);
			//	txtGioiTinh.Focus();
			//	txtGioiTinh.SelectAll();
			//	return;
			//}

			//hoDem = txtHoDem.Text.Trim();
			//ten = txtTen.Text.Trim();
			//ngaySinh = txtNgaySinh.Value;
			//maNganhDaoTao = txtNganh.SelectedValue?.ToString();

			var sinhVienDAO = Program.GetSinhVienDAO();
			//maNganhDaoTao = "102";
			SinhVien sv = new SinhVien(maSinhVien, hoDem, ten, gioiTinh, ngaySinh, maNganhDaoTao, ghiChu);
			int n = sinhVienDAO.ChinhSua(sv);
			if(n > 0)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Không cập nhật được dữ liệu!!!");
			}


		}
	}
}
