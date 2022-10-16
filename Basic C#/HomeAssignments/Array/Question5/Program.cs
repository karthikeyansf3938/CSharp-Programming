using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int flag=0;
        int[] elements=new int[10];

        System.Console.WriteLine("Enter the length of the array");
        int length=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the elements:");

        for(int i=0;i<length;i++)
        {
            elements[i]=int.Parse(Console.ReadLine());
        }
        for(int j=0;j<length;j++)
        {
            if(elements[j]%2==0)
            {
                flag=1;
            }
            if(elements[j]%2!=0)
            {
                flag=0;
            }
            if(flag=1)
            {
            System.Console.WriteLine("The even elements are:"+elements[j]);
            }
            else{
                System.Console.WriteLine("The odd elements are:"+elements[j]);
            }
            
        }

    }
}