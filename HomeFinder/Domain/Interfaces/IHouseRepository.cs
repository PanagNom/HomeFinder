using HomeFinder.Domain.Models;

namespace HomeFinder.Domain.Interfaces
{
    public interface IHouseRepository
    {
        Task<List<House>> GetFavoritedHouses();
        Task<Guid> SaveHome(House house);
    }
}
