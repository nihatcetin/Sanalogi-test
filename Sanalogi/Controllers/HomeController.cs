using Microsoft.AspNetCore.Mvc;
using Sanalogi.Models;
using Sanalogi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sanalogi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var prd = new List<Product>
            {
                new Product{Name="Klavye",Price=15,Description="iyi klavye"},
                new Product{Name="Mouse",Price=25,Description="çok iyi"},
                new Product{Name="Klavye",Price=15,Description="iyi klavye"},
                new Product{Name="Mouse",Price=25,Description="çok iyi"},
                new Product{Name="Klavye",Price=15,Description="iyi klavye"},
                new Product{Name="Mouse",Price=25,Description="çok iyi"}
            };

            var prdViewModel = new ProductViewModel()
            {
                
                Products = prd
            };
            return View(prdViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
