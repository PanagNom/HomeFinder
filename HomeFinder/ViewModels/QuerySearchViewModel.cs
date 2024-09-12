using HomeFinder.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO.Pipelines;

namespace HomeFinder.ViewModels
{
    public class QuerySearchViewModel
    {
        public List<SelectListItem>? Bedroom { get; set; }
        public List<SelectListItem>? Bathroom { get; set; }
        public List<SelectListItem>? Level { get; set; }
        public List<SelectListItem>? EnergyClass { get; set; }
        public QueryField? QueryField { get; set; }

        public QuerySearchViewModel()
        {

            EnergyClass = new List<SelectListItem>
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

            Bedroom = new List<SelectListItem>
            {
                new SelectListItem { Value = "No Preference", Text = "No Preference" },
                new SelectListItem { Value = "1", Text = "1" },
                new SelectListItem { Value = "2", Text = "2" },
                new SelectListItem { Value = "3", Text = "3" },
                new SelectListItem { Value = "4", Text = "4" },
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "6+", Text = "6+" }
            };

            Bathroom = new List<SelectListItem>
            {
                new SelectListItem { Value = "No Preference", Text = "No Preference" },
                new SelectListItem { Value = "1", Text = "1" },
                new SelectListItem { Value = "2", Text = "2" },
                new SelectListItem { Value = "3", Text = "3" },
                new SelectListItem { Value = "4", Text = "4" },
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "6+", Text = "6+" }
            };

            Level = new List<SelectListItem>
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
        }
    }
}
