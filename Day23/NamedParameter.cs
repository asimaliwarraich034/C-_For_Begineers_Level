using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introductio_To_CSharp.Day23
{
    public class NamedParameter
    { 
        public static void Main()
        {
            ShowMethod(1,b:12,c:10);
        }
        public static void ShowMethod(int a, int b=3, int c= 2)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " +c );
        }
    }
}
