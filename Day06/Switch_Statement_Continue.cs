

namespace Introductio_To_CSharp.Day06
{
    class Switch_Statement_Continue
    {
        static void Main()
        {
            int Total_CofeCost = 0;
        start:
            Console.WriteLine("Welcome to the Cofee shop:");
            Console.WriteLine("Select your cofee:");
            Console.WriteLine("1- Fresh Juice ($1):");
            Console.WriteLine("2- Cold Drink ($2):");
            Console.WriteLine("3- Bakery food ($3):");
            Console.WriteLine("Enter Your Choice (1-3):");
       

            int UserChoice = int.Parse(Console.ReadLine());
            
            switch (UserChoice) {
            case 1:
            Total_CofeCost += 1;
            break;
            case 2: 
            Total_CofeCost += 2;
            break;
            case 3:
            Total_CofeCost += 3;
             break;

            default:
                    Console.WriteLine("Not valid choice entered");
                   goto start;
            }
            Decide:
            Console.WriteLine(" Do You want to Buy Another Cofee - Yes or No ?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto start;

                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice isnot valid {0} , " , UserDecision);
                    goto Decide;
            }


            Console.WriteLine("Thank you for Purchasing");
            Console.WriteLine("Total Bill Amount is  $ {0} ,", Total_CofeCost);
        }
    }
}
