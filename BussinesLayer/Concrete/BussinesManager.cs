using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class BussinesManager : IBussinesService
    {
        IBussinesDal _bussinesDal;

        public BussinesManager(IBussinesDal bussinesDal)
        {
            _bussinesDal = bussinesDal;
        }

        public void TAdd(Bussines t)
        {
            _bussinesDal.Insert(t);
        }

        public void TDelete(Bussines t)
        {
            _bussinesDal.Delete(t);
        }

        public Bussines TGetByID(int id)
        {
           return _bussinesDal.GetByID(id);
        }

        public List<Bussines> TGetList()
        {
            return _bussinesDal.GetList();
        }

        public void TUpdate(Bussines t)
        {
          _bussinesDal.Update(t);
        }
    }
}
