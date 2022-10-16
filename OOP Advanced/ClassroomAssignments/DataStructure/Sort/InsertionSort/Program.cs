using System;
namespace InsertionSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Input
            int[] InsertionSort=new int[]{18,19,1,5,7,3,20};

            int i,j,key,temp=0;

            for(i=1;i<InsertionSort.Length;i++)
            {
                key=InsertionSort[i];
                j=i-1;
                if(j>=0 && key<InsertionSort[j])
                {
                    temp=InsertionSort[j];
                    InsertionSort[j]=InsertionSort[j+1];
                    InsertionSort[j+1]=temp;

                    j--;

                }
            }
            for(int k1=1;k1<InsertionSort.Length;k1++)
            {
                System.Console.Write(" "+InsertionSort[k1]);
            }
        }
    }
}
