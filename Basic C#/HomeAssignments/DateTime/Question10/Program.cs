using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("The today is : {0}",DateTime.Today.ToString("dd/MM/yyyy"));
            DateTime today=GetTomorrow();
            Console.WriteLine("\nThe tomorrow will be : {0}",today.ToString("dd/MM/yyyy"));
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

    }
}