namespace Introductio_To_CSharp.Day07
{
    class While_Loop
    {
        static void Main()
        {
            Console.WriteLine("Please Entered the  Traget Number");
            int UserTraget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= UserTraget)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
        }
    }
}
