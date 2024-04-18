



using System.Security.Cryptography.X509Certificates;

namespace Introductio_To_CSharp.Day15
{
    //public delegate void simpleDelegate(); 
    //public delegate int simpleDelegate(); // Int return type
    public delegate void simpleDelegate(out int Integer); // Out paramete delgate
    public class Multicast_Delegates
    {
        // public static void Main()
        //{
        // simpleDelegate del = new simpleDelegate(simpleMethod);
        //del.Invoke();

        //  convert delegate into multicast delegates
        //   i) create several instances of delegates

        /*simpleDelegate del1, del2, del3, del4;
        del1 = new simpleDelegate(simpleMethodOne);
        del2 = new simpleDelegate(simpleMethodTwo);
        del3 = new simpleDelegate(simpleMethodTHREE);

        // del4 = del1 + del2 +del3;
        //del4();

        // Remove delegate 2 from the list use (-) Sign 
     del4 = del1 + del2 +del3 - del2;
        del4();*/

        //ii) use same instance and register multiple Function,
        // Then use += symbol

        /* simpleDelegate del = new simpleDelegate(simpleMethodOne);
         del += simpleMethodTwo;
         del += simpleMethodTHREE;
         del -= simpleMethodOne; // remove method 
         del();

     }*/
        // Function has same signiture as of delegates
        /*public static void simpleMethodOne() {

            Console.WriteLine("Simple Method One is invoked");
        }
        public static void simpleMethodTwo()
        {

            Console.WriteLine("Simple Method Two is invoked");
        }
        public static void simpleMethodTHREE()
        {

            Console.WriteLine("Simple Method Three is invoked");
        }*/

        // If function return some value then thedelagtes have 
        // same signiture as of functions

        /*public static void Main()
        {
            simpleDelegate del2 = new simpleDelegate(simpleMethodOne);
            del2 += simpleMethodTwo;
            int DelegatesReturnedValue = del2(); // Call the delegate to get the return value

            Console.WriteLine("DelegatesReturnedValue = {0}", DelegatesReturnedValue);

             static int simpleMethodOne()
            {
                return 1;
            }

             static int simpleMethodTwo()
            {
                return 2;
            }
        }*/

        public static void Main()
        {
            simpleDelegate del2 = new simpleDelegate(simpleMethodOne);
            del2 += simpleMethodTwo;
            int DelegatesOutPrameter = -1; // Call the delegate to get the return value
            del2(out DelegatesOutPrameter);
            Console.WriteLine("DelegatesOutPrameter Value = {0}", DelegatesOutPrameter);

           static void simpleMethodOne(out int Number)
            {
                Number = 1;
            }

            static void simpleMethodTwo(out int Number)
            {
                Number = 3;
            }
        }

    }

}
