using Domain.Interfaces;
using HomeFinder.Domain.Interfaces;
using HomeFinder.Domain.Models;
using Microsoft.AspNetCore.Mvc;

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
            QueryField query = new() { };

            return View(query);
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
