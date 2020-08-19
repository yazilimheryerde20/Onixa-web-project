using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Onixa.Bussiness.Abstact;
using Onixa.Bussiness.Concrete;
using Onixa.DataAccess.Concrete.EntityFramework;
using Onixa.Entity;
using Onixa_Web.Models;

namespace Onixa_Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
         
            var model = new ProductListViewModel
            {
                Products = _productService.GelAll()
            };
            return View(model);
        }

        
        public ActionResult ProductDetails()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Exit()
        {
            return View();
        }

        public ActionResult Basket()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public string deneme()
        {
         AddressManager addressManager=new AddressManager(new EFAddressDal());
         addressManager.Add(new Address
         {
            Name="sadd",
            Description = "sdfsdf",
            Member_Id=1,
            UserBy = "fgfgf"
         });
            return "sada";
        }
    }
}