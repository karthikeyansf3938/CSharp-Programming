using System;
using System.Collections.Generic;
namespace BloodBankManagement;
public static class Operation
{
     static List<UserRegistration> UserList=new List<UserRegistration>();
     static List<Donation> DonationList=new List<Donation>();
     static UserRegistration CurrentUser=null;
    
    public static void MainMenu()
    {
       
        string condition="";
        do
        {
            System.Console.WriteLine("==========MainMenu==========");
            System.Console.WriteLine("\nSelect the Option 1.UserRegistration  2.Login  3.FetchDonarDetails 4.Exit");
            System.Console.WriteLine("Enter your Choice");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("-----User Registration-----");
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("\nLogin");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("\nFetch Donor details");
                    FetchDonarDetails();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    condition="no";
                    break;
                }
            }
        }while(condition!="yes");
    }
    public static void UserRegistration()
    {
        System.Console.WriteLine("Enter your name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Phone Number");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Blood group");
        BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter your age");
        int age=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your last donation");
        DateTime lastDonation=DateTime.Parse(Console.ReadLine());
        lastDonation.ToString("dd/MM/yyyy");
        UserRegistration user=new UserRegistration(name,phone,bloodGroup,age,lastDonation);
        UserList.Add(user);
        System.Console.WriteLine("Your User Id is "+user.UserId);
    }
    public static void Login()
    {
        System.Console.WriteLine("Enter your User Id");
        int userid=int.Parse(Console.ReadLine().ToUpper());
        foreach(UserRegistration user1 in UserList)
        {
            if(userid == user1.UserId)
            {
                System.Console.WriteLine("LogIn Successfull");
                CurrentUser=user1;
                SubMenu();
            }

        }
    }
    public static void SubMenu()
    {
        string condition="yes";
        do
        {
            System.Console.WriteLine("\n-----SubMenu-----");
            System.Console.WriteLine("\nSelect the Option 1.Donate Blood  2.Donation History  3.Next eligible date    4.Exit");
            System.Console.WriteLine("\nEnter your choice :");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("\n-----Donate Blood-----");
                    DonateBlood();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("\n-----Donation History-----");
                    DonationHistory();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("\n-----Next Eligible Date-----");
                    NextEligibleDate();
                    break;

                }
                case 4:
                {
                    System.Console.WriteLine("-----LogOut-----");
                    condition="no";
                    break;
                }
            }
        }while(condition=="yes");
    }
    public static void DonateBlood()
    {
        System.Console.WriteLine("Enter your Weight : ");
        double weight=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Blood Pressure : ");
        double bloodpressure=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Hemoglobin Count : ");
        double hemoglobinCount=double.Parse(Console.ReadLine());
        Donation donation=new Donation(CurrentUser.LastDonation,weight,bloodpressure,hemoglobinCount);
        DonationList.Add(donation);

        if(weight>=50 && bloodpressure<=130 && hemoglobinCount>=13)
        {
            //Check Eligibility date
            DateTime increase=NextEligibleDate();
            if(increase>=CurrentUser.LastDonation)
            {
                DateTime today=DateTime.Now;
                CurrentUser.LastDonation=today;
                DateTime nextDate=today.AddDays(60);
                Donation donate=new Donation(today,weight,bloodpressure,hemoglobinCount);
                DonationList.Add(donate);

                Console.WriteLine($"Blood Donated Successfully \nYour Donation Id is{donate.DonationId}");
                Console.WriteLine($"Your Next Due Date is {nextDate.ToShortDateString()}");
                            

            }
        }
    }

    public static void DonationHistory()
    {
        
        foreach(Donation donation in DonationList)
        {
           foreach(UserRegistration user in UserList)
           {
                System.Console.WriteLine($"\nDonation Id : {donation.DonationId}\nUser Id : {user.UserId}\nWeight : {user.BloodGroup}\nLastDonation : {user.LastDonation}");
           }
        }
    }
    public static DateTime NextEligibleDate()
    {
        DateTime day = CurrentUser.LastDonation.AddDays(60);
        System.Console.WriteLine("Your next eligible for donation is "+day.ToShortDateString());
        return day;
    }
    public static void FetchDonarDetails()
    {
        System.Console.WriteLine("Enter the searching blood group :");
        BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);

        Console.WriteLine($"Donor's Name        MobileNumber");
        foreach (UserRegistration donors in UserList)
        {
            if (bloodGroup==donors.BloodGroup)
            {
                Console.WriteLine($"{donors.UserName}\t\t{donors.Phone}");
            }
        }
        
    }
}