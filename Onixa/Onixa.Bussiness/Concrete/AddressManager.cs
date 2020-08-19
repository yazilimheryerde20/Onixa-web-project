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
    public class AddressManager : IAddressService
    {
        private IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        
        public Adresses Add(Adresses address)
        {
            return _addressDal.Add(address);
        }

        public void Delete(Adresses adresses)
        {
            throw new NotImplementedException();
        }

        public List<Adresses> GelAll()
        {
            throw new NotImplementedException();
        }

        public Adresses GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Adresses Update(Adresses address)
        {
            throw new NotImplementedException();
        }
    }
}
