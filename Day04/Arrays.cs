

namespace Introductio_To_CSharp.Day04
{
     class Arrays
    {
        static void Main()
        {
            /*int[] EvenNumbers = { 2, 4, 6, 8, 10, 12, 14 };
            Console.WriteLine("Elemnet at Index 2 is: {0} " ,EvenNumbers[2]);*/

            // Array cannot grow in size once  initialized
            string[] Friend_List = new string [3];
            Friend_List[0] = "Ahmed Raza";
            Friend_List[1] = "Asif Ali";
            Friend_List[2] = "Muhhamd Sheraz";
            Console.WriteLine(Friend_List[1]);
        }
        
    }
}
