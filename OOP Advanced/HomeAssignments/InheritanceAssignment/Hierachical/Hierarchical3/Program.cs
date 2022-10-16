using System;
namespace Hierarchical3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("---------SuzukiDetails---------");
        SuzukiDetails suzuki =new SuzukiDetails("Car",1122,2233,445,0,20,4,12,new DateTime(2022,12,11),9988,"Suzuki");
        suzuki.ShowSuzuki();
         System.Console.WriteLine("---------TataDetails---------");
        TataDetails tata =new TataDetails("Car2",2012,2013,2014,0,4,4,12,new DateTime(2022,12,11),9988,"Suzuki");
        tata.ShowTata();
    }
}