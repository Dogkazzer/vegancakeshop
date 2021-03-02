using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganCakeShop.Models;
using VeganCakeShop.ViewModels;

namespace VeganCakeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ILogger<HomeController> logger, ICakeRepository cakeRepository)
        {
            _logger = logger;
            _cakeRepository = cakeRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CakesOfTheWeek = _cakeRepository.CakesOfTheWeek
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
