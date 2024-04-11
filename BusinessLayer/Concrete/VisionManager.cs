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
    public class VisionManager : IVisionService
    {
        IVisionDal _visionDal;
        public VisionManager(IVisionDal visionDal)
        {
            _visionDal = visionDal;
        }

        public List<Vision> GetListAllVision()
        {
            return _visionDal.GetListAll();
        }

        public void TAdd(Vision t)
        {
            _visionDal.Insert(t);
        }

        public void TDelete(Vision t)
        {
            _visionDal.Delete(t);
        }

        public Vision TGetByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Vision TGetByID(int id)
        {
            return _visionDal.GetById(id);
        }

        public List<Vision> TGetList(Vision t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Vision t)
        {
            _visionDal.Update(t);
        }
    }
}
