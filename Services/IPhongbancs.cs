using QuanlynhanvienAPI.Models;

namespace QuanlynhanvienAPI.Services
{
    public interface IPhongbancs
    {
        List<Phongban> getdanhsachphongban();
        void themphongban(Phongban pb);
        void xoaphongban(Phongban pb);
        void suaphongban(Phongban pb);

    }
}
