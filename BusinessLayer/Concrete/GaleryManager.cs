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
    public class GaleryManager : IGaleryService
    {
        IGaleryDal _galeryDal;
        public GaleryManager(IGaleryDal galeryDal)
        {
            _galeryDal = galeryDal;
        }

        public List<Galery> GetListAllGalery()
        {
            return _galeryDal.GetListAll();
        }

        public void TAdd(Galery t)
        {
            _galeryDal.Insert(t);
        }

        public void TDelete(Galery t)
        {
            _galeryDal.Delete(t);
        }

        public Galery TGetByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Galery TGetByID(int id)
        {
            return _galeryDal.GetById(id);
        }

        public List<Galery> TGetList(Galery t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Galery t)
        {
            _galeryDal.Update(t);
        }
    }
}
