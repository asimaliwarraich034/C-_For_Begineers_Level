
using System.Security.Cryptography.X509Certificates;

namespace Introductio_To_CSharp.Day20
{
    public  class override_Equal_Method
    {
        public static void Main()
        {
            int i = 12;
            int j = 12;

            Console.WriteLine("Equality is = {0} " , i == j);
            Console.WriteLine("Equality is = {0} " , i.Equals(j));

            // direction direction1 = direction.east;
            //direction direction2 = direction.west;

            //Console.WriteLine(direction1==direction2);
            //Console.WriteLine(direction1.Equals(direction2));

            My_name my_Name = new My_name();
            my_Name.FirstName = "Asim";
            my_Name.LastName = "Ali";

            //My_name my_Name1 = my_Name;
            //Console.WriteLine(my_Name == my_Name1);

            My_name my_Name1 = new My_name();
            my_Name1.FirstName = "Asim";
            my_Name1.LastName = "Ali";
            Console.WriteLine(my_Name == my_Name1);
            Console.WriteLine(my_Name.Equals(my_Name1));// should be giving value equality 

            // to get what we expect thats why we use the Ovverride euall mrthod



            



        }
    }

    //public enum direction
    //{
    //    east = 1,
    //    west = 2,
    //    north = 3,
    //    south = 4
    //}
    public class My_name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is My_name)
            {
                return true;
            }

            return this.FirstName == ((My_name)obj).FirstName
                 && this.LastName == ((My_name)obj).LastName;
        
           
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();  
        }
    }

}
