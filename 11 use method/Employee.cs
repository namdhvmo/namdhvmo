using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Employee
    {
        int id;
        string firstName;
        string lastName;
        string email;
        DateTime dateOfBirth;
        bool status;
        decimal salary;
        string level;
        string departmentName;

        public Employee(int id, string firstName, string lastName, string email, DateTime dateOfBirth, bool status, decimal salary, string level, string departmentName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.Status = status;
            this.Salary = salary;
            this.Level = level;
            this.DepartmentName = departmentName;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public bool Status { get => status; set => status = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public string Level { get => level; set => level = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }

      public string toString() {
            return this.id +": " +this.firstName +" "+ this.lastName;
        }
    }
}
