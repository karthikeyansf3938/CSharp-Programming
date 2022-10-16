using System;
namespace SelectionSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Input
            int[] SelectionSort=new int[]{18,19,1,5,7,3,20};

            int i,j,minindex,minvalue,temp=0;

            for(i=0;i<SelectionSort.Length;i++)
            {
                minvalue=SelectionSort[i];
                minindex=i;
                for(j=i;j<SelectionSort.Length;j++)
                if(SelectionSort[j]<minvalue)
                {
                    minvalue=SelectionSort[j];
                    minindex=j;
                }
                if(minvalue<SelectionSort[i])
                {
                    temp=SelectionSort[i];
                    SelectionSort[i]=SelectionSort[minindex];
                    SelectionSort[minindex]=temp;
                }
            }
            for(int k1=1;k1<SelectionSort.Length;k1++)
            {
                System.Console.Write(" "+SelectionSort[k1]);
            }
        }
    }
}
