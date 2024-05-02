

using System.Security.Cryptography.X509Certificates;

namespace Introductio_To_CSharp.Day18
{
    public class Type_VS_TypeMembers
    {
        public static void Main()
        {
            New_Customer_Details customer3 = new New_Customer_Details();
            // settimg properties

            customer3.Id = 1;
            customer3.FirstName = "ali";
            customer3.LastName = "hassan";
            // Accessing properties

            Console.WriteLine("Customer  ID: " + customer3.Id);
            Console.WriteLine("Customer Full Name:" + customer3.GetFullName());
        }
    }
}

public class New_Customer_Details
{
    // fields 
    #region fields
    private int _id;
    private string _firstName;
    private string _lastName;
    #endregion

    #region properties
    public int Id
    { 
        get { return _id; }
    set { _id = value;}
    }
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }   
        set { _lastName = value; }
    }
    #endregion

    #region Methods
    public string GetFullName()
    {
        return this._firstName + " " + this._lastName;
    }
    #endregion
}