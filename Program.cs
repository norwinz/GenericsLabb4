using System;
using System.Collections.Generic;

namespace GenericsLabb4
{
    class Program
    {
        static void Main(string[] args)
        {                             //ID   NAME   GENDER  SALARY
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
        
        }
    }
}
