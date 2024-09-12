using System.ComponentModel.DataAnnotations;

namespace HomeFinder.Domain.Models
{
    public class QueryField
    {
        [Key]
        public int QueryId { get; set; }
        public string Geo_lat_from { get; set; } = string.Empty;
        public string Geo_lat_to { get; set; } = string.Empty;
        public string Geo_lng_from { get; set; } = string.Empty;
        public string Geo_lng_to { get; set; } = string.Empty;

        [Display(Name = "Minimum Price")]
        public ushort MinPrice { get; set; }
        [Display(Name = "Maximum Price")]
        public ushort MaxPrice { get; set; }
        [Display(Name = "Minimum Floor")]
        public ushort MinLevel { get; set; }
        [Display(Name = "Maximum Floor")]
        public ushort MaxLevel { get; set; }
        [Display(Name = "Minimum Square Meters")]
        public ushort MinSize { get; set; }
        [Display(Name = "Maximum Square Meters")]
        public ushort MaxSize { get; set; }
        [Display(Name = "Minimum Bedrooms")]
        public ushort MinBedrooms { get; set; }
        [Display(Name = "Maximum Bedrooms")]
        public ushort MaxBedrooms { get; set; }
        [Display(Name = "Minimum Bathrooms")]
        public ushort MinBathrooms { get; set; }
        [Display(Name = "Maximum Bathrooms")]
        public ushort MaxBathrooms { get; set; }
        [Display(Name = "Minimum Construction Year")]
        public ushort MinConstruction_year { get; set; }
        [Display(Name = "Maximum Construction Year")]
        public ushort MaxConstruction_year { get; set; }
        [Display(Name = "Minimum Price Per Square Meter")]
        public ushort MinPricePerUnitArea { get; set; }
        [Display(Name = "Maximum Price Per Square Meter")]
        public ushort MaxPricePerUnitArea { get; set; }
        [Display(Name = "Minimum Energy Class")]
        public string MinEnergyClass { get; set; } = string.Empty;
        [Display(Name = "Maximum Energy Class")]
        public string MaxEnergyClass { get; set; } = string.Empty;
        [Display(Name = "Availability")]
        public string[]? Availability { get; set; }
    }
}
