using System;
namespace AdmissionLibrary
{
    public enum Gender{Default,Male,Feamle,Transgender}
    public class StudentDetails
    {
        private static int s_registernumber=1000;
        public string RegisterNumber{get;}
        public string Name { get; set; }//Auto property

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public string Physics { get; set; }

        public string Chemistry { get; set; }

        public string Maths { get; set; }

        public StudentDetails(string name,string fathername, DateTime dob,Gender gender,long phonenumber,string mail,string physics,string chemistry,string maths)
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            Phone=phonenumber;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        
        
        
        
        
        
        
        
        
                
        
        
        
        
        
        
        

        
        
        
    }
}