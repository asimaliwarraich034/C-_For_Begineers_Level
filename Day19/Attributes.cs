using System;
using System.Collections.Generic;


namespace Introductio_To_CSharp.Day19
{
    public class Attributes
    {
        public static void Main()
        {
            //Console.WriteLine(Calculator.Add(12, 12));
            Console.WriteLine(Calculator.Add(new List<int>() { 12, 12,10,44 }));
        }
    }
}

public class Calculator
{
    [Obsolete ("Use Add(List<int> Numbers) Methods")]
    public static int Add(int FirstNum, int SecondNum)
    {
        return FirstNum + SecondNum;
    }

    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }

}