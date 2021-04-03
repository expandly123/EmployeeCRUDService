using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDBLayer;
using Models.Employee;

namespace Services
{
    public class EmployeeService
    {
        public IEmployee iemployee { get; set; }
        public EmployeeService(IEmployee _iemployee)
        {
            iemployee = _iemployee;
        }

        public int AddEmployee(EmployeeModel empModel)
        {
            int i = 0;
            try
            {
                i = iemployee.AddEmployee(empModel);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int UpdateEmployee(EmployeeModel empModel)
        {
            int i = 0;
            try
            {
                i = iemployee.UpdateEmployee(empModel);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int DeleteEmployee(int EmpId)
        {
            int i = 0;
            try
            {
                i = iemployee.DeleteEmployee(EmpId);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
