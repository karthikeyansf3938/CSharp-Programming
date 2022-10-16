using System;
namespace BinarySearch
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] numbers=new int[]{10,78,7,45,33,79,27};

            //Sort array
            Array.Sort(numbers);
            //printing sorted array
            for(int i=0;i<numbers.Length;i++)
            {
                System.Console.Write(" "+numbers[i]);
            }

            //To search
            System.Console.WriteLine("\nEnter the integer to find : ");
            int search=int.Parse(Console.ReadLine());

            //binary search
            int beg=0,end=numbers.Length-1;
            int mid;
            bool check=false;
            while(beg<=end)
            {
                mid=(beg+end)/2;
                if(numbers[mid]==search)
                {
                    System.Console.WriteLine($"Search element {search} is found in the position {mid}");
                    check=true;
                    break;
                }
                else if(numbers[mid]<search)
                {
                    beg=mid+1;
                }
                else 
                {
                    end=mid-1;
                }   
            }
            if(!check)
            {
                System.Console.WriteLine("Not found in tha array");
            }
        }
    }
}