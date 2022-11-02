using Microsoft.AspNetCore.Mvc;

namespace SigeFlot.Controllers
{
    public class AcnoViajeController
    {

        [HttpPost]
        public IHttpActionResult Listado()
        {
            List<AcnoViaje> lista = new AcnoViajeBoImp().Listado();
            return Ok(new { listado = lista });

        }


    }
}
