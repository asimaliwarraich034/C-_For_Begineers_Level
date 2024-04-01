

namespace Introductio_To_CSharp.Day13
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine(" Customer ID = {0} && Name = {1}", this._id, this._name);
        }
    }
        class Strructs_IN_CSharp
        {
            public static void Main()
        {
            Customer C1 = new Customer(1, "Asim Ali");
            C1.PrintDetails();

            Customer c2 = new Customer();
            c2.ID = 12;
            c2.Name = "Hashim Ali";
            c2.PrintDetails();

            // IObect Initializer
            Customer c3 = new Customer
            {
                ID = 13,
                Name = "Imran Malik"
              
            };
            c3.PrintDetails();
        }
        }
    }

