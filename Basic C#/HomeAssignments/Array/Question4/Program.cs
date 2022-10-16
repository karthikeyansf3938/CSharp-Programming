using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] elements=new int[10];
            System.Console.WriteLine("Enter the input to store the elements in array:");
            int input=int.Parse(Console.ReadLine());

            System.Console.WriteLine(("Enter the elements:"));
            

            for(int i=0;i<input;i++)
            {
                elements[i]=int.Parse(Console.ReadLine());
            }
          
            int max=elements[0];
            int min=elements[0];
            {
                
                for(int j=0;j<input;j++)
                {
                    if(elements[j]>max)
                    {
                        max=elements[j];
                    }
                    if(elements[j]<min)
                    {
                        min=elements[j];
                    }

                }Console.WriteLine($"Minimum element: {+min} \n Maximum element:{+max}");
            }
        }
    }
}