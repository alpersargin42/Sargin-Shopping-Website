using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
    public interface IMessage2Service : IGenericService<Message2>
    {
        List<Message2> GetInboxListByAdvertiser(int id);
        List<Message2> GetSendboxListWithMessageByAdvertiser(int id);

    }
}
