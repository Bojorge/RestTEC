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

        public string userFile()
        {
            string fileJSON = File.ReadAllText(@"C:\Users\Bojorge\Documents\BasesDeDatos\RestTEC\RestTEC\RestTecApi\JSON\users.json");


            return fileJSON;
        }

        public string dishFile()
        {
            string fileJSON = File.ReadAllText(@"C:\Users\Bojorge\Documents\BasesDeDatos\RestTEC\RestTEC\RestTecApi\JSON\dishes.json");


            return fileJSON;
        }

        public string compare(string user, string password)
        {
            FileManager file = new FileManager();
            string json = file.userFile();

            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            string valorstring = "";
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
                    if (valor == user)
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
                valor = "";
            }
            return "error";
        }
    }

}
