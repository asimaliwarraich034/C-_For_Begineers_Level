using Introductio_To_CSharp.Day14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Introductio_To_CSharp.Day15
{
    // This delegates now point to a functions which has similar syntax
    public delegate void HelloFunctionDelegate(string message);
    public class Delegates
    {
        public static void Heloo(string newMessage)
        {
            Console.WriteLine(newMessage);
        }
        public static void Main()
        {
            // A delegate is a type safe function pointer

            // ...   Create the delegate instance 

            HelloFunctionDelegate D1 = new HelloFunctionDelegate(Heloo);
            D1("Heloo Asim Ali");

            //Without instance of delgate invoke the function which has similar syntax to delegate

            //Heloo("Heloo Asim Bro");
        }
    }
}
