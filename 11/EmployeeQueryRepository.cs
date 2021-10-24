using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class EmployeeQueryRepository : IEmployeeRepository
    {
        List<Employee> list;

        public EmployeeQueryRepository(List<Employee> list)
        {
            this.list = list;
        }

        public bool Delete(int id)
        {
            var retList = (from mployee in this.list
                          where mployee.Id == id
                          select mployee).FirstOrDefault();
            if (retList==null)
            {
                Console.WriteLine("********* Not found any record *******");
                return false;
            }
            Console.WriteLine("********* Deleted Successful *******");
            this.list.Remove(retList);
            this.ListEmployee();
            return true;
        }
        public bool Exist(int id)
        {
            var retList = from mployee in this.list
                          where mployee.Id == id
                          select mployee;
            if (retList.Count() <= 0)
            {
                Console.WriteLine("********* Not found any record *******");
                return false;
            }
                Console.WriteLine("********* Employee existed *******");
                var employee = retList.ElementAt(0);
                Console.WriteLine(employee.Id + ": " + employee.FirstName + " " + employee.LastName);
                return true;
            
        }

        public Employee FindEmployeeById(int id)
        {
            var retList = from mployee in this.list
                          where mployee.Id == id
                          select mployee;
            if (retList.Count() <= 0)
            {
                Console.WriteLine("********* Not found any record *******");
                return null;
            }
            return retList.ElementAt(0);
        }

        public IEnumerable<Employee> FindEmployeesByName(string name)
        {
            var retList = from mployee in this.list
                          where mployee.FirstName == name || mployee.LastName ==name
                          orderby mployee.FirstName ascending
                          select mployee;
            if (retList.Count() <= 0)
            {
                Console.WriteLine("********* Not found any record *******");
                return null;
            }
            Console.WriteLine("********* Employees *******");
            foreach (var mployee in retList)
                Console.WriteLine(mployee.Id + ": " + mployee.FirstName + " " + mployee.LastName);
            return retList.ToList();
        }

        public IEnumerable<Employee> FindEmployeesByStatus(bool status)
        {
            var retList = from mployee in this.list
                          where mployee.Status == status
                          orderby mployee.FirstName ascending
                          select mployee;
            if (retList.Count() <= 0)
            {
                Console.WriteLine("********* Not found any record *******");
                return null;
            }
            Console.WriteLine("********* Employees *******");
            foreach (var mployee in retList)
                Console.WriteLine(mployee.Id + ": " + mployee.FirstName + " " + mployee.LastName);
            return retList.ToList();
        }

        public IEnumerable<Employee> FindTopEmployeesBySalary(int size)
        {
            var retList = (from mployee in this.list
                          orderby mployee.Salary descending
                           orderby mployee.FirstName ascending
                           select mployee).Take(size);
            if (retList.Count() <= 0)
            {
                Console.WriteLine("********* Not found any record *******");
                return null;
            }
            Console.WriteLine("********* Employees *******");
            var count = 0;
            foreach (var mployee in retList)
            {
                count++;
                Console.WriteLine(count +". "+mployee.Id + ": " + mployee.FirstName + " " + mployee.LastName + " " + mployee.Salary);
            }
            return retList.ToList();
        }

        public List<Employee> ListEmployee()
        {
            var retList = from mployee in this.list
                          orderby mployee.FirstName ascending
                          select mployee;
            if (retList.Count() <= 0)
            {
                Console.WriteLine("********* Not found any record *******");
                return null;
            }
            Console.WriteLine("********* Employees *******");
            foreach (var mployee in retList)
                Console.WriteLine(mployee.Id +": "+ mployee.FirstName +" "+ mployee.LastName);
            return retList.ToList();
        }
    }
}
