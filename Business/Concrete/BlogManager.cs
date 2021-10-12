using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void Insert(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetAllWithCategory()
        {
            return _blogDal.GetAllWithCategory();
        }
    }
}
