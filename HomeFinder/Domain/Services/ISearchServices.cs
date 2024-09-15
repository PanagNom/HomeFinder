using HomeFinder.Domain.Models;

namespace HomeFinder.Domain.Services
{
    public interface ISearchServices
    {
        string CreateSearchURL(QueryField queryField);
    }
}
