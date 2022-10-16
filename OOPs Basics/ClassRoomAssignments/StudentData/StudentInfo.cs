using System;
namespace StudentData
{
    public static class StudentInfo
    {
        public static string Name { get; set; } //property

        public static int RegisterNumber;//field
        
        static StudentInfo()//default constructor
        {
            Name="karthi";
            RegisterNumber=1;
        }
        public static void Display()
        {
            System.Console.WriteLine("Name : "+Name);
            System.Console.WriteLine("Register Number :"+RegisterNumber);
        }
    }

}