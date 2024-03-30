

namespace Introductio_To_CSharp.Day12
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Method");
        }
    }

    public class DerivedClass: BaseClass
    {
        // ....... Method Ovverriding  ..........
       // public override void Print() 

        //........... Method Hiding ---------
        public new void Print()

        {
            Console.WriteLine("I am a Derived Class Method");
        }
    }
    class MethodOverrideing_MethodHiding
    {
       public static void Main()
        {
            BaseClass BF = new DerivedClass();
            BF.Print();
        }
    }
}
