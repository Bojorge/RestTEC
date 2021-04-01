using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new {
                Nombre="Manuel",
                Apellido="Bojorge",
                Email="abc@gmail.com"
            });
        }

        /*
        [HttpPost("/addAlgo")]
        public ActionResult AddAlgo(int id)
        {
            return Ok(new
            {
                Nombre = "Manuel",
                Apellido = "Bojorge",
                Email = "abc@gmail.com"
            });
        }

        */

    }
}
