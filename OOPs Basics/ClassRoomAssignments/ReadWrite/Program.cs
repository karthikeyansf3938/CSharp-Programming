using System;

namespace ReadWrite;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your Father name");
        string fname = Console.ReadLine();

        Console.WriteLine("Your name is:"+name +"Your Father name is:"+fname);

        Console.WriteLine("Your name is:{0} Your Father name is:{1}",name,fname);
        
         Console.WriteLine($"Your name is: {name} Your Father name is: {fname}");
    }
}

