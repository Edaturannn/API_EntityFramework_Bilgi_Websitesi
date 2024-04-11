using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{ 
    public interface IAboutService : IGenericService<About> //IGenericService<About> arayüzünden miras alır ve About türündeki nesneler için genel bir hizmet arabirimi sağlar.
    {
        List<About> GetListAllAbout();
    }
}
