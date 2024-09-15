using Domain.Interfaces;
using HomeFinder.Domain.Interfaces;
using HomeFinder.Domain.Models;
using HomeFinder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HomeFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryFieldRepository _queryFieldRepository;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IQueryFieldRepository queryFieldRepository, IUnitOfWork unitOfWork)
        {
            _queryFieldRepository = queryFieldRepository;
            _unitOfWork = unitOfWork;
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
            await _unitOfWork.saveChanges();

            QueryField query = new() { };

            return CreatedAtAction(nameof(Search), queryField);
        }
    }
}
