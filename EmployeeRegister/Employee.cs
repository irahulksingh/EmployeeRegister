using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    class Employee
    {

        public Employee(string name)
        {
            Name = name;
        }
        public string Name{ get; set; }
        public int  Salary { get; set; }

        public override string ToString()
        {
            var s = "Name: " + Name + "Salary :"+ Salary;
            return s;
        }

    }
}
