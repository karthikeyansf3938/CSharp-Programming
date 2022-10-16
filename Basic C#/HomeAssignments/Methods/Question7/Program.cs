using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a String:");
            string input=Console.ReadLine();
            input=Convert.ToString(Console.ReadLine());
            Palindrome(input);
            string Palindrome(int x)
            {
                string reminder=string.Empty;
                int sum=0;
                sum=Convert.ToInt32(Console.ReadLine());
                int temp=sum;
                string length=string.Empty;
                bool flag=true;
                for(int i=0;i<length/2;i++)
                {
                    reminder=x%10;
                    sum=(sum*10)+reminder;
                    x=x/10;
                    {
                        flag=false;
                        break;
                    }
                }
                if(flag==true)
                {
                    Console.Write("String is not a palindrome ");
                }
                else
                {
                    Console.Write("String is a palindrome");
                }
                return sum;
            }
        }
    }
}