using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissionApplication;
public class Operations
{
    public static void MainMenu()
    {
        //File
        string willing=" ";
        List<StudentDetails> StudentList = new List<StudentDetails>();
        do
        {
        
        System.Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Father name:");
        string fathername=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Date of birth:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter your gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter your Phone number:");
        long phonenumber=int.Parse(Console.ReadLine());
        

        System.Console.WriteLine("Enter your Mail:");
        string mail=Console.ReadLine();

        System.Console.WriteLine("Enter yor Physics mark:");
        string physics=Console.ReadLine();

        System.Console.WriteLine("Enter your Chemistry mark:");
        string chemistry=Console.ReadLine();

        System.Console.WriteLine("Enter your Maths mark:");
        string maths=Console.ReadLine();

        StudentDetails student1 = new StudentDetails(name,fathername,dob,gender,phonenumber, mail, physics,chemistry, maths);
        StudentList.Add(student1);
            System.Console.WriteLine("Admitted");
        }while(willing=="yes");
        foreach(StudentDetails student in StudentList)
        {
            System.Console.WriteLine("\nStudent Details");

            System.Console.WriteLine("Your Name is :"+student.Name);
            System.Console.WriteLine("Your Father name is :"+student.FatherName);
            System.Console.WriteLine("Your Date of birth is :"+student.DOB);
            System.Console.WriteLine("Your Gender is :"+student.Gender);
            System.Console.WriteLine("Your Phone number is :"+student.Phone);
            System.Console.WriteLine("Your Mail id is :"+student.Mail);
            System.Console.WriteLine("Your Physics mark is :"+student.Physics);
            System.Console.WriteLine("Your Chemistry mark is :"+student.Chemistry);
            System.Console.WriteLine("Your Maths mark is :"+student.Maths);

        }

  
    }
}