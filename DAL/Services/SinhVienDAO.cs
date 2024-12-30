using Dapper;
using QuanLySinhVien_Thi.DAL.Impl;
using QuanLySinhVien_Thi.Models;
using System.Data.Common;

namespace QuanLySinhVien_Thi.DAL.Services
{
	public class SinhVienDAO : ISinhVienDAO
	{
		DbConnection GetConnection()
		{
			var cnn = new Microsoft.Data.SqlClient.SqlConnection();
			cnn.ConnectionString = "Server=localhost;Database=QuanLySinhVienDB;Integrated Security=True;TrustServerCertificate=True";
			
			return cnn;
		}
			public int BoSung(SinhVien sv)
		{

			var cnn = this.GetConnection();
			var sql = @"insert into SinhVien(MaSinhVien, HoDem, Ten, GioiTinh, NgaySinh, MaNganhDaoTao, GhiChu)
						values(@pMaSinhVien, @pHodem, @pTenn, @pGioiTinh, @pNgaySinh, @pMaNganhDaoTao, @pGhiChu)";

			var parameters = new
			{
				pMaSinhVien = sv.MaSinhVien,
				pHodem = sv.HoDem,
				pTenn = sv.Ten,
				pGioiTinh = sv.GioiTinh,
				pNgaySinh = sv.NgaySinh,
				pMaNganhDaoTao = sv.MaNganhDaoTao,
				pGhiChu = sv.GhiChu,
			};

			int n = cnn.Execute(sql, parameters);
			cnn.Close();

			return n;
		}

		public int ChinhSua(SinhVien sv)
		{
			var cnn = this.GetConnection();
			var sql = @"update SinhVien
							set HoDem = @pHoDem,
							Ten = @pTen,
							GioiTinh = @pGioiTinh,
							NgaySinh = @pNgaySinh,
							MaNganhDaoTao = @pMaNganhDaoTao,
							GhiChu = @pGhiChu
						where MaSinhVien = @pMaSinhVien";

			var parameters = new
			{
				pHoDem = sv.HoDem,
				pTen = sv.Ten,
				pGioiTinh = sv.GioiTinh,
				pNgaySinh = sv.NgaySinh,
				pMaNganhDaoTao = sv.MaNganhDaoTao,
				pGhiChu = sv.GhiChu,
				pMaSinhVien = sv.MaSinhVien
			};

			int n = cnn.Execute(sql, parameters);
			cnn.Close();

			return n;
		}

		public List<SinhVien> GetDanhSach()
		{
			var cnn = this.GetConnection();
			var sql = @"select MaSinhVien, Hodem, Ten, GioiTinh, NgaySinh, MaNganhDaoTao, GhiChu from SinhVien";

			var lst = cnn.Query<SinhVien>(sql).ToList();
			cnn.Close();

			return lst;
		}

		public int Xoa(string maSinhVien)
		{
			var cnn = this.GetConnection();
			var sql = "delete from SinhVien where MaSinhVien = @pMaSinhVien";

			var parameters = new
			{
				pMaSinhVien = maSinhVien
			};

			int n = cnn.Execute(sql, parameters);
			cnn.Close();

			return n;
		}
	}
}
