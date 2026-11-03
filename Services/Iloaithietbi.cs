using QuanlynhanvienAPI.Models;

namespace QuanlynhanvienAPI.Services
{
    public interface Iloaithietbi
    {
        Task<List<Loaithietbi>> getltb();
        Task themloaithietbi(Loaithietbi ltb);
        Task xoaloaithietbi(Loaithietbi ltb);
        Task sualoaithietbi(Loaithietbi ltb);
    }
}
