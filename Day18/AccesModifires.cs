

using System.Security.Cryptography;

namespace Introductio_To_CSharp.Day18
{
    public class AccesModifires
    {
        public static void Main()
        {
           // Accessibility of public Access modifiers
            //Customer_Info c2 = new Customer_Info();
            //Console.WriteLine(c2.Id);
        }
    }
}
 

public class Customer_Info
{
    // Public and protected Access modifiers

    //private int _id;
    // public int Id { get { return _id; } set { _id = value; } }

    // Protected Access modifiers

    protected int ID;
}
public class Coperate_Customer : Customer_Info
{
    
    public void PrintId() {
       Coperate_Customer CC2 = new Coperate_Customer(); 
        CC2.ID = 101;
        // Also acces by base or this keyword
        base.ID = CC2.ID;
        this.ID = CC2.ID;
    }
}
