using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Animals
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A fajta megadása kötelező.")]
        public Species Species { get; set; }
        [Required(ErrorMessage = "A név megadása kötelező.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Az életkor megadása kötelező.")]
        public double Age { get; set; }
        [Required(ErrorMessage = "A méret megadása kötelező.")]
        public Nullable<Size> Size { get; set; }
        [Required(ErrorMessage = "A nem megadása kötelező.")]
        public Gender Gender { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A bekerülés dátumának megadása kötelező.")]
        public DateTime GetIntoTheShelter { get; set; }
        [Required(ErrorMessage ="A leírás megadása kötelező.")]
        public string Desciption { get; set; }
        [Required(ErrorMessage = "A státusz megadása kötelező.")]
        public Status Status { get; set; }
    }

    public enum Species : byte
    {
        Dog,
        Cat
    }

    public enum Size : byte
    {
        Small,
        Medium,
        Big
    }

    public enum Gender : byte
    {
        Female,
        Male
    }

    public enum Status : byte
    {
        Adoptable,
        NotAdoptable
    }
}
