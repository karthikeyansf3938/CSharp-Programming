using System;
namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            
            try
            {
                int number1=int.Parse(Console.ReadLine());
                int number2=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Number1:"+number1);
                System.Console.WriteLine("Number2:"+number2);
                int output=number1/number2;
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("An exception occured:{0},", e.Message);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(e.StackTrace);
            }
            finally
            {
                System.Console.WriteLine("All exception handled correctly");
            }

            

        }
    }
}