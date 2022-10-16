using System;
using System.Collections.Generic;
namespace CovidVaccination
{
    public static class Operation
    {
        public static List<BeneficiaryDetails> BeneficiaryList=new List<BeneficiaryDetails>();
        public static List<VaccineDetails> VaccineList=new List<VaccineDetails>();
        public static List<VaccinationDetails> VaccinateList=new List<VaccinationDetails>();

        static BeneficiaryDetails currentUser=null;
        public static void MainMenu()
        {
            System.Console.WriteLine("-----MainMenu------");
            string choice="";
            do
            {
                System.Console.WriteLine("Select the Option 1.Beneficiary Registration  2.LogIn 3.Get VaccineInfo 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("------Beneficiary Registration------");
                        BeneficiaryRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("-----LogIn-----");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Vaccine Details");
                        System.Console.WriteLine($" VaccineId      VaccineName     NoOfDoseAvailable");
                        foreach(VaccineDetails vaccine in VaccineList)
                        {
                        Console.WriteLine($"{vaccine.VaccineId}\t\t{vaccine.VaccineName}\t\t{vaccine.NoOfDoseAvailable}");                
                        }
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("-----Exit-----");
                        choice="yes";
                        break;
                    }
                }
            }while(choice!="yes");

        }

        public static void SubMenu()
        {   
            string condition="yes";
            do
            {
                System.Console.WriteLine("-----SubMenu-----");
                System.Console.WriteLine("Select the Option 1.Show My Deatils 2.Take Vaccination 3.My Vaccination history 4.Next DueDate 5.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("-----User Details------");
                        Display();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("----Take Vaccine-----");
                        TakeVaccine();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("-----Vaccination History-----");
                        System.Console.WriteLine("RegisterId        VaccinationId       VaccinateDate       Dosenumber");
                        foreach(VaccinationDetails vaccination1 in VaccinateList)
                        {
                            if(currentUser.RegisterNumber==vaccination1.RegisterNumber)
                            {   
                                System.Console.WriteLine($"{currentUser.RegisterNumber}\t\t{vaccination1.VaccinationId}\t\t{vaccination1.VaccinatedDate}\t\t{vaccination1.DoseNumber}");
                            }
                        }
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("------Next DueDate------");
                        foreach(VaccinationDetails vaccination1 in VaccinateList)
                        {   
                            if(currentUser.RegisterNumber==vaccination1.RegisterNumber)
                            {
                                if(vaccination1.DoseNumber>0)
                                {
                                    DateTime vaccinationDate=DateTime.Today;
                                    DateTime vaccinationDate1=vaccinationDate.AddDays(30);
                                    System.Console.WriteLine("Your Next Due date is "+vaccinationDate1);
                                }
                                else
                                {
                                    System.Console.WriteLine("Take Vaccine Now");
                                }
                            }
                        }
                        break;
                    }
                    case 5:
                    {
                    System.Console.WriteLine("----LogOut---");
                    condition="no";
                    break;
                }
                }
            }while(condition=="yes");
        }
        public static void BeneficiaryRegistration()
        {
            System.Console.WriteLine("Enter your Name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your PhoneNumber");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your City");
            string city= Console.ReadLine();
            System.Console.WriteLine("Enter Your Age");
            int age=int.Parse(Console.ReadLine());

            BeneficiaryDetails user=new BeneficiaryDetails(name,gender,phone,city,age);
            BeneficiaryList.Add(user);
            System.Console.WriteLine("Submitted");
            System.Console.WriteLine("Your Beneficiary Id is "+user.RegisterNumber);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Beneficiary Id ");
            string userId=Console.ReadLine().ToUpper();
            foreach(BeneficiaryDetails user in BeneficiaryList)
            {
                if(userId==user.RegisterNumber)
                {
                    System.Console.WriteLine("Login successfull");
                    currentUser=user;
                    SubMenu();
                }
            }
        }
        public static void Display()
        {
            System.Console.WriteLine("Your Beneficiary Id is :"+currentUser.RegisterNumber);
            System.Console.WriteLine("Your Name is :"+currentUser.Name);
            System.Console.WriteLine("Your Gender is :"+currentUser.Gender);
            System.Console.WriteLine("Your Phone Number is :"+currentUser.Phone);
            System.Console.WriteLine("Your Age is :"+currentUser.Age);
            System.Console.WriteLine("Your City is :"+currentUser.City);
        }
        public static void TakeVaccine()
        {
           
            int flag=0;
            foreach (VaccinationDetails vaccination in VaccinateList)
            {
                if(currentUser.RegisterNumber==vaccination.RegisterNumber)
                {
                    if(vaccination.DoseNumber!=null)
                    {
                       flag=1;
                    }
                    else
                    {
                        flag=0;
                    }
                }
            }
            if(flag==1)
            {
                System.Console.WriteLine("Vaccine Details");
                System.Console.WriteLine($" VaccineId      VaccineName     NoOfDoseAvailable");
                foreach(VaccineDetails vaccine in VaccineList)
                {
                Console.WriteLine($"{vaccine.VaccineId}\t\t{vaccine.VaccineName}\t\t{vaccine.NoOfDoseAvailable}");                
                }
                System.Console.WriteLine("Enter the Vaccine Id");
                string tempvaccineId=Console.ReadLine().ToUpper();
                foreach(VaccineDetails vaccine in VaccineList)
                {
                    if(tempvaccineId==vaccine.VaccineId)
                    {
                        foreach (VaccinationDetails vaccination in VaccinateList)
                        {
                            if(currentUser.RegisterNumber==vaccination.RegisterNumber)
                            {
                                if(vaccination.DoseNumber>=1 && vaccination.DoseNumber<3)
                                {
                                    if(currentUser.Age>=14)
                                    {
                                        System.Console.WriteLine("Vaccination is allowed");
                                        vaccine.NoOfDoseAvailable--;
                                        vaccination.DoseNumber++;
                                        
                                        DateTime vaccinationDate=DateTime.Now;
                                        VaccinationDetails vaccination1=new VaccinationDetails(currentUser.RegisterNumber,tempvaccineId,vaccination.DoseNumber,vaccinationDate);
                                        VaccinateList.Add(vaccination1);
                                        System.Console.WriteLine("vaccinated successfully");
                                        System.Console.WriteLine("Your Vaccination Id is : "+vaccination1.VaccinationId);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You're Not eligible for an vaccination because you're under 14");
                                        
                                    }
                                }
                                else
                                {
                                    System.Console.WriteLine("All the three Vaccination course are completed you cannot be vaccinated now");
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                System.Console.WriteLine("Vaccine Details");
                System.Console.WriteLine($" VaccineId      VaccineName     NoOfDoseAvailable");
                foreach(VaccineDetails vaccine in VaccineList)
                {
                Console.WriteLine($"{vaccine.VaccineId}\t\t{vaccine.VaccineName}\t\t{vaccine.NoOfDoseAvailable}");                
                }
                System.Console.WriteLine("Enter the Vaccine Id");
                string tempvaccineId=Console.ReadLine().ToUpper();
                foreach(VaccineDetails vaccine in VaccineList)
                {
                    if(tempvaccineId==vaccine.VaccineId)
                    {
                        foreach (VaccinationDetails vaccination1 in VaccinateList)
                        {
                            if(currentUser.RegisterNumber!=vaccination1.RegisterNumber)
                            {
                                if(currentUser.Age>=14)
                                {
                                    System.Console.WriteLine("Vaccination is allowed");
                                    vaccine.NoOfDoseAvailable--;
                                    vaccination1.DoseNumber++;
                                    
                                    DateTime vaccinationDate=DateTime.Now;
                                    VaccinationDetails vaccination2=new VaccinationDetails(currentUser.RegisterNumber,tempvaccineId,vaccination1.DoseNumber,vaccinationDate);
                                    VaccinateList.Add(vaccination2);
                                    System.Console.WriteLine("vaccinated successfully");
                                    System.Console.WriteLine("Your Vaccination Id is : "+vaccination1.VaccinationId);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void AddUser()
    {
        BeneficiaryDetails user=new BeneficiaryDetails("Ravichandran",Gender.Male,8484484,"chennai",21);
        BeneficiaryList.Add(user);
        BeneficiaryDetails user1=new BeneficiaryDetails("Baskaran",Gender.Male,8787787,"chennai",22);
        BeneficiaryList.Add(user1);
    }
        public static void Addvaccine()
    {
        VaccineDetails vaccine=new VaccineDetails("CovieShield",50);
        VaccineList.Add(vaccine);
        VaccineDetails vaccine1=new VaccineDetails("Coveccine",50);
        VaccineList.Add(vaccine1);
    }
        public static void AddData()
    {
        VaccinationDetails vaccination=new VaccinationDetails("BID1001","CID101",1,new DateTime(11/11/2021));
        VaccinateList.Add(vaccination);
        VaccinationDetails vaccination1=new VaccinationDetails("BID1001","CID101",1,new DateTime(11/03/2022));
        VaccinateList.Add(vaccination1);
        VaccinationDetails vaccination2=new VaccinationDetails("BID1002","CID102",1,new DateTime(04/04/2022));
        VaccinateList.Add(vaccination2);
    }
    }
    
    
}