using System;
namespace AbstractClasses;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("====AbstractBase====");
        //Syncfusion
        System.Console.WriteLine("====\nSyncfusion====");
        Syncfusion syncfusion=new Syncfusion();
        syncfusion.Name="karthi";
        syncfusion.Salary(10);
        
        //TCS
        System.Console.WriteLine("\n=====TCS=====");
        TCS tcs=new TCS();
        tcs.Name="Karthi";
        tcs.Salary(10);

    }
}