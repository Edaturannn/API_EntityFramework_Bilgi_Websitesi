using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t); //Veritabanına yeni bir nesne eklemek için kullanılır.
        void Delete(T t); //Belirli bir nesneyi veritabanından silmek için kullanılır.
        void Update(T t); //Belirli bir nesnenin veritabanındaki bilgilerini güncellemek için kullanılır.
        List<T> GetListAll(); //Veritabanındaki tüm nesnelerin listesini almak için kullanılır.
        T GetById(int id); //Belirli bir kimlik (id) değerine sahip nesneyi almak için kullanılır.
        List<T> GetList(Expression<Func<T, bool>> filter); //Belirli bir koşula göre filtrelenmiş nesnelerin listesini almak için kullanılır. Bu, LINQ ifadeleriyle bir filtre alır.
    }
}
