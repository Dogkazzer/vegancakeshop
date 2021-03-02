using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganCakeShop.Models
{
    public class Cake
    {
        public int CakeId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsCakeOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }  //this is a navigation to the Categories
        public string Notes { get; set; }
    }
}
