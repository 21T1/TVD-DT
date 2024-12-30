using QuanLySinhVien_Thi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_Thi.DAL.Impl
{
	public interface ISinhVienDAO
	{
		public List<SinhVien> GetDanhSach();
		public int Xoa(string maSinhVien);
		public int BoSung(SinhVien sv);
		public int ChinhSua(SinhVien sv);
	}
}
