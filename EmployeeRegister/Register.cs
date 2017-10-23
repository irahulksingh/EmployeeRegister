using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    class Register
    {

        private List<Employee> list = new List<Employee>();



        public void Add(Employee employee)
        {
            list.Add(employee);
        }

        public void List()
        {
            //throw new NotImplementedException();
            foreach(var employee in list)
            {
                Console.WriteLine("Name: " + employee.Name);
                Console.WriteLine("Salary: " + employee.Salary);
                Console.WriteLine(); ;

            }
        }
    }
}
