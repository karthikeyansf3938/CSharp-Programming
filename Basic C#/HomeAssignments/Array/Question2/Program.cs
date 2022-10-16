using System;
namespace Question2;

    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input :");
            int input=int.Parse(Console.ReadLine());
            
            int[] elements=new int[3];
            System.Console.WriteLine("The values are into the array are :");
            for(int i=0;i<input;i++)
            {
                elements[i]=int.Parse(Console.ReadLine());
            }
            for(int j=0;j<input;j++)
            {
                System.Console.Write(" "+elements[j]);
            }
            System.Console.WriteLine("\nThe values store into the array in reverse are : ");
            for(int k=input-1;k>=0;k--)
            {
                Console.Write(" "+elements[k]);
            }
            
        }
    }
