using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Male: Person
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Male(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public int BornAndExist()
        {
            Console.WriteLine("Name: " + Name);
            return Salary;
        }
    }
}
