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

        public HomeController(ISearchServices searchServices, IUnitOfWork unitOfWork)
        {
            _searchServices = searchServices;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public ActionResult<IEnumerable<House>> Search(QueryField queryField)
        {
            string search_URL = _searchServices.CreateSearchURL(queryField);
            IEnumerable<House> houses = _searchServices.PerformSearch(search_URL);

            return Ok(houses);
        }
    }
}
