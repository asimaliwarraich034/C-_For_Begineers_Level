

using System.Drawing;

namespace Introductio_To_CSharp.Day13
{
    // Declaration of Interfaces by the naming convention

    interface ICustomer
    {
        //int ID; Interface cannot have fields

        // Only declaration not implementatation
        // Interface members public by default 
        void print1();
        
    }
    interface ICustomer2 : ICustomer
    {
        void PrintMethod2();
    }


    // A class can  inherit from more than one interface 
   public class New_Customer : ICustomer2
    {
        // If inherit calss from interface provide the implementation
        public void print1()
        {
            Console.WriteLine("Interface  I customer Print method called");
        }

        public void PrintMethod2()
        {
            Console.WriteLine("Interface ICustomer2 Print method called");
        }
    }

    
  public  class Interfaces 
    {
        public static void Main()
        {
            /*New_Customer C4 = new New_Customer();  
           C4.print1();
           C4.PrintMethod2();*/

            // Cannot create an interface object but but an interface varaibale
            // //can point to a derived class object.

            ICustomer Cus1 = new New_Customer();
            Cus1.print1();
            ICustomer2 Cus2 = new New_Customer();
            Cus2.PrintMethod2();
        }
    }
}
