using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Entity;
using Onixa.Entity.ComplexTypes;

namespace Onixa.Bussiness.Abstact
{
   public interface IProductService
    {
        List<Products> GetAll();
        List<Products> GetbyCategoryIdAll(int? id);
        List<Styles> GetAllStyles();
        Products GetByParentId(int id);
       List<Productimages>  GetProductsImageListbyProductId(int? id);
       List<ProductsLite> GetProductIndexListbyStyleID(int? id);
        List<ProductsLite> GetProductIndexList();
        List<ProductsLite> GetProductIndexListbyCategoryID(int? id);
        List<Project> GetProject();
        MyBasket GetBaskets(int id);
        Products Add(Products products);
        Products Update(Products products);
        void Delete(Products products);
    }
}
