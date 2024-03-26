

namespace Introductio_To_CSharp.Day10
{ 
    class Circle
{
   static float _P1;
    int _Radius;
        static Circle()
        {
            Console.WriteLine("Static Constructor called");
            Circle._P1 = 3.14F;
        }

    public Circle(int radius)
           
    {
            Console.WriteLine("Instance Constructor called");

            this._Radius = radius;   
    }

    public float   CalcArea()
    {
       return _P1 * this._Radius * this._Radius;
    }
}


    class Static_Instance_ClassMembers
    {
        static void Main()
        {
        Circle c1 = new Circle(4);
       float Area =  c1.CalcArea();
        Console.WriteLine("Area of A Circle = {0} " , Area);
            Circle c2 = new Circle(5);
            float Area2 = c2.CalcArea();
            Console.WriteLine("Area of A Circle = {0} ", Area2);
        }
    }
}
