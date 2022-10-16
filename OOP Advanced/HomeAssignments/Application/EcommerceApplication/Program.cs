using System;
using System.Collections.Generic;
namespace EcommerceApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Files.Create();
            Files.ReadFile();
            //Operation.Adddata();
            //Operation.productdata();
            //Operation.orderdata();
            Operation.MainMenu();
            Files.WriteFiles();
        }
    }
}