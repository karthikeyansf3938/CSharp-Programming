using System;
namespace OnlineFoodDelivery;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operation.MainMenu();
        Files.WriteToFiles();
    }
}