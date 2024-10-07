using HomeFinder.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HomeFinder.Domain.Services;
using HomeFinder.Domain.Models;
using Domain.Interfaces;
using HomeFinder.Domain.Models;
using HomeFinder.Domain.Services;

namespace HomeFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISearchServices _searchServices;
        private readonly IHouseRepository _houseRepository;

        public HomeController(ISearchServices searchServices, IUnitOfWork unitOfWork, IHouseRepository houseRepository)
        {
            _searchServices = searchServices;
            _unitOfWork = unitOfWork;
            _houseRepository = houseRepository;
        }

        [HttpPost]
        public async Task<IEnumerable<House>> Search(QueryField queryField)
        {
            string search_URL = _searchServices.CreateSearchURL(queryField);
            IEnumerable<House> houses = _searchServices.PerformSearch(search_URL);
            foreach (House house in houses)
            {
                await _houseRepository.SaveHome(house);
            }
            await _unitOfWork.saveChanges();

            return houses;
        }

        [HttpGet]
        public async Task<List<House>> GetListHomeAsync()
        {
            var homes = await _houseRepository.GetFavoritedHouses();

            return homes;
        }
    }
}
