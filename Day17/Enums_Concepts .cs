

namespace Introductio_To_CSharp.Day17
{
    public class Enums_Concepts
    {
        public static void Main()
        {
            // cannot implicit convert one type to another

           // Gender_type gender = (Gender_type)session.summer;
           
            // Gender_type gender = (Gender_type)1;
           // int Gender_num = (int)Gender_type.Unknown;

            // Strongly Constrant type

            short[] values = (short[])Enum.GetValues(typeof(Gender_type));
            foreach (short value in values)
            {
                Console.WriteLine(value);
            }
            string[] Names = (string[])Enum.GetNames(typeof(Gender));
            foreach (string  Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
public enum Gender_type : short
{
    Male =1,
    Female=5,
    Unknown=9
}
//an enum of one type cannot be implicitly assigned
//to an enum of another type 
//even though the underlying value of their members are the same.
public enum session
{
    winter = 1,
    summer = 5,
    Spring = 9
}