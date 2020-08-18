using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Onixa.Bussiness.Concrete;
using Onixa.Entity;

namespace Onixa_Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
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
            var myModel = Models.HomeModel();
            AddressManager addressManager=new AddressManager();
            
            addressManager.Add(new Adresses
            {
                Name = "asd",
                Description = "asdas",
                AddedDate = DateTime.Now,
                Member_Id = 1,
                UserBy = "asda"
            });
            return "sada";
        }
    }
}