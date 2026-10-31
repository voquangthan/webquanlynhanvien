using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using QuanlynhanvienAPI.Models;
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
            _dbContext.Nhanviens.Update(nv);
            _dbContext.SaveChanges();
        }

    }
}
