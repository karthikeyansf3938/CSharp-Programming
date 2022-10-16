using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int input,digit,temp;
        System.Console.WriteLine("Enter the input number");
        input=int.Parse(Console.ReadLine());
        double sum=0;
        
        for(temp=input;input!=0;input=input/10)
        {
            digit=input%10;
            sum=sum+(digit*digit*digit);
        }
        if(sum==temp)
        {
            System.Console.WriteLine($"{+input} is an armstrong number",temp);
        }
        else
        {
            System.Console.WriteLine($"{+input} is not an armstrong number",temp);
        }
    }
}
