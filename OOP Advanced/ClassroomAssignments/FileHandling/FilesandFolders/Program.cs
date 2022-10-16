using System;
using System.IO;
namespace FilesandFolders;
class Program
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\KarthikeyanThangaraj\OneDrive - Syncfusion\Desktop\MyFolder";

        string folderPath=path+@"\karthikeyan";
        string filePath=path+"/newFile.txt";

        if(!Directory.Exists(folderPath))
        {
            Console.WriteLine($"Folder not found creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine($"Directory found");
        }
        if(!File.Exists(filePath))
        {
            Console.WriteLine($"File not found creating file");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine($"File Already exists"); 
        }

        System.Console.WriteLine("Main menu for File and Folder");
        System.Console.WriteLine("Select OPtion \n1. Create folder \n2. Create File \n3.DeleteFolder \n4.Delete File");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                Console.WriteLine($"Enter folder name you want to create");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    Console.WriteLine($"Directory name already exists");
                    
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter a file name you want to create");
                string name1=Console.ReadLine();
                Console.WriteLine($"Enter file exetension you want to create");
                String exetention=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+exetention;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    Console.WriteLine($"File Name already Exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name2 in Directory.GetDirectories(path))
                {
                    Console.WriteLine($"name");
                }
                Console.WriteLine($"Select folder you want to delete");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                    foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath) //check folder matches
                    {
                        Directory.Delete(newPath);
                        Console.WriteLine($"Folder Deleted");
                        
                    }
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select file you want to delete");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter file extention you want to delete");
                string name2=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                try
                {
                     File.Delete(newPath);
                    System.Console.WriteLine("File Deleted");
                }
                catch(System.Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                break; 
                
            }
            default:
            {
                System.Console.WriteLine("Invalid Input");
                break;
            }
            
        }
    }
}