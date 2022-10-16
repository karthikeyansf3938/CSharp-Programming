using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int[ , ] value1=new int[2,2];
            int[ , ] matrix=new int[2,2];
            System.Console.WriteLine("Enter the elements:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    value1[i,j]=int.Parse(Console.ReadLine());  
                }
            }
            System.Console.WriteLine("The matrix is:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(value1[i,j]+" ");
                }
                System.Console.WriteLine();
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    matrix[j,i]=value1[i,j];
                }
            }
            System.Console.WriteLine("The transpose of the matrix is:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}