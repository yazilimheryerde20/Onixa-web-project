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
      List<Adresses> GelAll();
      Adresses GetById(int id);
      Adresses Add(Adresses address);
      Adresses Update(Adresses address);
      void Delete(Adresses adresses);
  }
}
