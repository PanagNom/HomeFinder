using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace HomeFinder.Domain.Models
{
    public class QueryField
    {
        [Key]
        public int QueryId { get; set; }

        [BindRequired]
        public string Geo_lat_from { get; set; } = string.Empty;
        
        [BindRequired]
        public string Geo_lat_to { get; set; } = string.Empty;
        [BindRequired] 
        public string Geo_lng_from { get; set; } = string.Empty;
        
        [BindRequired] 
        public string Geo_lng_to { get; set; } = string.Empty;

        [BindRequired]
        [Display(Name = "Minimum Price")]
        public ushort MinPrice { get; set; } = 0;

        [BindRequired]
        [Display(Name = "Maximum Price")]
        public ushort MaxPrice { get; set; } = 0;

        [BindRequired]
        [Display(Name = "Minimum Floor")]
        public ushort MinLevel { get; set; } = 0;
        
        [BindRequired]
        [Display(Name = "Maximum Floor")]
        public ushort MaxLevel { get; set; } = 0;

        [BindRequired]
        [Display(Name = "Minimum Square Meters")]
        public ushort MinSize { get; set; } = 0;

        [BindRequired]
        [Display(Name = "Maximum Square Meters")]
        public ushort MaxSize { get; set; } = 0;

        [BindRequired]
        [Range(0,6, ErrorMessage = "Total must be between 0 and 6")]
        [Display(Name = "Minimum Bedrooms")]
        public ushort MinBedrooms { get; set; } = 0;

        [BindRequired]
        [Range(0, 6, ErrorMessage = "Total must be between 0 and 6")]
        [Display(Name = "Maximum Bedrooms")]
        public ushort MaxBedrooms { get; set; } = 0;

        [BindRequired]
        [Range(0, 6, ErrorMessage = "Total must be between 0 and 6")]
        [Display(Name = "Minimum Bathrooms")]
        public ushort MinBathrooms { get; set; } = 0;

        [BindRequired]
        [Range(0, 6, ErrorMessage = "Total must be between 0 and 6")]
        [Display(Name = "Maximum Bathrooms")]
        public ushort MaxBathrooms { get; set; } = 0;

        [BindRequired]
        [Range(1900, 2024, ErrorMessage = "Year must be between 1900 and 2024")]
        [Display(Name = "Minimum Construction Year")]
        public ushort MinConstruction_year { get; set; } = 1900;

        [BindRequired]
        [Range(1900, 2024, ErrorMessage = "Year must be between 1900 and 2024")]
        [Display(Name = "Maximum Construction Year")]
        public ushort MaxConstruction_year { get; set; } = 1900;

        [BindRequired]
        [Range(0, 20000, ErrorMessage = "Total must be between 0 and 20000")]
        [Display(Name = "Minimum Price Per Square Meter")]
        public ushort MinPricePerUnitArea { get; set; } = 0;

        [BindRequired]
        [Range(0, 20000, ErrorMessage = "Total must be between 0 and 20000")]
        [Display(Name = "Maximum Price Per Square Meter")]
        public ushort MaxPricePerUnitArea { get; set; } = 0;

        [BindRequired]
        [Display(Name = "Minimum Energy Class")]
        public string MinEnergyClass { get; set; } = string.Empty;

        [BindRequired]
        [Display(Name = "Maximum Energy Class")]
        public string MaxEnergyClass { get; set; } = string.Empty;

        [Display(Name = "Availability")]
        public string[]? Availability { get; set; } = default(string[]);
    }
}
