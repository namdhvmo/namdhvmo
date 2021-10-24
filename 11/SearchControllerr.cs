using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class SearchControllerr
    {
        public int menu()
        {
            Console.WriteLine("*************** Search Employeee - Employee Management **************");
            Console.WriteLine("1. Search by Id");
            Console.WriteLine("2. Search by Name");
            Console.WriteLine("3. Search status");
            Console.WriteLine("4. Search top employee by salary");
            Console.WriteLine("5. Check if employee existed");
            Console.WriteLine("Enter menu option number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void Controller(List<Employee> list)
        {
            EmployeeQueryRepository controller = new EmployeeQueryRepository(list);
            int choice = this.menu();
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter ID: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        var retEmployee = controller.FindEmployeeById(index);
                        Console.WriteLine("********* Employee *******");
                        Console.WriteLine(retEmployee.toString());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter name: ");
                        string name = Console.ReadLine();
                        controller.FindEmployeesByName(name); 
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter status (0 or 1): ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        bool status = number == 0 ? false : true; 
                        controller.FindEmployeesByStatus(status);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter number of record: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        controller.FindTopEmployeesBySalary(index);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter ID: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        var retEmployee = controller.Exist(index);
                        break;
                    }
            }
            }
        }
    }
