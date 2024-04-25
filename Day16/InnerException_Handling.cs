
using System.IO;

namespace Introductio_To_CSharp.Day16
{
    public class InnerException_Handling
    {
        public static void Main()
        {
             try { 
            try
            {
                Console.WriteLine("Enter First Name");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Name");
                int SN = Convert.ToInt32(Console.ReadLine());
                int Result = FN / SN;
                Console.WriteLine("Result = {0}", Result);
            }
            catch (Exception ex)
            {

                string filePath = @"M:\Data Folder\log_data.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter stw = new StreamWriter(filePath);
                    stw.WriteLine(ex.Message);
                    stw.WriteLine();
                    stw.Write(ex.GetType().Name);
                    stw.Close();
                    Console.WriteLine("There is a problem, please try later ");
                }
                else
                {
                  // Always check if inner excetion is not null before
                  // accessing any property of the inner exception object
                  // else , you may get Null Reference exception
                  // throw new FileNotFoundException(filePath + " is not Presenet",ex); // include inner excetion
                        throw new FileNotFoundException(filePath + " is not Presenet");
                    }

            }
        } 
            catch (Exception exception)
            {
                Console.WriteLine ("Current Exception = {0}" , exception.GetType().Name);
               
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Excetion = {0}", exception.InnerException.GetType().Name);
                }
               
            }
        }
    }
}
