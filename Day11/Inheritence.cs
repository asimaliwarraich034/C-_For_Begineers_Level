using System;

namespace Introductio_To_CSharp.Day11
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Title;

        public void PrintEmployeeDetails()
        {

            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("Title: " + Title);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        public new void PrintEmployeeDetails() // Using "new" to hide the base class method
        {
            Console.WriteLine("Full Time Employee Details");
            base.PrintEmployeeDetails(); // Calling the base class method to print its details
            Console.WriteLine("Yearly Salary: " + YearlySalary);
        }
    }
    public class PartTimeEmloyee : Employee
    {
        public float HourlySalary;

        public new void PrintEmployeeDetails()
        {
            Console.WriteLine("Part Time Employee Details");
            base.PrintEmployeeDetails();
            Console.WriteLine("Hourly Salary:" + HourlySalary);
        }

    }

    public class AnotherPartTimeEmployee : PartTimeEmloyee // MultiLevel Inheritence 
    {
        public new void PrintEmployeeDetails()
        {
            Console.WriteLine("Another  Part Time Employee Details");
            base.PrintEmployeeDetails();
            //Console.WriteLine("Hourly Salary:" + HourlySalary);
        }

    }

    public class Inheritance
    {
        static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Asim";
            FTE.LastName = "ALI";
            FTE.Title = "Manager";
            FTE.YearlySalary = 50000;
            FTE.PrintEmployeeDetails();

            Console.WriteLine(); // Adding space between outPuts of both Employee

            PartTimeEmloyee PTE = new PartTimeEmloyee();
            PTE.FirstName = "Arslan Ali";
            PTE.LastName = " Mehar";
            PTE.Title = "Front End Developer";
            PTE.HourlySalary = 35000;
            PTE.PrintEmployeeDetails();

            Console.WriteLine();

            AnotherPartTimeEmployee p2 = new AnotherPartTimeEmployee();
            p2.FirstName = "Ahmad";
            p2.LastName = " Raza ";
            p2.Title = "Backend Developer ";
            p2.HourlySalary = 40000;
            p2.PrintEmployeeDetails();

        }
    }
}
