using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introductio_To_CSharp.Day23
{
    public  class Parameter_Array
    {
       
        public static void Main()
        {
            //AddNumbers(12, 12, new object[] { 10, 10, 12 });
            AddNumbers(12, 12);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restofNumber)
        {
            int result = firstNumber + secondNumber;

            if (restofNumber != null)
            {
                foreach (int i in restofNumber)
                {
                    result += i;
                }

            }
            Console.WriteLine("Result = {0}", result);

        }
    }
}
