using QuanLySinhVien_Thi.DAL.Services;
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
	public partial class FormSinhVien_QuanLy : Form
	{
		public FormSinhVien_QuanLy()
		{
			InitializeComponent();
		}

		private void btn_NapDanhSach_Click(object sender, EventArgs e)
		{
			var sinhVienDAO = Program.GetSinhVienDAO();
			bsSinhVien.DataSource = sinhVienDAO.GetDanhSach();

			grd_SinhVien.AutoGenerateColumns = false;
			grd_SinhVien.DataSource = bsSinhVien;
			lblThongKe.Text = $"Danh sách có {bsSinhVien.Count} Sinh Viên";
		}

		private void btn_QuanLyNganhDaoTao_Click(object sender, EventArgs e)
		{
			var frm = new FormNganhDaoTao_QuanLy();
			frm.StartPosition = FormStartPosition.CenterParent;
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				btn_NapDanhSach_Click(null, null);
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			SinhVien sv = null;
			if (bsSinhVien.Current != null)
			{
				sv = bsSinhVien.Current as SinhVien;

				if (sv != null)
				{
					var sinhVienDAO = Program.GetSinhVienDAO();
					int n = sinhVienDAO.Xoa(sv.MaSinhVien);

					if (n > 0)
					{
						btn_NapDanhSach_Click(null, null);
					}
				}
			}
		}

		private void FormSinhVien_QuanLy_Load(object sender, EventArgs e)
		{
			btn_NapDanhSach_Click(null, null);
		}

		private void btn_BoSung_Click(object sender, EventArgs e)
		{
			var frm = new FormSinhVien_BoSung();
			frm.StartPosition = FormStartPosition.CenterParent;
			frm.ShowDialog();

			if (frm.DialogResult == DialogResult.OK)
			{
				btn_NapDanhSach_Click(null, null);
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			SinhVien sv = null;
			if(bsSinhVien.Current != null)
			{
				sv = bsSinhVien.Current as SinhVien;
				if (sv != null)
				{
					var frm = new FormSinhVien_ChinhSua(sv);
					frm.StartPosition = FormStartPosition.CenterParent;
					frm.ShowDialog();
					if (frm.DialogResult == DialogResult.OK)
					{
						btn_NapDanhSach_Click(null, null);
					}
				}
			}

		}
	}
}
