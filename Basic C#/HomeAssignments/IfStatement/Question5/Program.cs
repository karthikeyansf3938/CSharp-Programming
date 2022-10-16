using System;

namespace Question5;

    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Chemistry :");
            int chemistry = int.Parse(Console.ReadLine());

            Console.WriteLine("Physics :");
            int physics = int.Parse(Console.ReadLine());

            Console.WriteLine("Maths:");
            int maths = int.Parse(Console.ReadLine());

            double total = chemistry+physics+maths;
            double percentage = total/300*100;
            if(percentage>=75)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            
        }
    }