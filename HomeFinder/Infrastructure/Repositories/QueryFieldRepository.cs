using HomeFinder.Domain.Interfaces;
using HomeFinder.Domain.Models;
using HomeFinder.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeFinder.Infrastructure.Repositories
{
    public class QueryFieldRepository: IQueryFieldRepository
    {
        private readonly DbContextClass _dbContextClass;

        public QueryFieldRepository(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<QueryField> GetQueryFieldById(int id)
        {
            var query = await _dbContextClass.QueryFields.FirstOrDefaultAsync(quer => quer.QueryId == id);

            if (query != null)
            {
                return query;
            }
            return null;
        }

        public async Task AddQueryField(QueryField queryField)
        {
            await _dbContextClass.QueryFields.AddAsync(queryField);
        }
    }
}
