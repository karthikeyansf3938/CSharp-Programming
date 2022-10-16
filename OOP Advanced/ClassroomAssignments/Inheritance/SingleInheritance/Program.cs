using System;
using SingleInheritance;
namespace SingleInheritnce;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails personalDetails=new PersonalDetails("Karthi","Thangaraj",Gender.Male,123456789);
        personalDetails.ShowDetails();
        StudentDetails student=new StudentDetails("9192782","Karthi","Thangaraj",Gender.Male,3733983,Department.CSE,"Final");
        student.ShowStudent();

    }
}
