using Microsoft.AspNetCore.Mvc;
using Sanalogi.Models;
using Sanalogi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Sanalogi.Controllers
{
    public class ProductController : Controller
    {
        Context dbContext = new Context();
        public IActionResult Index(int page = 1)
        {
            var products = dbContext.Products.ToList().ToPagedList(page, 10);

            return View(products);
        }
        public IActionResult Search(string p)
        {
            var products = dbContext.Products.ToList();

            if (!string.IsNullOrEmpty(p))
            {
                products = products.Where(i => i.Name.ToLower().Contains(p.ToLower())).ToList();

                //return View(products);
            }

            return View(products);
        }


        public IActionResult Sorting(int value)
        {

            var products = dbContext.Products.ToList();


            if (value == 1)
            {
                products = products.OrderBy(p => p.Name).ToList();
            }
            else if (value == 2)
            {
                products = products.OrderByDescending(p => p.Name).ToList();
            }


            return View(products);
        }
        public IActionResult List()
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




            var prdViewModel = new ProductViewModel() //ViewModel üzerinden view'e gönderim yapılıyor.
            {

                Products = prd
            };
            return View(prdViewModel); ;
        }

        public IActionResult Details()
        {
            var prd = new Product();

            prd.Name = "Kulaklık";
            prd.Price = 2500;
            prd.Description = "Efsane bir ürün...";

            return View(prd); //view' gönderdik.
        }


    }
}
