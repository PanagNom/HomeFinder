using HomeFinder.Domain.Models;
using HtmlAgilityPack;

namespace HomeFinder.Domain.Services
{
    public interface ISearchServices
    {
        string CreateSearchURL(QueryField queryField);
        IEnumerable<House> PerformSearch(string searchURL);
        void DownloadPageData(ref HtmlDocument document, string url);
    }
}
