using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int total=0;
        System.Console.WriteLine("Enter the input to elements to store in the array");
        int input=int.Parse(Console.ReadLine());

        int[] element=new int[10];
        System.Console.WriteLine("Enter the elemetns");
        for(int i=0;i<input;i++)
        {
           element[i]=int.Parse(Console.ReadLine());
        }
        for(int j=0;j<input;j++)
        {
            System.Console.WriteLine(" "+element[j]);
        }
        for(int k=0;k<input;k++)
        {
            total+=element[k];
            
        }
    System.Console.WriteLine(" Sum of all elements stored in the array is :"+total);
    }
}