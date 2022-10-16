using System;
namespace OnlineFoodDelivery
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name{get; set;}
        public string FatherName{get; set;}
        public Gender Gender{get; set;}
        public long Phone{get; set;}
        public DateTime DOB{get; set;}
        public string Mail{get; set;}
        public string Location{get; set;}

    }
}