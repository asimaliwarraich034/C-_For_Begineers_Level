

using System.Diagnostics.Contracts;

namespace Introductio_To_CSharp.Day17
{
    public class Enums_Demo
    {
        public static void Main()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Asim",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "aleena",
                Gender = 0
            };
            customers[2] = new Customer
            {
                Name = "katreena",
                Gender = 2
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name ={0} && Gender ={1}", customer.Name, GetGender(customer.Gender));
            }
            
        }
         public static string GetGender (int gender)
        {
            switch(gender)
            {
                case 0:
                    return "unknown";
                case 1:
                    return "Male";
                    case 2:
                    return "Female";
                default:
                    return "unknown data detected";
                  
            }
        }
    }
}
public class Customer
{
  public string Name { get; set; }
    public int Gender { get; set; }
}