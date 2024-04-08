using System;
using System.Collections.Generic;

namespace Introductio_To_CSharp.Day15
{
    class Employee
    {

        // Our class is not reusable we hard coded the logic
        // //to expreince only  for promoted 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5 )
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }

    }
    public class Demo_Delegates_Usage
    {  
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Id = 102, Name = "Asim Ali ", Salary = 50000, Experience = 6 });
            emplist.Add(new Employee { Id = 111, Name = "Kashif Ali ", Salary = 70000, Experience = 2 });
            emplist.Add(new Employee { Id = 109, Name = "Farhan Ali ", Salary = 80000, Experience = 3 });
            emplist.Add(new Employee { Id = 104, Name = "Imran Ali ", Salary = 60000, Experience = 7 });
            emplist.Add(new Employee { Id = 105, Name = "Qasim Ali ", Salary = 25000, Experience = 4 });
        

            Employee.PromoteEmployee(emplist);
        }
    }
}
