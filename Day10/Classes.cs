

namespace Introductio_To_CSharp.Day10
{


    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer()
        :this("No FirstName Provide" , "No LastName provise")
        {
        }
        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }
        ~Customer()
        {
            //Clean up the code
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name is = {0}", this._firstName + " " + this._lastName);
        }
    }



    class Classes
    {
        static void Main()
        {
            //Customer c2 = new Customer("Asim", "Ali");
            Customer c2 = new Customer(); // Parameters less customer 
            c2.PrintFullName();
            // OverLoad Constructor ( With the number and type Parameters) 
            Customer c3 = new Customer("Hashim", "Ali");
            c3.PrintFullName(); 
        }

    }

}