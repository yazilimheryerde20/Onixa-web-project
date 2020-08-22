using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onixa.Bussiness.Abstact;
using Onixa.DataAccess.Abstract;
using Onixa.DataAccess.Concrete.EntityFramework;
using Onixa.Entity;

namespace Onixa.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Categories Add(Categories categories)
        {
            throw new NotImplementedException();
        }

        public void Delete(Categories categories)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetAll()
        {
            return _categoryDal.GetAllList();
        }

        public Categories GetById(int id)
        {
            return _categoryDal.GetList(x => x.Category_Id == id);
        }

        public List<Categories> GetByParentId()
        {
            
            return _categoryDal.GetAllList(x => x.ParentID == null).ToList();
        }

        public Categories Update(Categories categories)
        {
            throw new NotImplementedException();
        }
    }
}
