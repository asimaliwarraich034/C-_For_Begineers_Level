using System;
using System.Reflection;

namespace Introductio_To_CSharp.Day19
{
    public class Reflection_Basic
    {
        public static void Main()
        {
            // i) Static method of reflaction

            //Type t = Type.GetType("Introductio_To_CSharp.Day19.Customer_information");

          // ii) 
          
            //Type t =  typeof(Customer_information);

            // All obects have get type method which will inherit from 
            // base system object class

            Customer_information c1= new Customer_information();
             Type t = c1.GetType();

            Console.WriteLine("Full Name: " + t.FullName);
            Console.WriteLine("Name: " + t.Name);
            Console.WriteLine("Namespace: " + t.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties in Customer_information class");
            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " = " + property.Name);
            }
            Console.WriteLine() ;
            Console.WriteLine("Methods in Customer_information class");
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+ " = " + method.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Contruuctor in Customer_information class");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }

    }



    // Customer_information class definition remains unchanged
    public class Customer_information
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer_information(int ID, string Name)
        {
            this.Name = Name;
            this.Id = ID;
        }

        public Customer_information()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine($"{this.Id}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{this.Name}");
        }
    }
}