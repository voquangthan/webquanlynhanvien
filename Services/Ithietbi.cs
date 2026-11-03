using QuanlynhanvienAPI.Models;

namespace QuanlynhanvienAPI.Services
{
    public interface Ithietbi
    {
        Task<List<Thietbi>> Getthietbi();
        Task Themthietbi(Thietbi thietbi);
        Task Xoathietbi(Thietbi thietbi);
        Task Suathietbi(Thietbi thietbi);
    }
}
