using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestTecApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


//clase que lee y escribe los archivos con los datos de usuarios
namespace RestTecApi.FileAdmin
{
    public class FileManager
    {

        public string jsonFile()
        {
            string fileJSON = File.ReadAllText(@"C:\Users\Bojorge\Documents\BasesDeDatos\RestTEC\RestTEC\RestTecApi\JSON\users.json");


            return fileJSON;
        }

        public string compare()
        {
            /*
            User user = new User();
            user.password = "12";
            user.user = "Antonio";
            string jsonUser = System.Text.Json.JsonSerializer.Serialize(user);
            */
            FileManager file = new FileManager();
            string json = file.jsonFile();

            /*
            JObject o1 = JObject.Parse(File.ReadAllText(@"C:\Users\Bojorge\Documents\BasesDeDatos\RestTEC\RestTEC\RestTecApi\JSON\users.json"));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText(@"C:\Users\Bojorge\Documents\BasesDeDatos\RestTEC\RestTEC\RestTecApi\JSON\users.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
            }
            */
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            string valorstring = "";
            string objeto = "123";
            string condicion = "";
            string valor = "";

            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    //Console.WriteLine("Token: {0}, Valor: {1}", reader.TokenType, reader.Value);

                    valorstring = JsonConvert.SerializeObject(reader.Value);
                    //token = JsonConvert.SerializeObject(reader.TokenType);

                    for(int i=0; i<valorstring.Length; i++)
                    {
                        if( valorstring[i]!= '\"')
                        {
                            valor += valorstring[i];
                        }
                    }
                    if (valor == objeto)
                    {
                        condicion = "usuario aceptado";
                        return condicion;
                    }
                    else
                    {
                        condicion = "registrese";
                        return condicion;
                    }
                }

                /*
                else
                {
                    //Console.WriteLine("Token: {0}", reader.TokenType);
                }      
                */
                valor = "";
            }

            return "error";
        }
    }

}
