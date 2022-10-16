using System;
namespace ArrayStatement;
class Program
{
    public static void Main(string[] args)
    {
        int flag=0;
        string[] names=new string[5];
        for(int i=0;i<names.Length;i++)
        {
            Console.WriteLine("Enter name:");
            names[i]=Console.ReadLine();
        }
            Console.WriteLine("Enter the name to search");
            string namess=Console.ReadLine();
            
            for(int j=0;j<names.Length;j++)
            {
                if(namess==names[j])
                {
                    System.Console.WriteLine("The name is present in array .Index of the name is "+j );
                    flag=1;
                    
                }
                
            }
            if(flag!=1)
                {
                    System.Console.WriteLine("The {+namess} is not present in array");
                }
        foreach(string name in names)
        {
            if(name==namess)
            {
                System.Console.WriteLine("The name is present in array");
                flag = 1;
            }
            if(flag!=1)
            {
                System.Console.WriteLine("The name is not present in array");
            }
        }
        
        
    }
}