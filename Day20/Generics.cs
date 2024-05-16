

namespace Introductio_To_CSharp.Day20
{
    public class Generics
    {
        public static void Main()
        {
            //  bool Equal = Calculator1.AreEuqal("A", "A"); // obect use case 
           // bool Equal = Calculator1.AreEuqal<int>(11, 11); // Method generics
            
            bool Equal =  Calculator1<int>.AreEuqal(11, 11); // Class Generics Logic 
            if (Equal)
            {
                Console.WriteLine("Equal");
            } else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
public class Calculator1<T> // Make class generics instead of Method 
{
    // Method Tightly coupled on the data types on which it operates 
    // public static bool AreEqual(int val1, int val2)

    // Another way to make method operate on any data type

    //public static bool AreEuqal(object val1, object val2)

    // .net every type is directly and indirectly inherit from system.object
    // Issue -> Int= Structure or value type and Object -> Class or reference type
    // Converting value type to Reference Type is Boxing
    // Boxing -> Lost strongly typed And also performance degraded 

    // -> Best way to make method independent of data type is generics
    // and you can reuse your code, stronlgy typed and avoid boxing and unboxing
    public static bool AreEuqal ( T val1,  T val2)


    {
        //return val1 == val2; // Object use case
        return val1.Equals(val2);
    }

}