using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class EmployeeMethodRepository : IEmployeeRepository
    {
        List<Employee> list;

        public EmployeeMethodRepository(List<Employee> list)
        {
            this.list = list;
        }

        public bool Delete(int id)
        {
            var retList = this.list.Where(e => e.Id == id).FirstOrDefault();
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
            var retList = this.list.Where(e => e.Id == id).FirstOrDefault();
            if (retList==null)
            {
                Console.WriteLine("********* Not found any record *******");
                return false;
            }
                Console.WriteLine("********* Employee existed *******");
            var employee = retList;
                Console.WriteLine(employee.Id + ": " + employee.FirstName + " " + employee.LastName);
                return true;
            
        }

        public Employee FindEmployeeById(int id)
        {
            var retList = this.list.Where(e => e.Id == id).OrderBy(e => e.FirstName);
            if (retList.Count() <= 0)
            {
                Console.WriteLine("********* Not found any record *******");
                return null;
            }
            return retList.ElementAt(0);
        }

        public IEnumerable<Employee> FindEmployeesByName(string name)
        {
            var retList = this.list.Where(e => e.FirstName == name || e.LastName == name).OrderBy(e => e.FirstName);
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
            var retList = this.list.Where(e => e.Status == status).OrderBy(e => e.FirstName);
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
            var retList = this.list.OrderBy(e => e.Salary).Reverse().Take(size);
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
            var retList = this.list.OrderBy(e => e.FirstName);
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
