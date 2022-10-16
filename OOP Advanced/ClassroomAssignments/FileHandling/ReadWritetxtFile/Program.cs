using System;
using System.IO;
namespace ReadWritetxtFile;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine($"Folder created");
        }
        else
        {
            Console.WriteLine($"Folder exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else
        {
            Console.WriteLine($"File Found");
            
        }
        System.Console.WriteLine("Select Option \n1.Read File Info \n2.Write File Info");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                string line;
                StreamReader obj=null; //Create a name for stream Reader
                try
                {
                    obj=new StreamReader("TestFolder/Test.txt"); //create a object for stream Reader
                    line=obj.ReadLine();
                    while(obj!=null) //untill File doesn't contain a nothing
                    {
                        System.Console.WriteLine(line);
                        line=obj.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    if(obj!=null)
                    {
                        System.Console.WriteLine("Executing finally block");
                        obj.Close();  //Nothing is in file then close the file
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try{
                string[] old=File.ReadAllLines("TestFolder/Test.txt");
                //pass the filepath and filename to the stream WRITER
                sw = new StreamWriter("TestFolder/Test.txt");
                System.Console.WriteLine("Enter new content to be placed in file");
                string info=Console.ReadLine();
                string old1="";
                foreach(string text in old)
                {
                    old1=old1+"\n"+text;  //append old text info
                }
                old1=old1+"\n"+info;
                Console.WriteLine(old1);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    sw.Close();
                }
                break;
            }
            
        }
    }
}
