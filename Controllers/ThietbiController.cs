using Microsoft.AspNetCore.Mvc;
using QuanlynhanvienAPI.Models;
using QuanlynhanvienAPI.Services;

namespace QuanlynhanvienAPI.Controllers
{
    [ApiController]
    [Route("api/thietbi")]
    public class ThietbiController : Controller
    {
        private readonly Ithietbi _tb;
        public ThietbiController(Ithietbi tb)
        {
            _tb = tb;
        }
        [HttpGet]
        public async Task<IActionResult> Getthietbi()
        {
            var thietbi = await _tb.Getthietbi();
            return Ok(thietbi);
        }
        [HttpPost]
        public async Task<IActionResult> Themthietbi(Thietbi thietbi)
        {
            try
            {
                await _tb.Themthietbi(thietbi);
                return Ok(thietbi); 
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Xoathietbi(Thietbi thietbi)
        {
            try
            {
                await _tb.Xoathietbi(thietbi);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(thietbi);
        }
        [HttpPut]
        public async Task<IActionResult> Suathietbi(Thietbi thietbi)
        {
            try
            {
                await _tb.Suathietbi(thietbi);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
            return Ok(thietbi);
        }
    }
}
