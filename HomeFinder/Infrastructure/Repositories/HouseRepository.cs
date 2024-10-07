using HomeFinder.Domain.Interfaces;
using HomeFinder.Domain.Models;
using HomeFinder.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeFinder.Infrastructure.Repositories
{
    public class HouseRepository : IHouseRepository
    {
        private readonly DbContextClass _dbContextClass;

        public HouseRepository(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<House>> GetFavoritedHouses()
        {
            var FavoriteHouses = await _dbContextClass.Houses.Where(house => house.IsFavorited == true).ToListAsync();
            return FavoriteHouses;
        }
        public async Task<Guid> SaveHome(House house)
        {
            await _dbContextClass.Houses.AddAsync(house);

            return house.Id;
        }
    }
}
