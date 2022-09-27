using System;
using System.Collections.Generic;
using System.Text;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class MessageManager:IMessageService
    {
        private IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll();
        }

        public Message GetById(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> GetInboxListByAdvertiser(string p)
        {
            return _messageDal.GetListAll(x=>x.Receiver==p);
        }
    }
}
