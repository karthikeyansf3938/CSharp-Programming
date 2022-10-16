using System;
using SingleInheritnce;

namespace SingleInheritance
{
    public  enum Department{Default,CSE,ECE,EEE}
    public class StudentDetails : PersonalDetails
    {
        private static int s_id=3000;
        public string StudentId{get;}
        public Department Department{get; set;}

        public string Year{get; set;}
        public StudentDetails(string aadharId,string name,string fatherName,Gender gender,long phone,Department department, string year):base(aadharId,name,fatherName,gender,phone)
        {
            s_id++;
            StudentId="SID"+s_id;
            Department=department;
            Year=year;
        }
        public void ShowStudent()
        {
            System.Console.WriteLine($"Student Id : {StudentId}");
            ShowDetails();
            System.Console.WriteLine($"Department : {Department}\n year : {Year}");
        }
        
    }
}