using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input : Strating number");
            int input1=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the difference:");
            int difference=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the number elements to display:");
            int number=int.Parse(Console.ReadLine());
            int s1=0,input2;
            s1=(number*(2*input1+(number-1)*difference))/2;
            input2=input1+(number-1)*difference;


            for(int i=input1;i<=input2;i=i+difference)
            {
                if(i!=input2)
                {
                    System.Console.WriteLine(i);
                }
                else{
                    System.Console.WriteLine("{0} = {1}",i,s1);
                }
            }
        }
    }
}