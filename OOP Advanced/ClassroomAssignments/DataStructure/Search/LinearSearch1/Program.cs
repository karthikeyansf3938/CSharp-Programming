using System;
namespace LinearSearch1

{
    class Program
    {
        public static void Main(string[] args)
        {
            int flag=0;
            System.Console.WriteLine("Enter the String to find");
            String find=Console.ReadLine().ToLower();

            string[] cars=new string[]{"audi","benz","bmw","creta","ambassodor"};

            for(int i=0;i<cars.Length;i++)
            {
                if(find==cars[i])
                {
                    flag=1;
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("The find string is not present in the array");
            }
            else
            {
                System.Console.WriteLine("The find string is present in the array");
            }
        }
        

    }    
}