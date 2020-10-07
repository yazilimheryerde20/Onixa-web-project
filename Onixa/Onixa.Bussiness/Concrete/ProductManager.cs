using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Bussiness.Abstact;
using Onixa.DataAccess.Abstract;
using Onixa.Entity;
using Onixa.Entity.ComplexTypes;

namespace Onixa.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private  IStyleDal _styledal;
       

        public ProductManager(IProductDal productDal, IStyleDal styleDal,IProductsImageNameDal productsImageNameDal)
        {
            _productDal = productDal;
            _styledal = styleDal;
            
        }
        public Products Add(Products products)
        {
            throw new NotImplementedException();
        }

        public void Delete(Products products)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            
            return _productDal.GetAllList();
        }

        public List<Styles> GetAllStyles()
        {
            return _styledal.GetAllList();
        }

        public List<Productimages> GetProductsImageListbyProductId(int? id)
        {
            return _productDal.GetProductsImageNamesListbyProductId(id);
        }

        public List<Products> GetbyCategoryIdAll(int? id)
        {
            return _productDal.GetAllList(x => x.Category_Id == id);
        }

        public Products GetByParentId(int id)
        {
            return _productDal.GetList(x=>x.Product_Id==id);
        }


        public List<ProductsLite> GetProductIndexList()
        {
            return _productDal.GetProductIndexList();
        }

        public List<ProductsLite> GetProductIndexListbyCategoryID(int? id)
        {
            return _productDal.GetProductIndexListbyCategoryID(id);
        }

        public Products Update(Products products)
        {
            throw new NotImplementedException();
        }

       
        public List<ProductsLite> GetProductIndexListbyStyleID(int? id)
        {
            return _productDal.GetProductIndexListbyStyleID(id);
        }

        public List<Project> GetProject()
        {
            return _productDal.GetProjects();
        }

        public MyBasket GetBaskets(int id)
        {
            return _productDal.GetMyBaskets(id);
        }
    }
}
