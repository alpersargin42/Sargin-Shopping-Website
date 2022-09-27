using System;
using System.Collections.Generic;
using System.Text;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;
        }
        public void TAdd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public void TUpdate(About t)
        {
           _aboutdal.Update(t);
        }

        public List<About> GetList()
        {
            return _aboutdal.GetListAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
