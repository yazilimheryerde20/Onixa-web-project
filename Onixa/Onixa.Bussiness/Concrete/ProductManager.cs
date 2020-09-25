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
        private IProductsImageNameDal _imageNameDal;

        public ProductManager(IProductDal productDal, IStyleDal styleDal,IProductsImageNameDal productsImageNameDal)
        {
            _productDal = productDal;
            _styledal = styleDal;
            _imageNameDal = productsImageNameDal;
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

        public List<Productimages> GetProductsImageNamesListbyProductId(int? id)
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

        public List<Productimages> GetProductimagesesAll()
        {

           return _productDal.GetProductsImageNamesList();
        }

        public List<Productimages> GetProductimagesList()
        {
            return _productDal.GetProductsImageNamesList();
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
    }
}
