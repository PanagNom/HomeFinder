using Domain.Interfaces;
using HomeFinder.Domain.Interfaces;
using HomeFinder.Domain.Models;
using HomeFinder.Domain.Services;
using HomeFinder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            QuerySearchViewModel querySearchViewModel = new();
            querySearchViewModel.QueryField = new QueryField();

            return View(querySearchViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Search(QueryField queryField)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _queryFieldRepository.AddQueryField(queryField);

            string search_URL = _searchServices.CreateSearchURL(queryField);

            //await _unitOfWork.saveChanges();

            return CreatedAtAction(nameof(Search), queryField);
        }
    }
}
