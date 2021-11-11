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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Delete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetAll(x => x.Receiver == p);
        }

        public void Insert(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void Update(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}
