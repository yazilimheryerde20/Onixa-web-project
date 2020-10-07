using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Onixa.Entity;
using Onixa.Entity.ComplexTypes;

namespace Onixa_Web.Models
{
    public class BasketModel
    {
        //public int Product_ID { get; set; }
        //public int Project_ID { get; set; }
        //public string Note { get; set; }
        //public string Product_Name { get; set; }
        //public string Project_Name { get; set; }
        //public string Room_Name { get; set; }
        //public List<SelectListItem> ProductList { get; set; }
        //public List<SelectListItem> ProjectList { get; set; }
        public BasketModel()
        {
            this.ProductsDic=new Dictionary<int, int>();
            this.MyBasketbyProduct=new MyBasket();
            
        }
        public Dictionary<int, int> ProductsDic { get; set; }
        public MyBasket MyBasketbyProduct { get; set; }

        public List<string> Room_Name { get; set; }
        //public int count { get; set; }
        //public List<SelectListItem> ProjectList { get; set; }
        //public List<string> oda_adi { get; set; }


    }
}