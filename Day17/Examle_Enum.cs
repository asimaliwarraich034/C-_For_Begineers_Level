

namespace Introductio_To_CSharp.Day17
{
    public class Examle_Enum
    {
        public static void Main()
        {
            Customer_details[] customer1 = new Customer_details[3];
            customer1[0] = new Customer_details
            {
                Name = "Furqan",
                Gender = Gender.Male
            };
            customer1[1] = new Customer_details
            {
                Name = "Ayesha",
                Gender = Gender.unknown
            };
            customer1[2] = new Customer_details
            {
                Name = "Aasia",
                Gender = Gender.Female
            };
            foreach (Customer_details customer in customer1)
            {
                Console.WriteLine("name = {0} && Gender ={1}", customer.Name, getGender(customer.Gender));
            }

        }
               public static string getGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "Male";
                    case Gender.Female:
                    return "Female";
                case Gender.unknown:
                    return "Unknown";
                    default:
                    return "Invalid statement";
            }
        }
    }
}
public enum Gender
{
    unknown,
    Male,
    Female
}
public class Customer_details { 
    public string Name {  get; set; }
    public Gender Gender {  get; set; }
}