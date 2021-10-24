using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    interface IEmployeeRepository
    {
        List<Employee> ListEmployee();
        Employee FindEmployeeById(int id);
        IEnumerable<Employee> FindEmployeesByName(string name);
        IEnumerable<Employee> FindTopEmployeesBySalary(int size);
        IEnumerable<Employee> FindEmployeesByStatus(bool status);
        bool Exist(int id);
        bool Delete(int id);

    }
}
