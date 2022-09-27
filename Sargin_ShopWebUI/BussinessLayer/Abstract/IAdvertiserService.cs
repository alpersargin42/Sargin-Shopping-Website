using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;
using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
    public interface IAdvertiserService:IGenericService<Advertiser>
    {
        void AdvertiserAdd(Advertiser advertiser);
    }
}
