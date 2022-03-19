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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Delete(AppUser entity)
        {
            _userDal.Delete(entity);
        }

        public List<AppUser> GetAll()
        {
            return _userDal.GetAll();
        }

        public AppUser GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public void Insert(AppUser entity)
        {
            _userDal.Insert(entity);
        }

        public void Update(AppUser entity)
        {
            _userDal.Update(entity);
        }
    }
}
