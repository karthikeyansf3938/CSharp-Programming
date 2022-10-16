using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int temp;
        System.Console.WriteLine("Enter the size of array");
        int size=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the elements to the array:");
        int[] elements=new int[10];
        for(int i=0;i<size;i++)
        {
            elements[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<size;i++)
        {
            for(int j=i+1;j<size;j++)
            {
                if(elements[j] < elements[i])
                {
                    temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = temp;
                }
            }
        }
    
            Console.Write("\nElements of array in sorted ascending order:\n");
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(" "+elements[i]);
            }
            System.Console.WriteLine("\n\n");

        
    }
}
        
    
