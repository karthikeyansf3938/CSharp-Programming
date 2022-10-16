using System;
namespace BloodBankManagement
{
    public class Donation
    {
        private static int s_donationid=100;
        public  string DonationId{get;}
        public static DateTime DonationDate{get; set;}

        public static double Weight{get; set;}
        public static double BloodPressure{get; set;}
        public static double HemoglobinCount{get; set;} 

        public Donation(DateTime donationDate,double weight,double bloodpressure,double hemoglobinCount)
        {
            s_donationid++;
            DonationId="DID"+s_donationid;
            DonationDate=donationDate;
            Weight=weight;
            BloodPressure=bloodpressure;
            HemoglobinCount=hemoglobinCount;
        }
    }	
}