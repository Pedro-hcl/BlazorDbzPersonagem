using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDbzPersonagem.Models
{
    public class personagem
    {
        public string? name { get; set; }

        public int? id { get; set; }

        public string? image { get; set; }
        public Planet? OriginPlanet { get; set; }
        public List<Transformation>? Transformations { get; set; }
    }


    public class Planet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Transformation
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? image { get; set; }
    }
}
