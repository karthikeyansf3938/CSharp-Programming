using System;
namespace Hierarchical1
{
    public class PrincipalDetails:PersonalDetails
    {
        private int s_principal=3000;
        public string PrincipalId{get;}
        public string Qualification1{get;set;}
        public int YearExperience1{get;set;}
        public DateTime DateJoining1{get; set;}

        public PrincipalDetails(string myName, string fatherName, DateTime dob , Gender genderName, string mailId,string qualification1,int yearExperience1,DateTime dateJoining1):base( myName, fatherName, dob , genderName,  mailId)
        {
            s_principal++;
            PrincipalId="PID"+s_principal;
            Qualification1=qualification1;
            YearExperience1=yearExperience1;
            DateJoining1=dateJoining1;

        }
        public void ShowPrincipal()
        {
            System.Console.WriteLine("Principal Id : "+PrincipalId);
            ShowDetails();
            System.Console.WriteLine("Qualification1 :"+Qualification1);
            System.Console.WriteLine("Year Experience :"+YearExperience1);
            System.Console.WriteLine("Date Joining : "+DateJoining1);

        }

        
    }
}