using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius:");
        double radius=double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the choice");
        char choice =char.Parse(Console.ReadLine());

        switch (choice)
        {
            case '1':
            {
                System.Console.WriteLine($"The area is {3.14*radius*2}");
                break;
            }
            case '2':
            {
                System.Console.WriteLine($"The perimeter is{2*3.14*radius}");
                break;
            }
            case '3':
            {
                System.Console.WriteLine($"The Diameter is{2*radius}");
                break;
            }
        }
    }
}
