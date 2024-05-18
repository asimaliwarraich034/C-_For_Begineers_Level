using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introductio_To_CSharp.Day23
{
    public  class SpecifyingParameter_Default
    {
        public static void Main()
        {
            AddNumbers(50, 10); // optional parameter
            AddNumbers(10,10, new int[] { 1, 2, 3 });   
        }
        public static void AddNumbers(int firstNumber, int secondNumber, int [] ? restofNumber = null)
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
