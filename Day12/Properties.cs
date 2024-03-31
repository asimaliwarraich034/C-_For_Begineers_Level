

namespace Introductio_To_CSharp.Day12
{
    // ............  Problem with public field:..................

    /* public class Student
     {
         public int ID;
         public string Name;
         public int PassMark = 34;
     }
     internal class Properties
     {
         public static void Main()
         {
             Student s = new Student();
             s.ID = -10;
             s.Name = null;
             s.PassMark = 0;
             Console.WriteLine("ID = {0}, &  NAME = {1} , & PassMark = {2} ",
                 s.ID , s.Name , s.PassMark);
         }
     }*/

    //    .... Getter and Setter Methods Protecting these fields Now ......


    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public int GetpassMark()
        {
            return _passMark;
        }

        // Setter Methods for giving id

        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student id cannot be negative");
            }
            this._id = id;
        }
        public int GetId()
        {
            return this._id;

        }

        // Setter Methoid for Name

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception(" Name cannot be Null or empty");
            }
            this._name = Name;  
        }
        public string GetName()
        {
            // Turny oerator 
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            /*if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }*/
        }
    }
     class Properties
    {
        public static void Main()
        {
            Student s = new Student();
            // s.SetId(-1); // Unhandaled Excetion : Id cannot be nagative
            s.SetId(1);
            s.SetName("Asim Ali");
            s.GetpassMark();
            
            Console.WriteLine("Student ID = {0} ", s.GetId());
            Console.WriteLine(" Student Name = {0}" , s.GetName());
            Console.WriteLine(" Student Marks = {0} " , s.GetpassMark());
        } 

    }

}
