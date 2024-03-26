//using.ProectA.TeamA
//using ProectA.TeamB  // Using Directives

using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace Introductio_To_CSharp.Day10
{
     class Namespace
    {
        static void Main()
        {
            Console.WriteLine("Hello");

            //ProjectA.TeamA.ClassA.Print(); // Fully Qualified 
           PATA.ClassA.Print();
            PATB.ClassA.Print();
        }
        

    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print Method");
            }
        }
    }
}
namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print Method");
            }
        }
    }
}