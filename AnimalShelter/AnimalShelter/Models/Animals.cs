using System;

namespace AnimalShelter.Models
{
    public class Animals
    {
        public int Id { get; set; }
        public byte Species { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public Nullable<byte> Size { get; set; }
        public byte Gender { get; set; }
        public DateTime GetIntoTheShelter { get; set; }
        public string Desciption { get; set; }
        public byte Status { get; set; }
    }
}
