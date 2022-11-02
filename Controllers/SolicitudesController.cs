using Microsoft.AspNetCore.Mvc;

namespace SigeFlot.Controllers
{
    public class SolicitudesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
