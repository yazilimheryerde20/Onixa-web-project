using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Core.DataAccess;
using Onixa.Entity;

namespace Onixa.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Products>
    {
    }
}
