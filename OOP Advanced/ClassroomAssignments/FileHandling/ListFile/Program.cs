using System;
using System.Collections.Generic;
using System.IO;
namespace ListFile;

public class MyClass
{
    public static void Main(string[] args)
    {
        List<StudentDetails> StudentList=new List<StudentDetails>();
        StudentList.Add(new StudentDetails(){Name="Karthi",FatherName="Thangaraj",Gender=Gender.Male,DOB=new DateTime(2022,09,29)});
        StudentList.Add(new StudentDetails(){Name="Karthik",FatherName="Ayyavu",Gender=Gender.Male,DOB=new DateTime(2001,09,6)});
        StudentList.Add(new StudentDetails(){Name="Karthi",FatherName="Baskar",Gender=Gender.Male,DOB=new DateTime(2022,09,2)});
        Insert(StudentList);
        Display();
    }
    public static void Insert(List<StudentDetails> students)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            Console.WriteLine($"File doesn't exist a new csv file");
            File.Create("Data.csv");
            
        }
        else
        {
            System.Console.WriteLine("File Found");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach (var student in students)
        {
            write.WriteLine(student.Name+","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }
    static void Display()
    {
        List<StudentDetails> student=new List<StudentDetails>();
        StreamReader reader=null;
        if(File.Exists("Data.csv"))
        {
            reader = new StreamReader(File.OpenRead("Data.csv"));
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var value = line.Split(',');
                if(value[0]!="")
                {
                    student.Add(new StudentDetails(){Name = value[0],FatherName = value[1],Gender=Enum.Parse<Gender>(value[2]),DOB=DateTime.ParseExact(value[3],"dd/MM/yyyy",null)});
                }
            }
        }
        else
        {
            System.Console.WriteLine("File doesn't exist");
        }
        reader.Close();
        foreach(var column1 in student)
        {
            Console.WriteLine($"Student Name : "+column1.Name+"\tStudent FatherName : "+column1.FatherName+"\tStudent Gender : "+column1.Gender+"\tStudent DOB :"+column1.DOB.ToShortDateString());   
        }
    }
}
