using System;
using System.Collections.Generic;
using System.Text;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class AdvertiserManager:IAdvertiserService
    {
        IAdvertiserDal _advertiserdal;

        public AdvertiserManager(IAdvertiserDal advertiserdal)
        {
            _advertiserdal = advertiserdal;
        }
        public void AdvertiserAdd(Advertiser advertiser)
        {
            _advertiserdal.Insert(advertiser);
        }

        public Advertiser GetById(int id)
        {
            return _advertiserdal.GetByID(id);
        }

        public List<Advertiser> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Advertiser t)
        {
            _advertiserdal.Insert(t);
        }

        public void TDelete(Advertiser t)
        {
            _advertiserdal.Delete(t);
        }

        public void TUpdate(Advertiser t)
        {
            _advertiserdal.Update(t);
        }
    }
}
