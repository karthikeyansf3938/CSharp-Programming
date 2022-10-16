using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x, y, z;
            for (x= 1; x <= 5; x++)
            {
                for (y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
                
    }
}