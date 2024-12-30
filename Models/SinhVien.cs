using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_Thi.Models
{
	public class SinhVien
	{



		public string MaSinhVien { get; set; }

		public string HoDem { get; set; }
		public string Ten { get; set; }

		public bool GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string MaNganhDaoTao { get; set; }
		public string GhiChu { get; set; }

		public string HoVaTen { get { return HoDem + " " + Ten; } }
		public string TenNganhDaoTao { get; set; }

		public SinhVien(string maSinhVien, string hoDem, string ten, bool gioiTinh, DateTime ngaySinh, string? maNganhDaoTao, string ghiChu)
		{
			MaSinhVien = maSinhVien;
			HoDem = hoDem;
			Ten = ten;
			GioiTinh = gioiTinh;
			MaNganhDaoTao = maNganhDaoTao;
			NgaySinh = ngaySinh;
			GhiChu = ghiChu;
		}
	}
}
