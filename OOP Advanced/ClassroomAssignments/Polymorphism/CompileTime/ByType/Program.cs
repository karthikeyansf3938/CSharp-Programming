using System;
namespace ByType;
class Program
{
    //Method with int parameter
    static void Display(int number)
    {
        System.Console.WriteLine("Number : "+number);
    }
    //Method with string parameter
    static void Display(string name)
    {
        System.Console.WriteLine("\n\nString type : "+name);
    }
    public static void Main(string[] args)
    {
        Display(10);
        Display("karthi");//console understand the types(datatypes)
    }
}