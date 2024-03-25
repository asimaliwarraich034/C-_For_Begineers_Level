

namespace Introductio_To_CSharp.Day09
{
     class Methods_InCsharpp
    {
        /*static void Main()
        {
            Methods_InCsharpp m = new Methods_InCsharpp();
            m.EvenNumber();
        }

        public void EvenNumber()
        {
            int start = 0;
            while (start <= 10)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }*/

        /// <summary>
        ///  make the static methpds and use it 
        /// </summary>
        static void Main()
        {
            Methods_InCsharpp.EvenNumber(30);
            Methods_InCsharpp s = new Methods_InCsharpp();
            int sum = s.Add(10, 20);
            Console.WriteLine("The sum is = {0}" , sum);
        }

        public int Add(int fn , int sn)
        {
            return fn + sn;
        }

        public static void EvenNumber(int Target)
        {
            int start = 0;

            while (start <= Target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

    }
}
