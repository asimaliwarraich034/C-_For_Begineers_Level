

namespace Introductio_To_CSharp.Day01
{
    class Reading_and_Writing_ToConsole
    {
        static void Main()
        {
            Console.WriteLine("Please Enter your First Name");
            string First_Name = Console.ReadLine();

            Console.WriteLine("Please Enter your Last Name");
            string Last_Name = Console.ReadLine();
            Console.WriteLine("Helo {0} {1} ", First_Name, Last_Name);
            // Console.WriteLine("Hello " + UserName);
        }
    }
}