using System;
namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentId=100;
        public string StudentId{get;}
        public int Standard{get; set;}

        public string Branch{get; set;}
        public string AcademicYear{get; set;}

    public StudentInfo(string personalId,string name,string fatherName,long phone,string mail,Gender gender,int standard,string branch,string academicYear):base(personalId,name,fatherName,phone,mail,gender)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }
        public void UpdateInfo()
        {
            System.Console.WriteLine("\n------Update Info------");
            System.Console.WriteLine("\nStudent Id : "+StudentId);
            ShowInfo();
            Console.WriteLine($"Standard : {Standard} \nBranch : {Branch} \nAcademic Year : {AcademicYear} ");  
        }
    }
}