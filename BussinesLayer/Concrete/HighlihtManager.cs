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
    public class HighlihtManager : IHighlihtService
    {
        IHighLihtDal _highlihtdal;

        public HighlihtManager(IHighLihtDal highlihtdal)
        {
            _highlihtdal = highlihtdal;
        }

        
        public void TAdd(Highliht t)
        {
            _highlihtdal.Insert(t);
        }

        public void TDelete(Highliht t)
        {
            _highlihtdal.Delete(t);
        }

        public Highliht TGetByID(int id)
        {
            return _highlihtdal.GetByID(id);
        }

        public List<Highliht> TGetList()
        {
            return _highlihtdal.GetList();
        }

        public void TUpdate(Highliht t)
        {
            _highlihtdal.Update(t);
        }
    }
}
