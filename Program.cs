using System;
using System.Collections.Generic;

namespace GenericsLabb4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                                        //ID   Name   Gender  Salary
            Employee e1 = new Employee(101, "Anas", "Male", 20000);
            Employee e2 = new Employee(102, "Hanna", "Female", 30000);
            Employee e3 = new Employee(103, "Tobias", "Male", 40000);
            Employee e4 = new Employee(104, "Sara", "Female", 40000);
            Employee e5 = new Employee(105, "Anna", "Female", 50000);

            Stack<Employee> EmployeeStack = new Stack<Employee>();
            EmployeeStack.Push(e1);
            EmployeeStack.Push(e2);
            EmployeeStack.Push(e3);
            EmployeeStack.Push(e4);
            EmployeeStack.Push(e5);


            foreach (Employee e in EmployeeStack)
            {                
                Console.WriteLine("{0} - {1} - {2} - {3}", e.ID, e.Name, e.Gender, e.Salary);
                Console.WriteLine("Items left in the stack: {0}", EmployeeStack.Count);
            }
            Console.WriteLine("---------------------------------");
            
            
            Console.WriteLine("Retrive Using Pop Method");
            while(EmployeeStack.Count > 0)
            {
                Employee E = EmployeeStack.Pop();
                Console.WriteLine("{0} - {1} - {2} - {3}", E.ID, E.Name, E.Gender, E.Salary);
                Console.WriteLine("Items left in the stack: {0}", EmployeeStack.Count);
            }
            EmployeeStack.Push(e1);
            EmployeeStack.Push(e2);
            EmployeeStack.Push(e3);
            EmployeeStack.Push(e4);
            EmployeeStack.Push(e5);

            Console.WriteLine("---------------------------------");
            
            
                Employee E1 = EmployeeStack.Peek();
                Console.WriteLine("{0} - {1} - {2} - {3}", E1.ID, E1.Name, E1.Gender, E1.Salary);
                Console.WriteLine("Items left in the stack: {0}", EmployeeStack.Count);
                Employee E2 = EmployeeStack.Peek();
                Console.WriteLine("{0} - {1} - {2} - {3}", E2.ID, E2.Name, E2.Gender, E2.Salary);
                Console.WriteLine("Items left in the stack: {0}", EmployeeStack.Count);
            Console.WriteLine("---------------------------------");

            if(EmployeeStack.Contains(e3))
            {
                Console.WriteLine("Emp3 is in stack.");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack.");
            }

            Console.WriteLine("\n---------------------------------\n");

            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(e1);
            EmployeeList.Add(e2);
            EmployeeList.Add(e3);
            EmployeeList.Add(e4);
            EmployeeList.Add(e5);

            bool Emp2 = EmployeeList.Contains(e2);
            if(Emp2 == true)
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 does not exist in the list.");
            }
            
            Employee firstMale = EmployeeList.Find(Employee => Employee.Gender == "Male");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}\n", firstMale.ID, firstMale.Name, firstMale.Gender, firstMale.Salary);

            List<Employee> AllMale = EmployeeList.FindAll(Employee => Employee.Gender == "Male");
            foreach (Employee AM in AllMale)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", AM.ID, AM.Name, AM.Gender, AM.Salary);
            }
        }
    }
}
