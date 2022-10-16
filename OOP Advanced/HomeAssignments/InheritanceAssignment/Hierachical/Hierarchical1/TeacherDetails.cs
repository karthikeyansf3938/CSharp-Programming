using System;
namespace Hierarchical1
{
    public class TeacherDetails:PersonalDetails
    {
        private int s_teacherId=1000;
        public string TeacherId {get;}
         public string  Department{get;set;}
        public string SubjectTeaching{get;set;}
        public string Qualification{get; set;}
        public int YearExperience{get;set;}
        public DateTime DateJoining{get;set;}

        public TeacherDetails(string myName, string fatherName, DateTime dob , Gender genderName, string mailId,string department, string subjecTeaching,string qualification , int yearExperience, DateTime dateJoining):base( myName, fatherName,  dob , genderName,mailId)
        {
            s_teacherId++;
            TeacherId="TID"+s_teacherId;
            Department=department;
            SubjectTeaching=subjecTeaching;
            Qualification=qualification;
            YearExperience=yearExperience;
            DateJoining=dateJoining;

        }
        public void ShowTeacher()
        {
            
            ShowDetails();
            System.Console.WriteLine("DepartMent : "+Department);
            System.Console.WriteLine("Subject Teaching :"+SubjectTeaching);
            System.Console.WriteLine("Qualification : "+Qualification);
            System.Console.WriteLine("Year Experience : "+YearExperience );
            System.Console.WriteLine("Date Joining :"+DateJoining.ToShortDateString());

            
        }
        
    }
}
