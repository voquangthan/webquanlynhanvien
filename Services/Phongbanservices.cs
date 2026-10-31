using QuanlynhanvienAPI.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace QuanlynhanvienAPI.Services
{
    public class Phongbanservices:IPhongbancs
    {
        private readonly QuanLyNhanVienDBContext _context;

        public Phongbanservices(QuanLyNhanVienDBContext context)
        {
            _context = context;
        }
        public List<Phongban> getdanhsachphongban()
        {
            return _context.Phongbans.ToList();
        }
        public void themphongban(Phongban phongban)
        {
            _context.Phongbans.Add(phongban);
            _context.SaveChanges();
        }
        public void xoaphongban(Phongban pb)
        {
            _context.Phongbans.Remove(pb);
            _context.SaveChanges();
        }
        public void suaphongban(Phongban pb)
        {
            _context.Phongbans.Update(pb);
            _context.SaveChanges();

        }
    }
}
