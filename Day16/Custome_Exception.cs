using System;
using System.IO;
using System.Runtime.Serialization;

namespace Introductio_To_CSharp.Day16
{
    
    public  class Custome_Exception
    {
        public static void Main()
        {
            try { 


            throw new UseralreadyLoggedInException("User already logged-in -> No dupplicate session");
        } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    [Serializable]
    public class  UseralreadyLoggedInException: Exception 
    
    {
        public UseralreadyLoggedInException() :base()  // overload constructor 
        { 
        
        }
        public UseralreadyLoggedInException(string message) : base(message) 
        {
        
        }

        public UseralreadyLoggedInException(string message, Exception innerException)
          : base(message, innerException)
        {
        }
       public UseralreadyLoggedInException(SerializationInfo info, StreamingContext context)    
            :base(info,context)
        {

        }

    }
}
