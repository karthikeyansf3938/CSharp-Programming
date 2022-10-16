using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string");
            string string1=Console.ReadLine();
            int alphabetcount=0;
            int numberscount=0;
            int charcount=0;
            foreach(char i in string1)
            {
                if((i>=32 && i<=47) || (i>=58 && i<=64) ||(i>=91 && i<=96) ||(i>=123 && i<=126))
                {
                    charcount++;
                }
                if((i>=48 && i<=57))
                {
                    numberscount++;
                }
                if((i>=65 && i<=90)||(i>=97 && i<=122))
                {
                    alphabetcount++;
                }
            }System.Console.WriteLine($"Alaphebet count:{+alphabetcount}\n Numbers count:{+numberscount}\n Character count:{+charcount}");
        }
    }
}