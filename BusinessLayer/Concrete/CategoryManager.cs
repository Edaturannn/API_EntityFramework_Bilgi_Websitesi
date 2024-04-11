using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetListAllCategory()
        {
            return _categoryDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> TGetList(Category t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
