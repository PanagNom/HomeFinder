using HomeFinder.Domain.Interfaces;
using HomeFinder.Domain.Models;
using HomeFinder.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.Description;

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
        public async Task<House?> GetHome(Guid Id)
        {
            House? home = await _dbContextClass.Houses.FirstOrDefaultAsync(home => home.Id == Id);

            if (home == null)
            {
                return null;
            }

            return home;
        }
        public async Task<Guid> SaveHome(House house)
        {
            await _dbContextClass.Houses.AddAsync(house);

            return house.Id;
        }
        public async Task<Guid> SetFavoriteHome(House house)
        {
            house.IsFavorited = true;

            return await SaveHome(house);
        }
        public async Task<Guid?> UnsetFavoriteHome(Guid Id)
        {
            var home = await GetHome(Id);
            if (home == null)
            {
                return null;
            }
            else
            {
                _dbContextClass.Houses.Remove(home);
            }

            return home.Id;
        }
    }
}
