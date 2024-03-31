using System;

namespace Introduction_To_CSharp.Day12
{
    public class StudentDetails
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        private string _email;
        private string _city;
        private string _country;

        // Auto Complete Properties
        public string Email
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }

        // Pass Mark is read-only, and its value is returned directly.
        public int PassMark
        {
            get
            {
                return _passMark;
            }
        }

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id cannot be negative");
                }
                this._id = value;
            }
        }

        public string Name
        {
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be Null or empty");
                }
                this._name = value;
            }
        }
    }

    class ReadWritePropertiesAutoComplete
    {
        public static void Main()
        {
            StudentDetails s2 = new StudentDetails();
            s2.Id = 11;
            s2.Name = "Asim Ali warraich ";
            s2.Email = "asimwarraich222@gmail.com";
            s2.City = "Gujrat";
            s2.Country = "Pakistan";
            Console.WriteLine("Student ID = {0} ", s2.Id);
            Console.WriteLine("Student Name = {0}", s2.Name);
            Console.WriteLine("Student Marks = {0} ", s2.PassMark);
            Console.WriteLine("Email = {0}" , s2.Email);
            Console.WriteLine("City = {0}", s2.City);
            Console.WriteLine("Country = {0}", s2.Country);
        }
    }
}
