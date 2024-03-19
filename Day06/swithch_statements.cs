

namespace Introductio_To_CSharp.Day06
{
  class swithch_statements
    {
        static void Main()
        {
            Console.WriteLine("Please Entered the Number:");
            
            int UserNumber = int.Parse(Console.ReadLine());

            /*switch (UserNumber) {
                case 10:
                    Console.WriteLine("Your enterdthe number 10");
                    break;
                    case 20:
                    Console.WriteLine("Ypu Entered the Number 20");
                    break;  
                    case 30:
                    Console.WriteLine("Yopu Entered the Number 30");
                    break;

                    default:
                    Console.WriteLine("You not entered the 10, 20 & 30");
                    break;*/

            switch (UserNumber)
            {
                case 10:
                    
                case 20:
                   
                case 30:
                    Console.WriteLine("You Entered the Number {0}" , UserNumber);
                    break;

                default:
                    Console.WriteLine("You not entered the 10, 20 & 30");
                    break;
            }
        }
    }
}
