using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        List<Message> GetInboxListByAdvertiser(string p);
    }
}
