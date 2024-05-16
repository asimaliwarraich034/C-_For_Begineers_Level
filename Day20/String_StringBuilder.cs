

using System.Text;

namespace Introductio_To_CSharp.Day20
{
    public class String_StringBuilder
    {
        public static void Main() {

            //string Course_Content = "C# ";
            //Course_Content += "Video ";
            //Course_Content += "Tutorial ";
            //Course_Content += "For ";
            //Course_Content += "Begineers ";

            //Using String Builder

            StringBuilder  Course_Content = new StringBuilder ("C# ");
            Course_Content.Append("Video ");
            Course_Content.Append ("Tutorial ");
            Course_Content.Append  ("For ");
            Course_Content.Append  ("Begineers ");

            // Console.WriteLine(Course_Content); // For string 

            Console.WriteLine (Course_Content.ToString ()); // For String Builder 
            }
    }
}
