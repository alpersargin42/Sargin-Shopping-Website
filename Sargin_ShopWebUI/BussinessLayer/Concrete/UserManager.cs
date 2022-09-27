using System;
using System.Collections.Generic;
using System.Text;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class UserManager:IUserService
    { 
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void TAdd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            return _userDal.GetByID(id);
        }
    }
}
