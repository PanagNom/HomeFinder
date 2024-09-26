using Domain.Interfaces;
using HomeFinder.Domain.Interfaces;
using HomeFinder.Domain.Models;
using HomeFinder.Domain.Services;
using HomeFinder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HomeFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryFieldRepository _queryFieldRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISearchServices _searchServices;
        public HomeController(IQueryFieldRepository queryFieldRepository, 
            IUnitOfWork unitOfWork, ISearchServices searchServices)
        {
            _queryFieldRepository = queryFieldRepository;
            _unitOfWork = unitOfWork;
            _searchServices = searchServices;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";

            return View();
        }

        public IActionResult Search()
        {
            ViewBag.Title = "Search";

            return View();
        }

        [HttpPost]
        public IActionResult Search(QuerySearchViewModel querySearchViewModel)
        {
            ViewBag.Title = "Search";

            string search_URL = _searchServices.CreateSearchURL(querySearchViewModel.QueryField);
            querySearchViewModel.Houses = _searchServices.PerformSearch(search_URL);

            return View(querySearchViewModel);
        }
    }
}
