

namespace Introductio_To_CSharp.Day03
{
    class DataTypes_Conversion
    {
        static void Main()
        {
            // Implicit Conversion , int into float , done by compiler.
            // Because float data type is  much bigger thn int data type
            /*int i = 100;
            float b = i;
            Console.WriteLine(b);*/

            // ... Explicit converion

            /* float Float_value = 2345.43F;
          int num = (int)Float_value;
             //cannot convert implicitly float into int.  float is much bigger than int.
             //Fractional part will be missed . so Explicit conversion required.
             // cast operator use for explicit conversion. cast operator 
           // did not go through exception while convert class go throgh exception
           //int num  = Convert.ToUInt32(value);
             Console.WriteLine(num);*/

            // Another way to convert the data type into another format when there is dtat typr in string method 
            /*string String_Number = "100";
            int Integer_Number = int.Parse(String_Number); 
            // Parse() receives one string parameter to be converted to the desired data type.

            Console.WriteLine(String_Number);*/

            // .. Converting string into an integer and floating number 
            /* string var_string = "4.5";
         int integer_number = (int)(float.Parse(var_string) + 6);
             Console.WriteLine("The converted integer value is : {0} " , integer_number);
             float Floating_Number =  float.Parse(var_string) + 4.4f;
             Console.WriteLine("The converted Floating value is : {0} " , Floating_Number);*/

            string String_Number = "1000gf";
            int result = 0;
          bool ISConversionSuccessful=   int.TryParse(String_Number, out result);
            if (ISConversionSuccessful) {
             Console.WriteLine("The result is: {0}" , result);
            } else
            {
                Console.WriteLine(" Please Entered the valid number :");
            }
        }

    }
}

