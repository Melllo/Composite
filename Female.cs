using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Female : Person
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Female(string name, int salary) {
            Name = name;
            Salary = salary;
        }
        public int BornAndExist()
        {
            Console.WriteLine("Name: "+Name);
            return Salary;
        }
    }
}
