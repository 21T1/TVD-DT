using QuanLySinhVien_Thi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_Thi.DAL.Impl
{
	internal interface INganhDaoTaoDAO
	{
		/// <summary>
		/// Lấy danh sách (mã ngành, tên ngành, số sv)
		/// </summary>
		/// <returns></returns>
		public List<NganhDaoTao> GetDanhSach();

		public int Xoa(string maNganhDaoTao);
		public int BoSung(NganhDaoTao ndt);
		public int ChinhSua(NganhDaoTao ndt);

		/// <summary>
		/// Lấy danh sách (mãNgành, tênNgành)
		/// </summary>
		/// <returns></returns>
		public List<NganhDaoTaoDanhMuc> GetDanhSachDanhMuc();

	}
}
