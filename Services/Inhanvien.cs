using QuanlynhanvienAPI.Models;
namespace QuanlynhanvienAPI.Services
{
    public interface Inhanvien
    {
        List<Nhanvien> getnhanvien();
        void themnahnvien(Nhanvien nhanvien);
        void xoanhanvien(Nhanvien nv);
        void suanhanvien(Nhanvien nv);
    }
}
