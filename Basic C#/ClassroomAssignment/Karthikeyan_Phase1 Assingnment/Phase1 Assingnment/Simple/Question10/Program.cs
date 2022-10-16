using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a character");
            char chars=Char.Parse(Console.ReadLine());
            if(chars== 'a'||chars== 'e' || chars== 'i' ||chars=='o' || chars=='u')
            {
                System.Console.WriteLine("It's a vowel");
            }
            else
            {
                System.Console.WriteLine("It's not a vcowel");
            }
        }
    }
}
