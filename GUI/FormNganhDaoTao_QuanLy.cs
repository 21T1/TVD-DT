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
	public partial class FormNganhDaoTao_QuanLy : Form
	{
		public FormNganhDaoTao_QuanLy()
		{
			InitializeComponent();
		}

		private void btn_NapDanhSach_Click(object sender, EventArgs e)
		{
			var nganhDaoTaoDAO = Program.GetNganhDaoTaoDAO();
			bsNganhDaoTao.DataSource = nganhDaoTaoDAO.GetDanhSach();

			grdNganhDaoTao.AutoGenerateColumns = false;
			grdNganhDaoTao.DataSource = bsNganhDaoTao;

			lblThongKe.Text = $"Danh sách này có {bsNganhDaoTao.Count} Ngành Đào Tạo.";
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			NganhDaoTao ndt = null;
			if(bsNganhDaoTao.Current != null)
			{
				ndt = bsNganhDaoTao.Current as NganhDaoTao;
				if(ndt != null)
				{
					var nganhDaoTaoDAO = Program.GetNganhDaoTaoDAO();
					int n = nganhDaoTaoDAO.Xoa(ndt.MaNganhDaoTao);

					if(n > 0)
					{
						btn_NapDanhSach_Click(null, null);
					}
				}
			}
		}

		private void FormNganhDaoTao_QuanLy_Load(object sender, EventArgs e)
		{
			btn_NapDanhSach_Click(null, null);
		}
	}
}
