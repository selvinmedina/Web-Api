using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Web_Api.Helpers;

namespace Web_Api.Controllers
{
    [Route("tarjetas")]
    [ApiController]
    public class TarjetasController : ControllerBase
    {
        public static int cantidadTarjetas = 0;
        [HttpPost("")]
        public async Task<ActionResult> ProcesarTarjeta([FromBody] string tarjeta)
        {
            var valorAleatorio = RandomGen.NextDouble();
            var aprobada = valorAleatorio > 0.1;

            Console.WriteLine($"Tarjeta {tarjeta} procesada");
            Console.WriteLine(++cantidadTarjetas);

            return Ok(new { Tarjeta = tarjeta, Aprobada = aprobada });
        }
    }
}
