using System;
using System.Collections.Generic;

namespace list_employees_working_at_a_company
{
    public class Company {
        public DateTime Founded { get; set; }
        public string Name { get; set; }
        public List <Employee> EmployeeList = new List<Employee>();
        public void AddEmployee(Employee employee){
            EmployeeList.Add(employee);
        }
        public Company (string name, DateTime founded){
            Name = name;
            Founded = founded;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee steve = new Employee ("Steve", "Lastly", "Cook", DateTime.Now);
            Employee jon = new Employee ("jon", "nancy", "cleaner", DateTime.Now);
            Employee bill = new Employee ("bill", "idk", "idk", DateTime.Now);

            Company mcdonalds = new Company("mcdonalds", DateTime.Now);
            mcdonalds.EmployeeList.Add(steve);
            mcdonalds.EmployeeList.Add(jon);
            mcdonalds.EmployeeList.Add(bill);

            foreach (Employee emp in mcdonalds.EmployeeList){
                Console.WriteLine($"{emp.FirstName} works for {mcdonalds.Name}, as {emp.Title} since {emp.StartDate}");
            }

            // steve works for acme, inc. as title since 1999
        }
    }
}
