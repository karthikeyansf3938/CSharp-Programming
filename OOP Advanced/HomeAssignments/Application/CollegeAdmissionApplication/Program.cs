using System;
namespace SyncfusionCollegeofEngineeringandTechnology;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        //Operation.AddData();
        Operation.MainMenu();
        Files.WriteToFiles();
    }
}