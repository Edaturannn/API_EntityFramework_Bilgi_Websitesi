using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AllUsersManager : IAllUsersService
    {
        IAllUsersDal _allusersDal;
        public AllUsersManager(IAllUsersDal allusersDal)
        {
            _allusersDal = allusersDal;
        }

        public List<AllUsers> GetListAllUsers()
        {
            return _allusersDal.GetListAll();
        }

        public void TAdd(AllUsers t)
        {
            _allusersDal.Insert(t);
        }

        public void TDelete(AllUsers t)
        {
            _allusersDal.Delete(t);
        }
        public AllUsers TGetByID(int id)
        {
            return _allusersDal.GetById(id);
        }

        public List<AllUsers> TGetList(AllUsers t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AllUsers t)
        {
            _allusersDal.Update(t);
        }
    }
}
