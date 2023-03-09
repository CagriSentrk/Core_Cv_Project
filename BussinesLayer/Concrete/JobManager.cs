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
    public class JobManager : IJobService
    {
        IJobDal _jobdal;

        public JobManager(IJobDal jobdal)
        {
            _jobdal = jobdal;
        }

        public void TAdd(Job t)
        {
            _jobdal.Insert(t);
        }

        public void TDelete(Job t)
        {
           _jobdal.Delete(t);
        }

        public Job TGetByID(int id)
        {
            return _jobdal.GetByID(id);
        }

        public List<Job> TGetList()
        {
            return _jobdal.GetList();
        }

        public void TUpdate(Job t)
        {
            _jobdal.Update(t);
        }
    }
}
