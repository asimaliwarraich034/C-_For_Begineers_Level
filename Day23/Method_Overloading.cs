using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introductio_To_CSharp.Day23
{
    public  class Method_Overloading
    {
        public static void Main()
        {
             AddNumbers(12, 10 );
            AddNumbers(10, 10, new int[] {30,50});
        }

        public static void AddNumbers(int FirstNumber, int SecondNumber)

        {
            AddNumbers(FirstNumber, SecondNumber, null);

            // Use Empty Array Instead of null to make it Nullable
           // AddNumbers(FirstNumber, SecondNumber, new int[0]);
        }
        // Allow null values for the restofNumber parameter by making it nullable.
        public static void AddNumbers(int FirstNumber, int SecondNumber, int[]? restofNumber) 

        {
            int result = FirstNumber + SecondNumber;
            if (restofNumber !=null)
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
