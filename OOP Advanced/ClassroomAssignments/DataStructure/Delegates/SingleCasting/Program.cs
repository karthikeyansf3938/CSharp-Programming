using System;
namespace SigleDelegates;

public delegate int Calculator(int n); //can add methods having int return typr & 1 int arg
class Program
{
    static int value=10;
    public static int AddNum(int number) //constructor
    {
        value += number;
        return value;
    }
    public static int MultNum(int number)
    {
        value *= number;
        return value;
    }
    public static int GetNum()
    { 
        return value;
    }
    public static void Main(string[] args)
    {
        //Create delegate Instance
        Calculator nc1 = new Calculator(AddNum);
        Calculator nc2 = new Calculator(MultNum);

        //calling methods using delegate objects
        nc1(25);
        Console.WriteLine($"Value of num : {GetNum()}");
        nc2(5);
        Console.WriteLine($"Value of num : {GetNum()}");

        
    }
}