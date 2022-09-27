using System;
using System.Collections.Generic;
using System.Text;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TAdd(Pruduct t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Pruduct t)
        {
            _productDal.Delete(t);
        }

        public void TUpdate(Pruduct t)
        {
            _productDal.Update(t);
        }

        public List<Pruduct> GetList()
        {
            return _productDal.GetListAll();
        }

        public Pruduct GetById(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Pruduct> GPruductByID(int id)
        {
            return _productDal.GetListAll(x=>x.ProductID==id);
        }

        public List<Pruduct> GetProductListWithCategory()
        {
            return _productDal.GetListWithCategory();
        }

        public List<Pruduct> GetProductListByAdvertiser(int id)
        {
            return _productDal.GetListAll(x=>x.AdvertiserID==id);
        }

        public List<Pruduct> Test(int id)
        {
            return _productDal.GetListWithCategoryByAdvertiser(id);
        }

        public List<Pruduct> GetListWithCategoryByAdvertiser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
