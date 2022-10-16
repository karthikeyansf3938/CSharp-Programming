using System;
namespace BubbleSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Input
            int[] bubbleSort=new int[]{18,19,1,5,7,3,20};

            int temp=0;

            //Bubble Sort
            for(int i=0;i<bubbleSort.Length-1;i++)
            {
                for(int j=0;j<bubbleSort.Length-1-i;j++)
                {
                    if(bubbleSort[j]>bubbleSort[j+1])
                    {
                        temp=bubbleSort[j];
                        bubbleSort[j]=bubbleSort[j+1];
                        bubbleSort[j+1]=temp;
                    } 
                }
            }
            for(int i=0;i<bubbleSort.Length-1;i++)
            {
                System.Console.Write(" "+bubbleSort[i]);
            }
        }
    }
}