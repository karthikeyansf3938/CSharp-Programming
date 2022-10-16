using System;
using System.Collections.Generic;
namespace CovidVaccination
{
    public  enum Gender {Default,Male,Female,Transgender}
    public  class BeneficiaryDetails
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber{get;}

        public string Name{get; set;}

        public Gender Gender{get; set;}
        public long Phone{get; set;}

        public  string City{get; set;}

        public int Age{get; set;}

        public BeneficiaryDetails(string name,Gender gender,long phone,string city,int age)
        {
            s_registerNumber++;
            RegisterNumber="BID"+s_registerNumber;
            Name=name;
            Gender=gender;
            Phone=phone;
            City=city;
            Age=age;
        }
        public BeneficiaryDetails(string data)
        {
            string[] value=data.Split(',');
            s_registerNumber=int.Parse(value[0].Remove(0,3));
            RegisterNumber=value[0];
            Name=value[1];
            Gender=Enum.Parse<Gender>(value[2]);
            Phone=long.Parse(value[3]);
            City=value[4];
            Age=int.Parse(value[5]);
        }

    }
}
