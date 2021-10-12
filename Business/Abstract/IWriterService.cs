using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWriterService
    {
        void Insert(Writer writer);
        void Delete(Writer writer);
        void Update(Writer writer);
        List<Writer> GetAll();
        Writer GetById(int id);
    }
}
