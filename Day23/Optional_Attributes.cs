using System.Runtime.InteropServices;

namespace Introductio_To_CSharp.Day23
{
    public  class Optional_Attributes
    {
         public static void Main()
        {
            AddNumbers(12, 90); // this is optional parameter
        }

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int [] restofNumber) // optonal attribue
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
