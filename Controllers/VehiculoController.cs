using Microsoft.AspNetCore.Mvc;

namespace SigeFlot.Controllers
{
    public class VehiculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
