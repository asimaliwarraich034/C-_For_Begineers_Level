

namespace Introductio_To_CSharp.Day11
{
    public class ParentClass
    {
        // OverLoad constructor Concept
        public ParentClass()
        {
            Console.WriteLine(" Parent class Constructor Called");
        }
        public ParentClass(string message) { 
        Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived Class Controlling Base class") 
        {
            Console.WriteLine("Child Class Constructor Called");
        }
    }
    class ParentClass_ChildClass_Constructor
    {
        public static void Main()
        {
            ChildClass cc = new ChildClass();

        }
    }
}
