

namespace Introductio_To_CSharp.Day16
{
    public class Abuse_ExcetionHandling
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please Enter the Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter the Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int Result = Numerator / Denominator;

                Console.WriteLine("Result = {0}", Result);
            }


            catch (FormatException)
            {
                Console.WriteLine("Please enter the number");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Number only between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }

    }
}
