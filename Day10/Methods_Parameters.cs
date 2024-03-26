


namespace Introductio_To_CSharp.Day10
{
    class Methods_Parameters
    {
        // .... Pass by value ....

       /* static void Main()
        {

             int i = 0;
              SimpleMethod(i);
              Console.WriteLine(i);



          }

          public static void SimpleMethod(int j) {
              j = 101;

           
          } */
       // ..... Pass by Reference 
       /* static void Main()
        {
            int i = 0;
            SimpleFn(ref i);
            Console.WriteLine(i);
        }

        public static void SimpleFn(ref int r)
        {
             r = 102;
        }*/

        // Out Parameter 
        // You want method to return more than one value 
         /* static void Main()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10,20, out Total, out Product);

            Console.WriteLine("Sum = {0} , && Product ={1}" , Total , Product);
        }
            public static void Calculate(int fb ,int rb , out int Total, out int Product)
        {
            Total = fb + rb;
            Product = fb* rb;
        }*/

        static void Main()
        {
            int[] Numbers = new int[3];
            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;
            //  ParamsMethod();
            // ParamsMethod(Numbers);
            ParamsMethod(1, 2, 3, 5);
        }

        public static void ParamsMethod(params int[] Numbers )
        {
            Console.WriteLine("There are {0} element " , Numbers.Length);
        foreach( int i in Numbers )
            {
                Console.WriteLine(i);
            }
        }

        }
    }