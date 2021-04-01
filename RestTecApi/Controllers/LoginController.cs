using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestTecApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new
            {
                Nombre = "Manuel",
                Apellido = "Bojorge",
                Email = "abc@gmail.com"
            });
        }

    }
}
