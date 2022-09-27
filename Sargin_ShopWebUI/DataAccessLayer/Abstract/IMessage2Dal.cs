using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2Dal:IGenericDal<Message2>
    {
        List<Message2> GetListWithMessageByAdvertiser(int id);
        List<Message2> GetSendboxListWithMessageByAdvertiser(int id);
    }
}
