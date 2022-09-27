using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Pruduct>
    {
        List<Pruduct> GetListWithCategory();
        List<Pruduct> GetListWithCategoryByAdvertiser(int id);
    }
}
