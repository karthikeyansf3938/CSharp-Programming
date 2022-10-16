using System;
namespace BinarySearch
{
    class Program
    {
        public static void Main(string[] args)
        {

            char[] numbers=new Char[]{'a','e','i','o','u'};

            //Sort array
            Array.Sort(numbers);
            //printing sorted array
            for(int i=0;i<numbers.Length;i++)
            {
                System.Console.Write(" "+numbers[i]);
            }

            //To search
            System.Console.WriteLine("\nEnter the character to find : ");
            char search=char.Parse(Console.ReadLine());

            //binary search
            int beg=0,end=numbers.Length-1;
            int mid;
            bool check=false;
            while(beg<=end)
            {
                mid=(beg+end)/2;
                if(numbers[mid]==search)
                {
                    System.Console.WriteLine($"Search character {search} is found in the position {mid}");
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
                System.Console.WriteLine("Character is not found in tha array");
            }
        }
    }
}