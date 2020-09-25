using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Core.DataAccess;
using Onixa.Entity;
using Onixa.Entity.ComplexTypes;

namespace Onixa.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Products>
    {
        List<Productimages> GetProductsImageNamesList();
        List<Productimages> GetProductsImageNamesListbyProductId(int? id);
        List<ProductsLite> GetProductIndexList();
        List<ProductsLite> GetProductIndexListbyCategoryID(int? id);
    }
}
