using System;
using System.Reflection;

namespace Introductio_To_CSharp.Day19
{
    public class LateBinding_Reflection
    {
        public static void Main()
        {
            // Get the executing assembly
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            // Get the type of the new customer
            Type customerType = executingAssembly.GetType("Introductio_To_CSharp.Day19.Customer");

            // Create an instance of the customer
            object customerInstance = Activator.CreateInstance(customerType);

            // Get the method info for the GetFullName method
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            // Invoke the GetFullName method with parameters
            string[] parameters = new string[] { "John", "Doe" };
            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            // Print the full name
            Console.WriteLine("Full Name: {0}", fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
