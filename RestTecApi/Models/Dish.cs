using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestTecApi.Models
{
    public class Dish
    {
        public string name { get; set; }
        public List<string> ingredients { get; set; }
    }
}
