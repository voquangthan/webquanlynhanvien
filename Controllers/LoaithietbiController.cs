using Microsoft.AspNetCore.Mvc;
using QuanlynhanvienAPI.Models;
using QuanlynhanvienAPI.Services;

namespace QuanlynhanvienAPI.Controllers
{
    [ApiController]
    [Route("api/loaithietbi")]
    public class LoaithietbiController : Controller
    {
        private readonly Iloaithietbi _loaithietbi;

        public LoaithietbiController(Iloaithietbi iloaithietbi)
        {
            _loaithietbi = iloaithietbi;
        }

        [HttpGet]
        public async Task<IActionResult> Get_Ltbcontroll()
        {
             var temp=await _loaithietbi.getltb();
            return Ok(temp);
        }
        [HttpPut]
        public async Task<IActionResult> Sualoaithietbi(Loaithietbi ltb)
        {
            await _loaithietbi.sualoaithietbi(ltb);
            return Ok(ltb);  
        }
        [HttpPost]
        public async Task<IActionResult> Themloaithietbi(Loaithietbi ltb)
        {
            await _loaithietbi.themloaithietbi(ltb);
            return Ok(ltb);
        }
        [HttpDelete]
        public async Task<IActionResult> Xoaloaithietbi(Loaithietbi ltb)
        {
            await _loaithietbi.xoaloaithietbi(ltb);
            return Ok(ltb);
        }
    }
}
