using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using QuanlynhanvienAPI.Models;
using System.Diagnostics.Eventing.Reader;
namespace QuanlynhanvienAPI.Services
{
    public class Nhanvienservices:Inhanvien
    {
        private readonly QuanLyNhanVienDBContext _dbContext;

        public Nhanvienservices(QuanLyNhanVienDBContext dbcontext)
        {
            _dbContext= dbcontext;  
        }
        public List<Nhanvien> getnhanvien()
        {
            return _dbContext.Nhanviens.ToList();
        }
        public void themnahnvien(Nhanvien nv)
        {
            bool kiemtra=_dbContext.Nhanviens.Any(x=>x.Manv==nv.Manv);
            if(kiemtra==true)
            {
                throw new Exception("mã nhân viên đã tồn tại");
            }
            _dbContext.Nhanviens.Add(nv);
            _dbContext.SaveChanges();
        }
        public void xoanhanvien(Nhanvien nv)
        {
            _dbContext.Nhanviens.Remove(nv);
            _dbContext.SaveChanges();
        }
        public void suanhanvien(Nhanvien nv)
        {
            bool kiemtra=_dbContext.Nhanviens.Any(x=>x.Manv== nv.Manv);
            if (kiemtra == true)
            {
                throw new KeyNotFoundException("ko tìm thấy mã nhân viên!");
            }
            _dbContext.Nhanviens.Update(nv);
            _dbContext.SaveChanges();
        }

    }
}
