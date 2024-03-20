

namespace Introductio_To_CSharp.Day07
{
    class Do_While_Loop
    {
        static void Main()
        {
            string UserChoice = String.Empty;

            do
            {
                Console.WriteLine("Please Entered your Target Number");
                int UserTarget = int.Parse(Console.ReadLine());
                int start = 0;
                while (start <= UserTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine(" Do you want to continue -- Yes or No ?");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice Please select Yes or No ");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
            }

    }
}
