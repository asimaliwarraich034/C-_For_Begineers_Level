

namespace Introductio_To_CSharp.Day14
{
   public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A class Implementation");
        }
    }

    public class    B : A
    {
        public override void Print()
        {
            Console.WriteLine("B class Implementation");
        }
    }

    public class C : A
     {
        public override void Print()
        {
            Console.WriteLine(" C class Implementation");
        }
    }

    // C# No support multile class Inheritence 
    /*public class D :B, C
    {
        
    }*/
    public  class Problems_MultipleClass_Inheritence
    {
        public static void Main()
        {
            //D d1 = new D();
            //d1.Print();


        }
    }
}
