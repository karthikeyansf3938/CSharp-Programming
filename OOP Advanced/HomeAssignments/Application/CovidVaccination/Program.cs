using System;
using System.Collections.Generic;
namespace CovidVaccination;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        //Operation.AddUser();
        //Operation.Addvaccine();
        //Operation.AddData();
        Operation.MainMenu();
        Files.WriteToFiles();
    }
}