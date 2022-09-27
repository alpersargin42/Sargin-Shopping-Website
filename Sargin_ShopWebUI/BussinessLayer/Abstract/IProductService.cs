using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
    public interface IProductService:IGenericService<Pruduct>
    {
        List<Pruduct> GetProductListWithCategory();
        List<Pruduct> GetProductListByAdvertiser(int id);
        
    }
}
