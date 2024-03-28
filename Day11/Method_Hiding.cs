

using System.Net.NetworkInformation;

namespace Introductio_To_CSharp.Day11
{
    
    public class Worker_Details
    {
        public string _FirstName;
        public string _LastName;
        public string _Title;

        public void PrintDetails()
        {
            Console.WriteLine("Name: {0} {1}" , _FirstName , _LastName);
            Console.WriteLine("Title: {0}", _Title);
        }
    }

    public class FullTimeWorker : Worker_Details
    {
       public double Monthly_Salary;

        public new void PrintDetails() // Hiding base class members
        {
            Console.WriteLine("FullTimeWorker Details is Here:");
            // base.PrintDetails(); // Again calling the Base class Method

            ((Worker_Details)this).PrintDetails(); //Using Type Cast to Base Class:
            Console.WriteLine("Monthly Salary = {0}" , Monthly_Salary);
        }

    }

    public class PartTimeWorker : Worker_Details
    {
        public double Hourly_Salary;

        public new void PrintDetails() // Hiding base class members using new keyword
        {
            Console.WriteLine("Part Time Worker Details is Here:");
            //base.PrintDetails(); // Again calling the base class methods

            // Using Type Cast to Base Class:
            ((Worker_Details)this).PrintDetails(); // Using Type Cast to Base Class:

            Console.WriteLine("Hourly Salary = {0}", Hourly_Salary);
        }
    }
    class Method_Hiding
    {
        static void Main()
        {
            FullTimeWorker fullTimeWorker = new FullTimeWorker();
            fullTimeWorker._FirstName = "Muhammad";
            fullTimeWorker._LastName = "Nauman";
            fullTimeWorker._Title = " Software Enginner";
            fullTimeWorker.Monthly_Salary = 620000;
            fullTimeWorker.PrintDetails(); 

            Console.WriteLine();

            PartTimeWorker partTimeWorker = new PartTimeWorker ();
            partTimeWorker._FirstName = "Muhammad";
            partTimeWorker._LastName = "Ali";
            partTimeWorker._Title = " Front End Developer ";
            partTimeWorker.Hourly_Salary = 32000;
           partTimeWorker.PrintDetails ();




        }
    }
}
