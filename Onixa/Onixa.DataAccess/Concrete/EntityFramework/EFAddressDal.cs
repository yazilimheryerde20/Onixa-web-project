using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Entity;
using Onixa.Core.DataAccess.EntityFramework;
using Onixa.DataAccess.Abstract;

namespace Onixa.DataAccess.Concrete.EntityFramework
{
   public class EFAddressDal:EFEntityRepositoryBase<Adresses,SitedbContext>,IAddressDal
    {
    }
}
