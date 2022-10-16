using System;
namespace Hierarchical1
{
    public enum Gender{Default,Male,Female,Gender}
    public class PersonalDetails
    {

        public string Name{get;set;}
        public string FatherName{get;set;}
        public DateTime DOB{get; set;}
        public Gender Gender1{get;set;}
        public string MailId{get;set;}

        public PersonalDetails(string myName, string fatherName, DateTime dob , Gender genderName, string mailId)
        {
            Name=myName;
            FatherName=fatherName;
            DOB=dob;
            Gender1=genderName;
            MailId=mailId;

        }
         public PersonalDetails(string data,string myName, string fatherName, DateTime dob , Gender genderName, string mailId)
        {
            Name=myName;
            FatherName=fatherName;
            DOB=dob;
            Gender1=genderName;
            MailId=mailId;

        }

        public void ShowDetails()
        {
           
            System.Console.WriteLine(" Name : "+Name);
            System.Console.WriteLine(" Father Name : "+FatherName);
            System.Console.WriteLine("Date Of Birth :"+DOB.ToShortDateString());
            System.Console.WriteLine("Gender : "+Gender1);
            System.Console.WriteLine("Mail ID :"+MailId);
        }
    }
}