using System;
namespace BinarySearch
{
    class Program
    {
        public static void Main(string[] args)
        {

            string[] employeeid=new string[]{"sf3005","sf3004","sf3003","sf3009","sf3001"};

            //Sort array
            Array.Sort(employeeid);
            //printing sorted array
            for(int i=0;i<employeeid.Length;i++)
            {
                System.Console.Write(" "+employeeid[i]);
            }

            //To search
            System.Console.WriteLine("\nEnter the string to find : ");
            string search=Console.ReadLine();

            //binary search
            int beg=0,end=employeeid.Length-1;
            int mid;
            bool check=false;
            while(beg<=end)
            {
                mid=(beg+end)/2;
                int temp=employeeid[mid].CompareTo(search);
                if(employeeid[mid]==search)
                {
                    System.Console.WriteLine($"Search string {search} is found in the position {mid}");
                    check=true;
                    break;
                }
                else if (temp<0)
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