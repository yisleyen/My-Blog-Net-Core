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
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void Delete(Newsletter entity)
        {
            _newsletterDal.Delete(entity);
        }

        public List<Newsletter> GetAll()
        {
            return _newsletterDal.GetAll();
        }

        public Newsletter GetById(int id)
        {
            return _newsletterDal.GetById(id);
        }

        public void Insert(Newsletter newsletter)
        {
            _newsletterDal.Insert(newsletter);
        }

        public void Update(Newsletter entity)
        {
            _newsletterDal.Update(newsletter);
        }
    }
}
