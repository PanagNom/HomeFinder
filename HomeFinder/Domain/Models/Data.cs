using Microsoft.AspNetCore.Mvc.Rendering;

namespace HomeFinder.Domain.Models
{
    public static class Data
    {
        public static string[] energy_class = new string[] { "A+", "A", "B+", "B", "C", "D", "E", "Z", "H" };
        public static string[] level = new string[] { "S1", "SH", "L0", "LHH", "LH", "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8" };

        public static List<SelectListItem> Bedroom { get; set; } = new List<SelectListItem>
            {
                new SelectListItem { Value = "No Preference", Text = "No Preference" },
                new SelectListItem { Value = "1", Text = "1" },
                new SelectListItem { Value = "2", Text = "2" },
                new SelectListItem { Value = "3", Text = "3" },
                new SelectListItem { Value = "4", Text = "4" },
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "6+", Text = "6+" }
            };
        public static List<SelectListItem> Bathroom { get; set; } = new List<SelectListItem>
            {
                new SelectListItem { Value = "No Preference", Text = "No Preference" },
                new SelectListItem { Value = "1", Text = "1" },
                new SelectListItem { Value = "2", Text = "2" },
                new SelectListItem { Value = "3", Text = "3" },
                new SelectListItem { Value = "4", Text = "4" },
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "6+", Text = "6+" }
            };
        public static List<SelectListItem> Level { get; set; } = new List<SelectListItem>
            {
                new SelectListItem { Value = "No Preference", Text = "No Preference" },
                new SelectListItem { Value = "Υπόγειο", Text = "S1" },
                new SelectListItem { Value = "Ημιυπόγειο", Text = "SH" },
                new SelectListItem { Value = "Ισόγειο", Text = "L0" },
                new SelectListItem { Value = "Υπερυψωμένο", Text = "LHH" },
                new SelectListItem { Value = "Ημιώροφος", Text = "LH" },
                new SelectListItem { Value = "1ος", Text = "L1" },
                new SelectListItem { Value = "2ος", Text = "L2" },
                new SelectListItem { Value = "3ος", Text = "L3" },
                new SelectListItem { Value = "4ος", Text = "L4" },
                new SelectListItem { Value = "5ος", Text = "L5" },
                new SelectListItem { Value = "6ος", Text = "L6" },
                new SelectListItem { Value = "7ος", Text = "L7" },
                new SelectListItem { Value = "8ος+", Text = "L8" },
            };
        public static List<SelectListItem> EnergyClass { get; set; } = new List<SelectListItem>
            {
                new SelectListItem { Value = Data.energy_class[0], Text = "Class " + Data.energy_class[0] },
                new SelectListItem { Value = Data.energy_class[1], Text = "Class " + Data.energy_class[1] },
                new SelectListItem { Value = Data.energy_class[2], Text = "Class " + Data.energy_class[2] },
                new SelectListItem { Value = Data.energy_class[3], Text = "Class " + Data.energy_class[3] },
                new SelectListItem { Value = Data.energy_class[4], Text = "Class " + Data.energy_class[4] },
                new SelectListItem { Value = Data.energy_class[5], Text = "Class " + Data.energy_class[5] },
                new SelectListItem { Value = Data.energy_class[6], Text = "Class " + Data.energy_class[6] },
                new SelectListItem { Value = Data.energy_class[7], Text = "Class " + Data.energy_class[7] },
                new SelectListItem { Value = Data.energy_class[8], Text = "Class " + Data.energy_class[8] },
            };
        /*
        
       

        public string[] buildingAvailability = new string[] { "OCCUPATED", "AVAILABLE" };
        public string[] buildingCondition = new string[] { "NEWBUILT", "NEEDS_REPAIR", "UNDER_CONSTRUCTION", "REFURBISHED" };
        public string[] buildingOptions = new string[] { "apartment", "building", "maisonette", "house", "floor-flat", "penthouse" };

        string[] characteristics = new string[] {
            "&is_furnished=true",
            "&has_parking=true",
            "&has_autonomous_heating=true",
            "&has_aircondition=true",
            "&has_natural_gas=true",
            "&has_central_heating=true",
            "&has_tents=true",
                                                    "&has_pool=true",
                                                    "&with_no_communal_charge=true",
                                                    "&is_suitable_for_holiday_residence=true",
                                                    "&has_aluminium_frames=true",
                                                    "&pets_allowed=true",
                                                    "&is_suitable_for_investment=true",
                                                    "&has_storage=true",
                                                    "&has_garden=true",
                                                    "&has_fireplace=true",
                                                    "&is_suitable_for_students=true",
                                                    "&has_secure_door=true",
                                                    "&has_insect_screens=true",
                                                    "&is_suitable_for_professional_use=true",
                                                    "&is_available_for_short_time_rent=true",
                                                    "&has_solar_boiler=true"
        };
        string[] advertisementOptions = new string[] { "&has_photos=true", "&has_videos=true", "&has_reduced_price=true", "&publication_origins%5B%5D=0", "&publication_origins%5B%5D=1", };
        string[] realtors = new string[] { "&realtors%5B%5D=Micasa&realtors%5B%5D=Roi+Mat+Real+Estate", "&realtors%5B%5D=Palmos+Properties", "&realtors%5B%5D=One+Real+Estate&realtors%5B%5D=VIProperty", "&realtors%5B%5D=%CE%9F%CE%B9%CE%BA%CE%BF%CF%83%CF%84%CE%AD%CE%B3%CE%B7",
                                            "&realtors%5B%5D=Golden+Home&realtors%5B%5D=Planet+Homes", "&realtors%5B%5D=Metroland+Real+Estate+Management" };
    
        */
    }
}
