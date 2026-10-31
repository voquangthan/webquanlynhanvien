using Microsoft.AspNetCore.Mvc;
using QuanlynhanvienAPI.Models;
using QuanlynhanvienAPI.Services;
namespace QuanlynhanvienAPI.Controllers
{
    [ApiController]
    [Route("api/phongban")]
    public class PhongbanController : Controller
    {
        private readonly IPhongbancs _iphongbanc;

        public PhongbanController(IPhongbancs iphongbanc)
        {
            _iphongbanc = iphongbanc;   
        }
        [HttpPost]
        public IActionResult Themphongbanller(Phongban pb)
        {
            _iphongbanc.themphongban(pb);
            return Ok(pb);
        }
        [HttpGet]
        public IActionResult Getphongbanller()
        {
            return Ok(_iphongbanc.getdanhsachphongban());
        }
        [HttpPut]
        public IActionResult Suaphongbanller(Phongban pb)
        {
            _iphongbanc.suaphongban(pb);
            return Ok(pb);
        }
        [HttpDelete]
        public IActionResult Xoaphongbanller(Phongban pb)
        {
            _iphongbanc.xoaphongban(pb);
            return Ok(pb);
        }
    }
}
