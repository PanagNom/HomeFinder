using HomeFinder.Domain.Models;

namespace HomeFinder.ViewModels
{
    public class QuerySearchViewModel
    {
        public QueryField? QueryField { get; set; }
        public IEnumerable<House> Houses { get; set; } = default!;
    }
}
