using HomeFinder.Domain.Models;

namespace HomeFinder.Domain.Interfaces
{
    public interface IQueryFieldRepository
    {
        Task<QueryField> GetQueryFieldById(int id);
        Task AddQueryField(QueryField queryField);
    }
}
