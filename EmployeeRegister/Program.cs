using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            //var e = new Employee("Jonny");
            //e.Salary = 25000;

            //var e1 = new Employee("Taleb");
            //    e1.Salary = 35000;
            ////Console.WriteLine("Name: "+e.Name);
            //Console.WriteLine("Salary: "+ e.Salary);

            var registry = new Register();
            var added = true;

            do
            {
                added = AddEmployee(registry);

            } while (added);

            Console.WriteLine("================");
            registry.List();



        }

        private static bool AddEmployee(Register Registry)

        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(name)) return false
                    ;

            Console.Write("Salary :");
            string salaryStr = Console.ReadLine();

            int salaryInt = 0;
            if (!int.TryParse(salaryStr, out salaryInt))
            {

                Console.WriteLine("Salary coudn't be parsed");
            }
            var employee = new Employee(name);
            employee.Salary = salaryInt;
            Registry.Add(employee);

            return true;

        }
    }
}
