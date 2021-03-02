using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganCakeShop.Models;
using VeganCakeShop.ViewModels;

namespace VeganCakeShop.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }
        //public IActionResult List()
        //{
        //    CakesListViewModel cakesListViewModel = new CakesListViewModel();
        //    cakesListViewModel.Cakes = _cakeRepository.AllCakes;
        //    cakesListViewModel.CurrentCategory = "Vegan cakes";
        //    return View(cakesListViewModel);
        //}
        public ViewResult List(string category)
        {
            IEnumerable<Cake> cakes;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cakes = _cakeRepository.AllCakes.OrderBy(p => p.CakeId);
                currentCategory = "All cakes";
            }
            else
            {
                cakes = _cakeRepository.AllCakes.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.CakeId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CakesListViewModel
            {
                Cakes = cakes,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);
            if (cake == null)
                return NotFound();
            return View(cake);
        }

    }
}
