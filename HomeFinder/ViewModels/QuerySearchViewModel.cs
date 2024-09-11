using HomeFinder.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO.Pipelines;

namespace HomeFinder.ViewModels
{
    public class QuerySearchViewModel
    {
        public IEnumerable<SelectListItem>? EnergyClass { get; set; } = default!;
        public QueryField? QueryField { get; set; }
    }
}
