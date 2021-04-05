using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Newtonsoft.Json;


using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestTecApi.Models;
using RestTecApi.FileAdmin;
using Newtonsoft.Json.Linq;

namespace RestTecApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        FileManager file = new FileManager();

        [HttpGet]
        public string Get()
        {
            return file.userFile();
        }
        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }
        */
        [HttpPost]
        public string Validate(string user)
        {
            return file.compare(user, "password");
        }
        /*
        [HttpGet]
        public string ValidateUser()
        {
            User user = new User();
            
            string jsonUser = System.Text.Json.JsonSerializer.Serialize(user);

            FileManager file = new FileManager();
            string json = file.jsonFile();

            return json; //devuelve un json nulo

            return Ok(new
            {
                Nombre = "Manuel",
                Apellido = "Bojorge",
                Email = "abc@gmail.com"
            });

        }
        

        
        public string AlgoGet()
        {
            FileManager file = new FileManager();
            string json = file.jsonFile();

            return json;
        }
        */


    }
}
