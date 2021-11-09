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
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Delete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public List<Notification> GetAll()
        {
            return _notificationDal.GetAll();
        }

        public Notification GetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public void Insert(Notification entity)
        {
            _notificationDal.Insert(entity);
        }

        public void Update(Notification entity)
        {
            _notificationDal.Update(entity);
        }
    }
}
