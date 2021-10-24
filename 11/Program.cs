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
    new Employee(1,"dungnt","dungnt","dungnt",DateTime.Now,false,400001,"high","fpt"),
        new Employee(2,"dungnt1","dungnt","dungnt",DateTime.Now,false,200002,"high","fpt"),
        new Employee(3,"dungnt2","dungnt","dungnt",DateTime.Now,true,200003,"high","fpt"),
        new Employee(4,"dungnt3","dungnt","dungnt",DateTime.Now,true,600004,"medium","fpt"),
        new Employee(5,"dungnt4","dungnt","dungnt",DateTime.Now,false,200005,"low","fpt"),
         new Employee(6,"dungnt6","dungnt","dungnt",DateTime.Now,false,400006,"high","fpt"),
        new Employee(7,"dungnt7","dungnt","dungnt",DateTime.Now,false,200007,"high","fpt"),
        new Employee(8,"dungnt8","dungnt","dungnt",DateTime.Now,true,200008,"high","fpt"),
        new Employee(9,"dungnt9","dungnt","dungnt",DateTime.Now,true,600009,"medium","fpt"),
        new Employee(10,"dungnt10","dungnt","dungnt",DateTime.Now,false,200009,"low","fpt"),
         new Employee(11,"dungn11","dungnt","dungnt",DateTime.Now,false,400008,"high","fpt"),
        new Employee(12,"dungnt12","dungnt","dungnt",DateTime.Now,false,200007,"high","fpt"),
        new Employee(13,"dungnt13","dungnt","dungnt",DateTime.Now,true,200006,"high","fpt"),
        new Employee(14,"dungnt14","dungnt","dungnt",DateTime.Now,true,600005,"medium","fpt"),
        new Employee(15,"dungnt15","dungnt","dungnt",DateTime.Now,false,200004,"low","fpt"),
         new Employee(16,"dungn16","dungnt","dungnt",DateTime.Now,false,400003,"high","fpt"),
        new Employee(17,"dungnt17","dungnt","dungnt",DateTime.Now,false,200002,"high","fpt"),
        new Employee(18,"dungnt18","dungnt","dungnt",DateTime.Now,true,200001,"high","fpt"),
        new Employee(19,"dungnt19","dungnt","dungnt",DateTime.Now,true,600006,"medium","fpt"),
        new Employee(20,"dungnt20","dungnt","dungnt",DateTime.Now,false,200004,"low","fpt"),
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
