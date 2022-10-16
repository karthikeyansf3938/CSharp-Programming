using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[ , ] value1=new int[2,3];
            int[ , ] value2=new int[3,2];
            int[ , ] value3=new int[2,2];
        

            System.Console.WriteLine("Enter the elements to matrix1:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    value1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("First Matrix:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    System.Console.Write(value1[i,j]+" ");
                }
                Console.WriteLine();
            }
            System.Console.WriteLine("Enter the elements to second matrix:");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<2;j++)
                {
                    value2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Second Matrix:");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(value2[i,j]+" ");
                }
                Console.WriteLine();
            }
            
            System.Console.WriteLine("Multiplication:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    value3[i,j]=0;
                    for(int k=0;k<3;k++)
                    {
                        value3[i,j]+=value1[i,k]*value2[k,j];
                    }
                }
            }
            for(int i=0;i<=1;i++)
            {
                for(int j=0;j<=1;j++)
                {
                    {
                        System.Console.Write(value3[i,j]+" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}