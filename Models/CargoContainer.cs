using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyRouteLogistics.Models
{
    public class CargoContainer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ContainerCode { get; set; } // Örn: CNT-5532

        [Required]
        public double Weight { get; set; } // Ağırlık

        [Required]
        public string ContentDescription { get; set; } // Kargo İçeriği

       
        // Her kargo bir uçuşa ait olmak zorundadır.
        public int FlightId { get; set; }
        
        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }
    }
}
