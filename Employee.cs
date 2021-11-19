using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLabb4
{
    public class Employee
    {
        public int ID;
        public string Name;
        public string Gender;
        public int Salary;

        public Employee(int id, string name, string gender, int salary)
            {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
            this.Salary = salary;
            }
    }
}
