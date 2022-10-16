using System;
namespace DateTimes
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dob=new DateTime(2021,8,10,10,40,32);
            Console.WriteLine("Day "+dob.Date);       
            Console.WriteLine("Month "+dob.Month);      
            Console.WriteLine("Year "+dob.Year);
            Console.WriteLine("Hour "+dob.Hour);         
            Console.WriteLine("Minute "+dob.Minute);      
            Console.WriteLine("Second "+dob.Second);
            
            String dob1=dob.ToString();
            string[] dob2=dob1.Split('/',' ');
            Console.WriteLine(" "+dob2);
        }
    }
}
