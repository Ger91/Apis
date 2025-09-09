using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOnePiece.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Age { get; set; }
        public string? Bounty { get; set; }
        public Crew? Crew { get; set; }
        public Fruit? Fruit { get; set; }
        public string? Job { get; set; }
        public string? Status { get; set; }
    }

    public class Crew
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Number { get; set; }
        public string? RomanName { get; set; }
        public string? TotalPrime { get; set; }
        public bool? IsYonko { get; set; }
    }

    public class Fruit
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Filename { get; set; }
        public string? RomanName { get; set; }
        public string? TechnicalFile { get; set; }
    }
}
