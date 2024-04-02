

namespace Introductio_To_CSharp.Day13
{
    interface IMyIntro
    {
        void print();
    }
    interface IMyIntro2
    {
        void print();
    }
    public class Explicit_Interface_Implimentation : IMyIntro, IMyIntro2
    {
        // Explicit Interface Method
       void IMyIntro.print()
        {
            Console.WriteLine("My name is Asim Ali");
        }

        //  IMyIntro2 Default interface method
        public void print()
        {
            Console.WriteLine("My name is Hashim Ali");
        }
        public static void Main()
        {
            Explicit_Interface_Implimentation M1 = new Explicit_Interface_Implimentation(); 
            //((IMyIntro)M1).print(); Typecaset
            //((IMyIntro2)M1).print();    

            IMyIntro I1 = new Explicit_Interface_Implimentation();
            IMyIntro2 I2 = new Explicit_Interface_Implimentation();
            

            I1.print();
            I2.print();
        }
    }
}
