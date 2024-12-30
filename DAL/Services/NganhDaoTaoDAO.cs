using Dapper;
using QuanLySinhVien_Thi.DAL.Impl;
using QuanLySinhVien_Thi.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_Thi.DAL.Services
{
	public class NganhDaoTaoDAO : INganhDaoTaoDAO
	{
		DbConnection GetConnection()
		{
			var cnn = new Microsoft.Data.SqlClient.SqlConnection();
			cnn.ConnectionString = "Server=localhost;Database=QuanLySinhVienDB;Integrated Security=True;TrustServerCertificate=True";
			return cnn;
		}
		public int BoSung(NganhDaoTao ndt)
		{
			throw new NotImplementedException();
		}

		public int ChinhSua(NganhDaoTao ndt)
		{
			throw new NotImplementedException();
		}

		public List<NganhDaoTao> GetDanhSach()
		{

			var cnn = this.GetConnection();
			var sql = @"select ndt.MaNganhDaoTao, ndt.TenNganhDaoTao, COUNT(ndt.MaNganhDaoTao) as SoLuongSinhVien
						from NganhDaoTao as ndt
						 join SinhVien as sv
						on ndt.MaNganhDaoTao = sv.MaNganhDaoTao
						group by ndt.MaNganhDaoTao, ndt.TenNganhDaoTao
						union
						select ndt.MaNganhDaoTao, ndt.TenNganhDaoTao, 0 as SoLuongSinhVien
						from NganhDaoTao as ndt
						where ndt.MaNganhDaoTao not in (select MaNganhDaoTao from SinhVien)";

			var lst = cnn.Query<NganhDaoTao>(sql).ToList();
			cnn.Close();

			return lst;
		}

		public List<NganhDaoTaoDanhMuc> GetDanhSachDanhMuc()
		{
			var cnn = this.GetConnection();
			var sql = @"SELECT MaNganhDaoTao, TenNganhDaoTao 
						FROM NganhDaoTao
						ORDER BY TenNganhDaoTao";

			var lst = cnn.Query<NganhDaoTaoDanhMuc>(sql).ToList();
			cnn.Close();

			return lst;
		}

		public int Xoa(string maNganhDaoTao)
		{
			var cnn = this.GetConnection();
			var sql = "delete from NganhDaoTao where MaNganhDaoTao = @pMaNganhDaoTao";

			var parameters = new
			{
				pMaNganhDaoTao = maNganhDaoTao
			};

			int n = cnn.Execute(sql, parameters);
			cnn.Close();

			return n;
		}
	}
}
