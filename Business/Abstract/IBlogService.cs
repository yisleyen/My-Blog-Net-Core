using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        void Insert(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
        List<Blog> GetAll();
        Blog GetById(int id);
        List<Blog> GetAllWithCategory();
        List<Blog> GetAllByWriter(int id);
    }
}
