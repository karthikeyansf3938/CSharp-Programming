using System;
namespace OperatorOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Box box1=new Box(1.2,3.2,4.2);
            Box box2=new Box(10.1,11.1,12.22);
            Box box3;
            double volume=0;

            volume=box1.volume();
            System.Console.WriteLine("Volume of Box1 : {0}",volume);

            volume=box2.volume();
            System.Console.WriteLine("Volume of Box2 : {0}",volume);

            box3=box1+box2;
            volume=box3.volume();
            System.Console.WriteLine("Volume of Box3 : {0}",volume);

        }
        
    }
}