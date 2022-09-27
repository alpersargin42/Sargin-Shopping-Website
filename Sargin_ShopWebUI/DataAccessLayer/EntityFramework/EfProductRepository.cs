using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Pruduct>, IProductDal
    {
        public List<Pruduct> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Pruducts.Include(x=>x.Category).ToList();
            }
        }

        public List<Pruduct> GetListWithCategoryByAdvertiser(int id)
        {
            using (var c = new Context())
            {
                return c.Pruducts.Include(x => x.Category).Where(x=>x.AdvertiserID==id).ToList();
            }
        }
    }
}
