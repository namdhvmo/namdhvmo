using System;
using System.Collections.Generic;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Employee>()
            {
        new Employee(1,"dungnt","dungnt","dungnt",DateTime.Now,false,40000,"high","fpt"),
        new Employee(2,"dungnt1","dungnt","dungnt",DateTime.Now,false,20000,"high","fpt"),
        new Employee(3,"dungnt2","dungnt","dungnt",DateTime.Now,true,20000,"high","fpt"),
        new Employee(4,"dungnt3","dungnt","dungnt",DateTime.Now,true,60000,"medium","fpt"),
        new Employee(5,"dungnt4","dungnt","dungnt",DateTime.Now,false,20000,"low","fpt")
};
                EmployeeQueryRepository controller = new EmployeeQueryRepository(list);
            try
            {
                Console.WriteLine("*************** Assignment 11 - Employee Mângement **************");
                Console.WriteLine("1. Display All");
                Console.WriteLine("2. Search Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("Enter menu option number: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: controller.ListEmployee(); break;
                    case 2: new SearchControllerr().Controller(list);break;
                    case 3:
                        {
                            Console.WriteLine("Enter ID: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            controller.Delete(index);
                            break;
                        }
                                
                }
                Console.ReadLine();
            }catch(Exception)
            {
                Console.WriteLine("Have something wrong, reset program");
            }
        }


    }
}
