

namespace Introductio_To_CSharp.Day12
{
     class Method_Ovverloading
    {
        public static void Main()
        {
            int sum;
            Add(12, 22 , out  sum);
            Add(10, 23 ,5);
            
        }

        // Ovverloaded on basis of Kind of Parameters
        // Ovverloaded on basis of Number of Parameters
        //Ovverloaded on basis of Types of Parameters
        public static void Add(int FN , int SN ,out int sum)
        {
            sum = FN + SN ;
        }

        public static void Add(int FN, int SN, int Ln)
        {
            Console.WriteLine("Sum = {0}", FN + SN + Ln);
        }

        /*public static void Add(int FN, int SN, out int sum)
        {
            sum = FN + SN;
        }

        public static void Add(int FN, int SN, float Ln)
        {
            Console.WriteLine("Sum = {0}", FN + SN + Ln );
        }

        // Not possible to ovverload a method based on Paramas keywords
        public static void Add(int FN, int SN, params int [] Ln)
        {
            Console.WriteLine("Sum = {0}", FN + SN );
        }
        public static void Add(int FN, int SN, int[] Ln)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        //Not possible to ovverload a method based on Return Type
        public static void Add(int FN, int SN, float Ln)
        {
            Console.WriteLine("Sum = {0}", FN + SN + Ln);
        }
        public static int  Add(int FN, int SN, float Ln)
        {
            Console.WriteLine("Sum = {0}", FN + SN + Ln);
        }*/
    }
} 
