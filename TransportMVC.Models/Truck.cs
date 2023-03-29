using System.ComponentModel.DataAnnotations;

namespace TransportMVC.Models
{
    public class Truck
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string PlateNumber { get; set; }

        public int Capacity { get; set; }
    }
}
