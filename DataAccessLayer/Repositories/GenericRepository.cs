using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t) //Belirli bir nesneyi veritabanından silmek için kullanılır. Belirtilen nesneyi veritabanından kaldırmak için bir DbContext nesnesi oluşturulur, nesne Remove metoduyla silinir ve sonra SaveChanges metodu çağrılarak değişiklikler kalıcı hale getirilir.
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id) //Belirli bir kimlik (id) değerine sahip nesneyi almak için kullanılır. Belirtilen kimliğe sahip nesne DbContext kullanılarak bulunur ve döndürülür.
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter) //Belirli bir koşula göre filtrelenmiş nesnelerin listesini almak için kullanılır. LINQ ifadeleriyle belirtilen filtre kullanılarak nesneler bulunur ve bir liste olarak döndürülür.
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public List<T> GetListAll() //Veritabanındaki tüm nesnelerin listesini almak için kullanılır. Tüm nesneler DbContext kullanılarak bulunur ve bir liste olarak döndürülür.
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t) //Veritabanına yeni bir nesne eklemek için kullanılır. Belirtilen nesne DbContext kullanılarak eklenir ve SaveChanges metodu çağrılarak değişiklikler kalıcı hale getirilir.
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t) //Belirli bir nesnenin veritabanındaki bilgilerini güncellemek için kullanılır. Belirtilen nesne DbContext kullanılarak güncellenir ve SaveChanges metodu çağrılarak değişiklikler kalıcı hale getirilir.
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}

