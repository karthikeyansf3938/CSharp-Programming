using System;
namespace Question1;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Hello:Your name is:"+name);

            Console.WriteLine("Hello:Your name is:{0}",name);
        
            Console.WriteLine($"Hello:Your name is: {name}");
    }
    }