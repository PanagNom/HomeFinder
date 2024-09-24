using HomeFinder.Domain.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.IO.Pipelines;

namespace HomeFinder.ViewModels
{
    public class QuerySearchViewModel
    {
        public QueryField? QueryField { get; set; }
        public IEnumerable<House> Houses { get; set; } = default!;
    }
}
