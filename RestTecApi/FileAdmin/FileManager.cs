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

    }
}
