using System;
namespace LinearSearch
{
    class Program
    {
        public static void Main(string[] args)
        {
            int flag = 0;
            System.Console.WriteLine("Enter the number to find:");
            int find=int.Parse(Console.ReadLine());
            int[] numbers = new int[]{1,2,3,4,5,6,7,8,9};
            for(int i=0;i<numbers.Length;i++)
            {
                if(numbers[i]==find)
                    flag=1;
            }
            if(flag==0)
            {
                System.Console.WriteLine("The number is not found in the array");
            }
            else
            {
                System.Console.WriteLine("The number is present in the array ");
            }
            
        }
    }
}