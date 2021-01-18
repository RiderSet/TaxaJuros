using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Retorna.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {

        /// <summary>
        /// Retorna o jurios
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<decimal>> Get()
        {
            return new decimal[] { 0.01m };
        }
    }
}
