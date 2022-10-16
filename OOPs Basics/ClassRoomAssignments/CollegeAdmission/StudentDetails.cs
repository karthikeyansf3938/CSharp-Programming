using System;
namespace CollegeAdmission
{
    public enum Gender{Default,Male,Feamle,Transgender}
    public class StudentDetails
    {
        //private string _name;

        //public string Name { get{return _name;} set{_name=value;} }
        

        public string Name { get; set; }//Auto property

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public string Physics { get; set; }

        public string Chemistry { get; set; }

        public string Maths { get; set; }

        public StudentDetails() //Default constructor
        {
            Name="Your Name";
            FatherName="Your Father Name";
        }

        public StudentDetails(string name,string fathername, DateTime dob,Gender gender,long phonenumber,string mail,string physics,string chemistry,string maths)
        {
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