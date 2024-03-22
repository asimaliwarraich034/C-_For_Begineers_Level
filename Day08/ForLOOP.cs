

namespace Introductio_To_CSharp.Day08
{
    class ForLOOP
    {
        static void Main()
        {
            /*int[] Numbers = new int[3];
            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }*/

            /* for (int j = 0; j < Numbers.Length; j++)
             {
                 Console.WriteLine(Numbers[j]);   
             }
             int i = 0;
             while (i < Numbers.Length)
             {
                 Console.WriteLine(Numbers[i]);
                 i++;
             }*/

            // -------------- Use of Break statement ------

            /* for (int i = 0; i <=20; i++)
             {
                 Console.WriteLine(i);

                 if (i == 10)
                 {
                     break;
                 }
             }*/

            // ------------  Contune keyword use case ------------
            // 
            for (int j = 0; j <= 20;  j++)
            {
                if (j%2==1)
                {
                    continue;
                }
                Console.WriteLine(j);
            }
        }
    }
}
