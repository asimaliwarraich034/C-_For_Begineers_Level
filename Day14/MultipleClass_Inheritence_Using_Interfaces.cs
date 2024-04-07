

namespace Introductio_To_CSharp.Day14
{
    interface IA
    {
        void AMethod();
    }
    class Ai : IA
    {
        public void AMethod()
        {
            Console.WriteLine("AMethod is called");
        }
    }

    interface IB
    {
        void BMethod();
    }
    class Bi : IB
    {
        public void BMethod()
        {
            Console.WriteLine("BMethod is called");
        }
    }
    class AB : IA, IB
    {
        Ai a = new Ai();
        Bi b = new Bi();
        public void AMethod()
        {
            a.AMethod(); // Call the AMethod implementation from class A
        }
        public void BMethod()
        {
            b.BMethod(); // Call the BMethod implementation from class B
        }
    }
    public class MultipleClass_Inheritence_Using_Interfaces
    {
        public static void Main()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
