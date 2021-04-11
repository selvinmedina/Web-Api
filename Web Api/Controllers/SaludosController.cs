using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Web_Api.Controllers
{
    [Route("saludos")]
    [ApiController]
    public class SaludosController : ControllerBase
    {
        [HttpGet("{nombre}")]
        public ActionResult<string> ObtenerNombre(string nombre)
        {
            return $"Hola {nombre}";
        }

        [HttpGet("delay/{nombre}")]
        public async Task<string> ObtenerSaludoConDelay(string nombre)
        {
            Console.WriteLine($"Hilo antes del await: {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(500);
            Console.WriteLine($"Hilo despues del await: {Thread.CurrentThread.ManagedThreadId}");

            return $"Hola {nombre}";
        }
    }
}
