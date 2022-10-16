using System;
namespace FunctionDelegate;
class Program
{
        static double Sum(int a, int b)
        {
            return a + b;
        }
        static double Substract(int a , int b)
        {
            return a - b;
        }
        //delegate method with function delegate
                                        //a //b //return type
        static double Calculator(Func<int,int,double> operation ,int x, int y)
        {
            return operation(x,y);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Calculator(Sum,10,20));
            Console.WriteLine(Calculator(Substract,20,10));  
        }
}