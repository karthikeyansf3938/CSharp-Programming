using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Original input:");
            string string1=Console.ReadLine();
            int length=string1.Length;
            string result="";
            for(int i=0;i<length;i++)
            {
                if(!result.Contains(string1[i]))
                {
                    result=result+string1[i];
                }
            }
            Console.Write(result);
        }
    }
}
