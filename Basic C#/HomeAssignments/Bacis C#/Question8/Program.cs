using System;
namespace Question5;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Physics-");
        double physics = double.Parse(Console.ReadLine());

        Console.WriteLine("Chemistry-");
        double chemistry = double.Parse(Console.ReadLine());

        Console.WriteLine("Maths-");
        double maths = double.Parse(Console.ReadLine());

        double sum = physics + chemistry + maths;
        double percentage =Math.Round((sum/300)*100);
        Console.WriteLine($"Physics-{physics} \nChemistry-{chemistry} \nMaths-{maths}");
        Console.WriteLine("Sum = "+sum);
        Console.WriteLine("Percentage = "+percentage);


    }
}