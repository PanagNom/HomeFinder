using HomeFinder.Domain.Models;
using System.Web.Http;

namespace HomeFinder.Domain.Interfaces
{
    public interface IHouseRepository
    {
        Task<List<House>> GetFavoritedHouses();
        Task<Guid> SaveHome(House house);
        Task<House?> GetHome(Guid Id);
        Task<Guid> SetFavoriteHome(House house);
        Task<Guid?> UnsetFavoriteHome(Guid Id);
    }
}
