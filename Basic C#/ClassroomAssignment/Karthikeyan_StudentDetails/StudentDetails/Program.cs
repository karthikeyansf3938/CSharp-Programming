using System;

namespace StudentDetails;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            

            Console.WriteLine("Enter your Father name");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter your Email id");
            string mailid = Console.ReadLine();

            Console.WriteLine("Enter your Phone number");
            long phno = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Age");
            int age =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender");
            char gender = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your Chemistry mark");
            int cmark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Physics mark");
            int pmark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Maths mark");
            int mathmark = int.Parse(Console.ReadLine());

            int v = cmark + pmark + mathmark;
            double total = v;
            double average = total/3;
            Console.WriteLine("The average of these subject is:"+average);
            double percentage = (total)/600*100;
            Console.WriteLine("The average of these subject is:"+percentage);

             
        }
    }
