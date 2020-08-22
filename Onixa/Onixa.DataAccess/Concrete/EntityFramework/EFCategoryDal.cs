using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Core.DataAccess.EntityFramework;
using Onixa.DataAccess.Abstract;
using Onixa.Entity;

namespace Onixa.DataAccess.Concrete.EntityFramework
{
   public class EFCategoryDal:EFEntityRepositoryBase<Categories,SitedbContext>,ICategoryDal
    {

    }
}
