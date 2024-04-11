using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> //Bu satır, IGenericService adında bir arayüz tanımlar. Bu arayüz, genel bir hizmet arabirimini temsil eder ve tür parametresi T'yi alır, bu da belirli bir türdeki nesneler için genel işlevlerin sağlanacağını gösterir.
    {
        void TAdd(T t); //Bu metot, bir nesneyi eklemek için kullanılır. Parametre olarak alınan nesne türü T'dir.
        void TDelete(T t); //Bu metot, bir nesneyi silmek için kullanılır. Parametre olarak alınan nesne türü T'dir.
        void TUpdate(T t); //Bu metot, bir nesneyi güncellemek için kullanılır. Parametre olarak alınan nesne türü T'dir.
        List<T> TGetList(T t); //Bu metot, belirli bir kriter veya filtre ile nesnelerin listesini almak için kullanılır. Parametre olarak alınan nesne türü T'dir ve belirli bir türdeki nesnelerin listesini döndürür.
        T TGetByID(int id); //Bu metot, belirli bir kimlik (ID) değerine sahip nesneyi almak için kullanılır. Parametre olarak bir tamsayı ID alır ve bu ID'ye sahip nesneyi döndürür.
    }
}
