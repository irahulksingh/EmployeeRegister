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

            do
            {
                Console.Write("Name: ");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                Console.Write("Salary :");
                var salary = Console.ReadLine();

                var salaryInt = int.Parse(salary);
                var employee = new Employee(name);
                employee.Salary = salaryInt;


                registry.Add(employee);
            } while (true);

    {

                registry.List();

            }



            



        }




    }
}
