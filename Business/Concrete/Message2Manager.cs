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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _messageDal;

        public Message2Manager(IMessage2Dal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Delete(Message2 entity)
        {
            _messageDal.Delete(entity);
        }

        public List<Message2> GetAll()
        {
            return _messageDal.GetAll();
        }

        public Message2 GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDal.GetAllWithWriterByMessage(id);
        }

        public void Insert(Message2 entity)
        {
            _messageDal.Insert(entity);
        }

        public void Update(Message2 entity)
        {
            _messageDal.Update(entity);
        }
    }
}
