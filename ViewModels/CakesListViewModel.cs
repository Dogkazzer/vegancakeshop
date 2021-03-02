﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganCakeShop.Models;

namespace VeganCakeShop.ViewModels
{
    public class CakesListViewModel
    {
        public IEnumerable<Cake> Cakes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
