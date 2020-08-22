using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Onixa.Bussiness.Abstact;
using Onixa_Web.Models;

namespace Onixa_Web.Controllers
{
    public class BaseController : Controller
    {

        
        public BaseController(ICategoryService categoryService)
        {

          

            var categoryModel = new CategoryListViewModel
            {
                Categorieses = categoryService.GetAll()
            };
            ViewBag.MenuCategories = categoryModel;

        }
    }
}