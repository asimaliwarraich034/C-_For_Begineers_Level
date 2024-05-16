using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introductio_To_CSharp.Day20
{
    public class Convert_ToString_ToString
    {
        public static  void Main()
        {
            // New_name n1 = new New_name();
            New_name n1 = null;
            //string str  = n1.ToString();

            // string str = Convert.ToString(n1); // Handalled Null excption and print empty string 

           // string str = n1.ToString(); // Null Exception Thrown 

            // when pass null object to this To string Convert class'
            // it convert to the empty string 

            // On the otyher hand when used Null Object with To string
            // // we cannot create instance and Null exception Thrown 
            Console.WriteLine(str);
        }
    }

    public class New_name
    { public string Name { get; set; } }
}
