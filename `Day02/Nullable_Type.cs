

namespace Introductio_To_CSharp._Day02
{
    class Nullabale_Type_Csharp
    {
        static void Main()
        {
            // Reference type can have null value , but by default value type is non nullabale 
            // int i = null;
            // string num = null;  

            // How to store Null value in a Value Type in C#. To make Nullable use  ?

            // bool ? AreyouMajor = null;
            bool? AreyouMajor = true;
            if (AreyouMajor == true)
            {
                Console.WriteLine("User is a Major");
            }
            else if (AreyouMajor == false)
            {
                Console.WriteLine("User is not a Major");
            }
            else
            {
                Console.WriteLine("User Did not select any Option");
            }
        }
    }
}
