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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _EmployeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _EmployeeDal = employeeDal;
        }

        public void TAdd(Employee t)
        {
            _EmployeeDal.Insert(t);
        }

        public void TDelete(Employee t)
        {
            _EmployeeDal.Delete(t);
        }

        public Employee TGetByID(int id)
        {
            return _EmployeeDal.GetByID(id);
        }

        public List<Employee> TGetList()
        {
            return _EmployeeDal.GetList();
        }

        public void TUpdate(Employee t)
        {
           _EmployeeDal.Update(t);
        }
    }
}
