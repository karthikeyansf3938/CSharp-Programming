using System;
namespace LinearSearch2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int flag=0;
            System.Console.WriteLine("Enter the character find");
            char find=char.Parse(Console.ReadLine());

            char[] vowels=new char[]{'a','e','i','o','u'};

            for(int i=0;i<vowels.Length;i++)
            {
                if(find==vowels[i])
                    flag=1;
            }
            if(flag==0)
            {
                System.Console.WriteLine("Character is not found in the array");
            }
            else
            {
                System.Console.WriteLine("Character is found in the array");
            }
        }
    }
}