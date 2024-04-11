using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFAboutRepository : GenericRepository<About>, IAboutDal //Bu sınıf GenericRepository sınıfından miras alır ve aynı zamanda IAboutDal arayüzünü uygular.
    {
    }
}
