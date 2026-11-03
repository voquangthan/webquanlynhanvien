using Microsoft.EntityFrameworkCore;
using QuanlynhanvienAPI.Models;

namespace QuanlynhanvienAPI.Services
{
    public class Loaithietbiservices : Iloaithietbi
    {
        private readonly QuanLyNhanVienDBContext _dbcontext;

        public Loaithietbiservices(QuanLyNhanVienDBContext dBContext)
        {
            _dbcontext = dBContext;
        }
        public async Task<List<Loaithietbi>> getltb()
        {
          return  await _dbcontext.Loaithietbis.ToListAsync();
        }
        public async Task themloaithietbi(Loaithietbi ltb)
        {
            _dbcontext.Loaithietbis.Add(ltb);
           await _dbcontext.SaveChangesAsync();
        }
        public async Task xoaloaithietbi(Loaithietbi ltb)
        {
            _dbcontext.Loaithietbis.Remove(ltb);
            await _dbcontext.SaveChangesAsync();    
        }
        public async Task sualoaithietbi(Loaithietbi ltb)
        {
            var kiemtra= _dbcontext.Thietbis.Any(xs=>xs.Maloai== ltb.Maloai);
            if (kiemtra == true)
            {
                throw new Exception("mã loại thiết bị đã tồn tại");
            }
            else
            {
                _dbcontext.Loaithietbis.Update(ltb);
                await _dbcontext.SaveChangesAsync();
            }
        }
    }
}
