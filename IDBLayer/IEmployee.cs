using Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDBLayer
{
    public interface IEmployee
    {
        int AddEmployee(EmployeeModel empModel);
        int UpdateEmployee(EmployeeModel empModel);
        int DeleteEmployee(int EmpId);
    }
}
