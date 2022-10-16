using System;
namespace OnlineGroceryStore
{
    public enum Gender{Default,Male,Female,Transfender}
    public  class PersonalDetails
    {
        public string Name{get; set;}
        public string FatherName{get; set;}
        public Gender Gender{get; set;}

        public long Phone{get; set;}
        public DateTime DateofBirth{get; set;}
        public string MailId{get; set;}

    }
}