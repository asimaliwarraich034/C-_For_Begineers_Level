

namespace Introductio_To_CSharp.Day20
{
    public class override_ToString_Method
    {
        public static void Main()

        {
            int Number = 11;
            Console.WriteLine(Number.ToString());
            person_info p1 = new person_info();
            p1.firstName = "Kamran";
            p1.lastName = "Akmal";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(Convert.ToString(p1));

        }
    }
    public class person_info
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            //return this.firstName + " " + this.lastName;
            return this.lastName + " " + this.firstName; 
        }

    }

}
