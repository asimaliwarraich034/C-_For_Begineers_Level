

namespace Introductio_To_CSharp.Day12
{
    public class NewInternees
    {
        public string FirstName = "FN";
        public string LastName = "LN";


        public virtual void ShowInternneDetails()
        {
            Console.WriteLine("Name: {0} {1} ", FirstName, LastName);
            
        }
    }

    public class FullTimeInternee :NewInternees
    {
        public override void ShowInternneDetails()
        {
            Console.WriteLine( FirstName + " " + LastName + " " + " - Full Time Internee");

        }

    }
    public class PartTimeInternee : NewInternees
    {
        public override void ShowInternneDetails()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + " - PartTimeInternee");
        }
    }
    public class TemporarayInternee : NewInternees
    {
       // Base class virtual method is used 

    }

    internal class Polymorphism
    {
        static void Main()
        {
            NewInternees[] internees = new NewInternees[4];
            internees[0] = new NewInternees();
            internees[1] = new FullTimeInternee(); // base class reference variable can point to child class Object
            internees[2] = new PartTimeInternee();
            internees[3] = new TemporarayInternee();

            foreach (NewInternees item in internees)
            {
                item.ShowInternneDetails();
            }



        }

    }
}
