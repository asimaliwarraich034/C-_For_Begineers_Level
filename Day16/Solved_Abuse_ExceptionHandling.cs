

namespace Introductio_To_CSharp.Day16
{
    public class Solved_Abuse_ExceptionHandling
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please Enter the Numerator");

                int Numerator;
                bool ISNumeratorConversionSuccesful = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (ISNumeratorConversionSuccesful)
                {
                    Console.WriteLine("Please Enter the Denominator");
                    int Denominator;
                    bool ISDenominatorConversionSuccesful = Int32.TryParse(Console.ReadLine(), out Denominator);

                    if (ISDenominatorConversionSuccesful && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;

                        Console.WriteLine("Result = {0}", Result);
                    }

                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator sholud be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Numerator sholud be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            
        }
    }
}
