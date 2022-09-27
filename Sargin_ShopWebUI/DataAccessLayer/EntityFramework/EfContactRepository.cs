using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactRepository: GenericRepository<Contact>, IContactDal
    {
    }
}
