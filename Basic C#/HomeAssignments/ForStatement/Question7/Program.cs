using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {   
        int x,y,z;
        for(x=1;x<=5;x++)
        {
            for(y=1;y<=5;y++)
            {
                for(z=1;z<(x*2);z++)
                {
                System.Console.Write("*");
                }

            }
            System.Console.WriteLine();

        }System.Console.WriteLine();
    }
}
