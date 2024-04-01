

namespace Introductio_To_CSharp.Day13
{
    // public struct Customer_Detail
    //Use sealed keyword to prevent classes to being inherited from another class
    public sealed class Customer_Detail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ~Customer_Detail() { 
        
        }

        // Structs can't have parameter less constructor
        public Customer_Detail()
        {

        }
    }
     class Diffe_Classes_Structure
    {
        public static void Main()
        {
            /*int i =0;
             //System.Int32  i = 0;
             if (i == 0)
             {
                 int j = 20;
                 Customer_Detail C1 = new Customer_Detail();
                 C1.Id = 101;
                 C1.Name = "Warraich";*/

            

            int i = 10;
            int j = i;
            j = j + 1;
            // a new copy of that struc gets created and modification on one struct
            // will not affect the values contained by the other struct.
            Console.WriteLine("Vale of i = {0} && value of j = {1} " , i, j);
            
            Customer_Detail C3 = new Customer_Detail();
            C3.Id = 102;
            C3.Name = "ALI AKBAR";

            // cretaed a copy of reference variable
            // operation on one variable  will affect the value contained by the other reference variable.
            Customer_Detail C4 = C3;
            C4.Id = 101;
            C4.Name = "Hisham Sarwar";

            Console.WriteLine("C3.ID = {0} && C3.NAME = {1}", C3.Id, C3.Name);
        }
        }
    }
