using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Bussiness.Abstact;
using Onixa.DataAccess.Abstract;
using Onixa.Entity;

namespace Onixa.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public Products Add(Products products)
        {
            throw new NotImplementedException();
        }

        public void Delete(Products products)
        {
            throw new NotImplementedException();
        }

        public List<Products> GelAll()
        {
            return _productDal.GetAllList();
        }

        public Products GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Products Update(Products products)
        {
            throw new NotImplementedException();
        }
    }
}
