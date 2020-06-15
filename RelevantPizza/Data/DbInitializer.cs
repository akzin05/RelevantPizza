using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelevantPizza.Models;

namespace RelevantPizza.Data
{
    public class DbInitializer
    {
        public static void Initialize (PizzaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName="Jessee", LastName="Prescot", PhoneNumber="12345", Role=Roles.Manager,Salary=4000},
                new Employee{FirstName="Jim", LastName="Smith", PhoneNumber="12345", Role=Roles.AssitantManager,Salary=3500},
                new Employee{FirstName="Bob", LastName="Anderson", PhoneNumber="12345", Role=Roles.Cashier,Salary=30000}
            };

            context.Employees.AddRange(employees);
            //foreach(Employee employee in employees)
            //{
            //    context.Employees.Add(employee);
            //}
            //use Addrange instead of Add no need foreach

            context.SaveChanges();
        }
    }
}
