

namespace Introductio_To_CSharp._Day02
{
    class string_DataType
    {
        static void Main()
        {
            // string name = "\"Asim Ali\"";
            string name = "Asim\nAli\nwarraich\n";
            string address = "Sheikh pur Gujrat";
            string project_path = @"D:\\C# Internship\\C# rogramming\\c#Begineers leval";
            Console.WriteLine(name);
            Console.WriteLine("Home Adress is this {0}:", address);
            Console.WriteLine(project_path);
        }

    }

}