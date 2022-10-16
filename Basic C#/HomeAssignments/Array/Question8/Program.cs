using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            int[ , ] value1=new int[2,2];
            int[ , ] value2=new int[2,2];
            System.Console.WriteLine("Enter the elements to first matrix:");
            
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    value1[i,j]=int.Parse(Console.ReadLine());
                    
                }
            }
            System.Console.WriteLine("The first matrix is:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(value1[i,j]+" ");
                }
                
                Console.WriteLine();
            }
            System.Console.WriteLine("Enter the elements to second matrix:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    value2[i,j]=int.Parse(Console.ReadLine());
                    
                }
            }
            System.Console.WriteLine("The second matrix is:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(value2[i,j]+" ");
                }
                
                Console.WriteLine();
            }
            System.Console.WriteLine("The addition of two matrix is:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(value1[i,j]+value2[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}