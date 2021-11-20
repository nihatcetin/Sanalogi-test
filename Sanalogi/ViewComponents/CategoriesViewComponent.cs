using Microsoft.AspNetCore.Mvc;
using Sanalogi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sanalogi.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cat = new List<Category>
            {
                new Category { Name = "Elektronik", Description = "İyi donanım" },
                new Category { Name = "Ev Alteleri", Description = "İyi donanım" },
                new Category { Name = "Beyaz Eşya", Description = "İyi donanım" }
            };
            return View(cat);
        }
    }
}
