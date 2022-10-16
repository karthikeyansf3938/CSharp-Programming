using System;
using System.Collections.Generic;
namespace BloodBankManagement
{
    public enum BloodGroup{Default,A_Positive,B_Positive,O_Positive,AB_Positive}
    public class UserRegistration
    {
        private static int s_userId=1000;

        public  int UserId{get;}

        public string UserName{get; set;}

        public  long Phone{get; set;}

        public BloodGroup BloodGroup{get; set;}

        public int Age{get; set;}

        public  DateTime LastDonation{get; set;}

        public UserRegistration(string userName,long phone,BloodGroup bloodGroup,int age,DateTime lastDonation)
        {
            s_userId++;
            UserId=s_userId;
            UserName = userName;
            Phone = phone;
            BloodGroup = bloodGroup;
            Age = age;
            LastDonation = lastDonation;
        }
        public static void GetDonationDetails()
        {
            System.Console.WriteLine("User Deatils");
            
        }
    }
}