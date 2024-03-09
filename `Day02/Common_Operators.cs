

namespace Introductio_To_CSharp._Day02
{
    class Common_Operators
    {
        static void Main()
        {
            // Assigment operators  -=
            // .....Arithmetic OPerators .....
            //... +,-,*,%,/

            //int Numerator = 10;
            //int denominator = 2;
            // int result = Numerator/denominator;
            // int result = Numerator % denominator;
            // Console.WriteLine("Result = {0}" , result);

            // ...........Conditional operators
            // ...&& . ||.....

            // Comparision operators
            // == , != , >, >= , <, <=
            /* int Number = 10;
             int Another_Number = 21;
             //if (Number ==10 && Another_Number ==20)
             if (Number ==10 || Another_Number ==20)
             {
                 Console.WriteLine("yes, condition is true");   
             }
             else
             {
                 Console.WriteLine("Wrong Condition");
             }*/

            // ... Ternary operators .. 

            int Value = 10;
            bool IsValue10 = Value == 10 ? true : false;

            /* if (Value==10)
            {
                IsValue10 = true;
            } else
            {
                IsValue10 = false;
            }*/
            Console.WriteLine("Number = 10 is {0}", IsValue10);
        }
    }
}