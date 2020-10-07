using Onixa.Entity;
using System.Collections.Generic;
using System.Web.Mvc;
using Onixa.Entity.ComplexTypes;

namespace Onixa_Web.Models
{
    public class ProductListViewModel
    {
        public List<Productimages> Productimage { get; set; }
        public Products Product { get; set; }
        public List<Styles> Styleses { get; set; }
     
        public List<ProductsLite> ProductsLiteList { get; set; }
        public string Room_Name { get; set; }
        public string Note { get; set; }
        public int Project_ID { get; set; }
        public List<SelectListItem> ProjectList { get; set; }
        
    }
}