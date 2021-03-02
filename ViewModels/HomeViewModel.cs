using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganCakeShop.Models;

namespace VeganCakeShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cake>  CakesOfTheWeek { get; set; }
    }
}
