using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            int[ , ] value1=new int[3,3];
            System.Console.WriteLine("Enter the elements:");
            
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    value1[i,j]=int.Parse(Console.ReadLine());
                    
                    
                }
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    System.Console.Write(value1[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}