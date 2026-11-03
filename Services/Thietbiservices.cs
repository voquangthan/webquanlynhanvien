using Microsoft.EntityFrameworkCore;
using QuanlynhanvienAPI.Models;

namespace QuanlynhanvienAPI.Services
{
    public class Thietbiservices:Ithietbi
    {
        private readonly QuanLyNhanVienDBContext _context;

        public Thietbiservices(QuanLyNhanVienDBContext context)
        {
            _context = context;
        }
         public async  Task<List<Thietbi>> Getthietbi()
        {
            return await _context.Thietbis.ToListAsync();
        }
        public async Task Themthietbi(Thietbi thietbi)
        {
            var kiemtra = _context.Thietbis.Any(x => x.Matb  == thietbi.Matb);
            if (kiemtra == true)
            {
                throw new Exception("mã thiết bị đã tồn tại");
            }
            else
            {
                _context.Thietbis.Add(thietbi);
                await _context.SaveChangesAsync();
            }
        }
        public async Task Xoathietbi(Thietbi thietbi)
        {
            _context.Thietbis.Remove(thietbi);
            await _context.SaveChangesAsync();  
        }
        public async Task Suathietbi(Thietbi thietbi)
        {
            var tb = await _context.Thietbis.FindAsync(thietbi.Matb);

            if (tb == null)
                throw new Exception("Không tìm thấy thiết bị");

            tb.Tentb = thietbi.Tentb;
            tb.Maloai = thietbi.Maloai;
            tb.Manv = thietbi.Manv;
            tb.Ngaymua = thietbi.Ngaymua;
            tb.Tinhtrang = thietbi.Tinhtrang;
            tb.Serialnumber = thietbi.Serialnumber;

            await _context.SaveChangesAsync();
        }
    }
}
