using System;
namespace DoWhile;

class Program
{
    public static void Main(string[] args)
    {   
        int no;
        string condition="";
        do
        {
            System.Console.WriteLine("Input");
            no=Convert.ToInt32(Console.ReadLine());
            if(no%2==0)
            {
                System.Console.WriteLine("Even number");
            }
            else
            {
                System.Console.WriteLine("Odd number");
            }
            System.Console.WriteLine("If you want to continue again press yes/no");
            condition=Console.ReadLine().ToLower();
            if(condition != "yes" && condition!="no")
            {
                System.Console.WriteLine("Your input is wrong. Please enter valid input:");
                condition=Console.ReadLine().ToLower();

            }
        }while(condition=="yes");
    }
}