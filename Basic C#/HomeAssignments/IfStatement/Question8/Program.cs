
using System;
namespace Question6;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sugarlevel:");
            double sugarlevel = double.Parse(Console.ReadLine());
                if(sugarlevel<90 && sugarlevel>0)
                {
                    Console.WriteLine("Low Sugar ");
                }
                 else if(sugarlevel<130 && sugarlevel>=90)
                {
                    Console.WriteLine("Normal");
                }
                else if(sugarlevel<140 && sugarlevel>=130)
                {
                    Console.WriteLine("Medium");
                }
                 else if(sugarlevel<170 && sugarlevel>=140)
                {
                    Console.WriteLine("High Sugar– try to reduce it from now");
                }
                else
                {
                    Console.WriteLine("You are a very high Sugar Patient ");
                }
        }
    }
