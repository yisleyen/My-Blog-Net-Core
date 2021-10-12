using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Insert(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
