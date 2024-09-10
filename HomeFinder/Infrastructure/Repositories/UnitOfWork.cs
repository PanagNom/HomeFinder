using Domain.Interfaces;
using HomeFinder.Infrastructure.Data;

namespace HomeFinder.Infrastructure.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DbContextClass _dbContext;


        public UnitOfWork(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> saveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
