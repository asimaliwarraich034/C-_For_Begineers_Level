using System.IO;

namespace Introductio_To_CSharp.Day16
{
    public class ExceptionHandling
    {
        public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader  = new StreamReader(@"U:\Data Folder2\data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exsist", ex.FileName);
            }
            catch (Exception ex) {
                Console.Write(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }
            
        }
    }
}
