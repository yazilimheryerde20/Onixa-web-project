using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Onixa.Entity;
using System.Threading.Tasks;

namespace Onixa.Bussiness.Abstact
{
  public  interface IAddressService
  {
      List<Address> GelAll();
      Address GetById(int id);
      Address Add(Address address);
      Address Update(Address address);
      void Delete(Address address);
  }
}
