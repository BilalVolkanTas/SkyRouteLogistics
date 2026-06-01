using System.ComponentModel.DataAnnotations;

namespace SkyRouteLogistics.Models
{
    public class Flight
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string FlightNumber { get; set; } // Örn: TK-1920

        [Required]
        public string Departure { get; set; } // Kalkış: İstanbul

        [Required]
        public string Destination { get; set; } // Varış: Londra

        // İlişki: Bir uçuşa birden fazla kargo yüklenebilir (One-to-Many)
        public List<CargoContainer> CargoContainers { get; set; }
    }
}
