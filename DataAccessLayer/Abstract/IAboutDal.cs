using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAboutDal : IGenericDal<About> // IAboutDal arayüzünü uygulayan sınıflar, About türündeki nesneler için belirli veritabanı işlemlerini sağlamak zorundadır. Bu sayede, bu tür için özelleştirilmiş bir DAL (Data Access Layer) sağlanır ve kod tekrarı önlenir.
    {

    }
}
