using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {   
            System.Console.WriteLine("Enter the subject count");
            double count=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mark1");
            double mark1=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mark2:");
            double mark2=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mark3");
            double mark3=double.Parse(Console.ReadLine());
            Percentage(mark1,mark2,mark3);
            double Percentage(double x,double y,double z)
            {
                double marks=count*100;
                double total=x+y+z;
                double value=(total/marks)*100;
                System.Console.WriteLine("Percentage:"+value+"");
                return value;
            }
                
        }
    }
}