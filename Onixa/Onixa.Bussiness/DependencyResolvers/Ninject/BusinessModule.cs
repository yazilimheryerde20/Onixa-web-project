using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Onixa.Bussiness.Abstact;
using Onixa.Bussiness.Concrete;
using Onixa.Core.DataAccess.EntityFramework;
using Onixa.DataAccess.Abstract;
using Onixa.DataAccess.Concrete.EntityFramework;
using Onixa.Entity;

namespace Onixa.Bussiness.DependencyResolvers.Ninject
{
   public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAddressService>().To<AddressManager>().InSingletonScope();
            Bind<IAddressDal>().To<EFAddressDal>();
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EFProductDal>();
            //Nesne bindignleri buraya gelecek
            //Amaç; biri senden interface istiyorsa classını ver
            //Hem dal hem manager vermeyi unutma!

            Bind(typeof(EFQueryableRepository<>)).To(typeof(EFQueryableRepository<>)).InSingletonScope();
            Bind<DbContext>().To<SitedbContext>();

        }
    }
}
