using Microsoft.AspNetCore.Mvc;

namespace SigeFlot.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
