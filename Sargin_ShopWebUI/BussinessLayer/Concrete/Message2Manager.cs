using System;
using System.Collections.Generic;
using System.Text;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class Message2Manager: IMessage2Service
    {
        IMessage2Dal _message2Dal;
        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }
        public void TAdd(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetListAll();
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetByID(id);
        }

        public List<Message2> GetInboxListByAdvertiser(int id)
        {
            return _message2Dal.GetListWithMessageByAdvertiser(id);
        }

        public List<Message2> GetSendboxListWithMessageByAdvertiser(int id)
        {
            return _message2Dal.GetSendboxListWithMessageByAdvertiser(id);
        }
    }
}
