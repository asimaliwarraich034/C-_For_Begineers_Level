using System;
using System.Collections.Generic;

namespace Introduction_To_CSharp.Day15
{
    // Define the delegate
    delegate bool IsPromotable(Employee employee);

    public class Continue_Delegates
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Id = 102, Name = "Asim Ali ", Salary = 50000, Experience = 6 });
            emplist.Add(new Employee { Id = 111, Name = "Kashif Ali ", Salary = 70000, Experience = 2 });
            emplist.Add(new Employee { Id = 109, Name = "Farhan Ali ", Salary = 80000, Experience = 3 });
            emplist.Add(new Employee { Id = 104, Name = "Imran Ali ", Salary = 60000, Experience = 7 });
            emplist.Add(new Employee { Id = 105, Name = "Qasim Ali ", Salary = 25000, Experience = 5 });

            // Create an instance of the delegate
            IsPromotable isPromotable = new IsPromotable(IsEligibleForPromotion);

            // Call the PromoteEmployee method with the delegate
            Employee.PromoteEmployee(emplist, isPromotable);
        }

        // Define a method to check if an employee is eligible for promotion
        static bool IsEligibleForPromotion(Employee employee)
        {
            return employee.Experience >= 5;
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        // Modify PromoteEmployee to accept the delegate
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isPromotable)
        {
            foreach (Employee employee in employeeList)
            {
                if (isPromotable(employee))
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
