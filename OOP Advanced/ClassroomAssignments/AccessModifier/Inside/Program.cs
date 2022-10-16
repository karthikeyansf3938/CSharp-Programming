using System;
namespace Inside
{
    class Program
    {
        public static void Main(string[] args)
        {
            First one=new First();
            System.Console.WriteLine(one.publicNumber);
            System.Console.WriteLine(one.PrivateOutput);
            System.Console.WriteLine(one.InternalNumber);
            
            Second two=new Second();
            System.Console.WriteLine(two.ProtectedOutput1);

            System.Console.WriteLine(two.ProtectedInternalNumbers);
        }
    }
}