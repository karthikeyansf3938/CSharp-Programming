using System;

namespace Multilevel
{
    public  enum Department{Default,CSE,ECE,EEE}
    public class StudentDetails : PersonalDetails,IMarkDetails
    {
        private static int s_id=3000;
        public string StudentId{get;}
        public Department Department{get; set;}

        public string Year{get; set;}
        public double Physics { get; set; }//Property declaration is only allowed
        public double Chemistry{get; set;}

        public double Maths{get; set;}

        public double Total{get; set;}

        public double Average{get; set ;}
        public StudentDetails(string aadharId,string name,string fatherName,Gender gender,long phone,Department department, string year):base(aadharId,name,fatherName,gender,phone)
        {
            s_id++;
            StudentId="SID"+s_id;
            Department=department;
            Year=year;
        }
        public StudentDetails(string studentId,string aadharId,string name,string fatherName,Gender gender,long phone,Department department):base(aadharId,name,fatherName,gender,phone)
        {
            StudentId=studentId;
            Department=department;
            
        }
        public void GetMark(double physics,double chemistry,double maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void Calculation()
        {
            Total=Physics+Chemistry+Maths;
            Average=Total/3.0;
        }
        public void ShowMark()
        {
            System.Console.WriteLine($"Chemistry : {Chemistry}\nPhysics : {Physics}\n Maths : {Maths}");
            Console.WriteLine($"Total : {Total}\nAverage : {Average}");
            
        }
        public void ShowStudent()
        {
            System.Console.WriteLine($"Student Id : {StudentId}");
            ShowDetails();
            System.Console.WriteLine($"Department : {Department}\n year : {Year}");
        }
        
    }
}