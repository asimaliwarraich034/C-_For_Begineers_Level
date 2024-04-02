

namespace Introductio_To_CSharp.Day13
{
    public abstract class Person_Details
    {
        //public abstract void print();

        //Abstract class may contain abstracty members
        //(methods, properites,indexes and event, etc)but not mendatory
          
         public void print()
        {
            Console.WriteLine("Hello");
        }
    }
    public   class   Abstract_Classes  : Person_Details    {
      // public  void print()
        //{
            
        //}
        public static void Main()
        {
            // Parent class refence variable can point
            // to the derived class object 

            //Person_Details P1 = new Abstract_Classes(); 
            //P1.print(); 

            // Craete instance of class 

            Abstract_Classes P2 = new Abstract_Classes();
            P2.print();


        }
    }
}

