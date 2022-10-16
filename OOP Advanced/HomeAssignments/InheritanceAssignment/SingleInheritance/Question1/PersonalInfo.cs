using  System;
namespace Question1
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        private static int s_personalId=1000;
        public string PersonalId{get;}

        public string Name{get; set;}
        public string FatherName{get; set;}
        public long Phone{get; set;}

        public string Mail{get; set;}

        public Gender Gender{get; set;}

        public PersonalInfo(string name,string fatherName,long phone,string mail,Gender gender)
        {
            s_personalId++;
            PersonalId="PID"+s_personalId;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
        }
        public PersonalInfo(string personalId,string name,string fatherName,long phone,string mail,Gender gender)
        {
            PersonalId=personalId;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("\n------Personal Info------");
            Console.WriteLine($"Personal Id : {PersonalId}\nName : {Name}\nFatherName : {FatherName}\nPhone : {Phone}\nMail : {Mail}");   
        }
    }
}