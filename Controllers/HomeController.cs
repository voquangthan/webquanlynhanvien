using Microsoft.AspNetCore.Mvc;
using QuanlynhanvienAPI.Models;
using QuanlynhanvienAPI.Services;
namespace QuanlynhanvienAPI.Controllers
{
    [ApiController]
    [Route("api/nhanvien1")]
    public class HomeController : Controller
    {
        private readonly Inhanvien _inv;

        public HomeController(Inhanvien inv)
        {
            _inv= inv;
        }
        [HttpGet]
        public IActionResult laynhanvien()
        {
            return Ok(_inv.getnhanvien());
        }
        [HttpPut]
        public IActionResult suanhanvien([FromBody] Nhanvien nv)
        {
            try
            {
                _inv.suanhanvien(nv);
                return Ok(nv);
            }catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult themnhanvien([FromBody] Nhanvien nv)
        {
            try
            {
                _inv.themnahnvien(nv);
                return Ok(nv);
            }
            catch (Exception ex)
            {
               return Conflict(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult xoanhanvien([FromBody] Nhanvien nv)
        {
            _inv.xoanhanvien(nv);
            return Ok(nv);
        }
    }
}
