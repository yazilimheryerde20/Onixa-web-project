using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Entity;

namespace Onixa.Bussiness.Abstact
{
   public interface ICategoryService
   {
       List<Categories> GetAll();
       Categories GetById(int id);
       List<Categories> GetByParentId();
        Categories Add(Categories categories);
       Categories Update(Categories categories);

       void Delete(Categories categories);
   }
}
