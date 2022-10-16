using System;
namespace ListFile
{
    public enum Gender{Default, Male,Female,Transgender}
    public class StudentDetails
    {
        public string Name{get; set;}

        public string FatherName{get; set;}

        public Gender Gender{get; set;}

        public DateTime DOB{get; set;}

    }
}