using System;

namespace Multilevel;

    public enum Gender{Defaul,Male,Female,Transgender}
    public class PersonalDetails
    {
        private static int s_aadharId=1000;
        public string AadharId{get;}

        public string Name{get; set;}

        public string FatherName{get; set;}
        public Gender Gender{get; set;}
        public long Phone{get; set;}

        public PersonalDetails(string name,string fatherName,Gender gender,long phone)
        {
            s_aadharId++;
            AadharId="AID"+s_aadharId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
        }
        public PersonalDetails(string aadharId,string name,string fatherName,Gender gender,long phone)
        {
           AadharId=aadharId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine($" AadharId : {AadharId}\n Name : {Name}\n FatherName : {FatherName}\n Gender : {Gender}\n Phone : {Phone}");
        }
    }
