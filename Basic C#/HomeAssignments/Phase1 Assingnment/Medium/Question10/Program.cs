using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, j,n=6,m=20;
            for (i = 1; i <= n; i++)
            {
            for (j = 1; j <= m; j++)
            {
                if (i == 1 || i == n ||
                    j == 1 || j == m)           
                Console.Write("*");           
                else
                Console.Write(" ");           
            }
            Console.WriteLine();
            }
        }
    }
}
