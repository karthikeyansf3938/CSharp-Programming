using System;
using System.IO;

namespace CovidVaccination
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("CovidVaccination"))
            {
                Console.WriteLine($"Creating Folder");
                Directory.CreateDirectory("CovidVaccination");
            }
            //user
            if(!File.Exists("CovidVaccination/BeneficiaryDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("CovidVaccination/BeneficiaryDetails.csv");
            }
            //vaccine
             if(!File.Exists("CovidVaccination/VaccineDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("CovidVaccination/VaccineDetails.csv");
            }
            if(!File.Exists("CovidVaccination/VaccinationDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("CovidVaccination/VaccinationDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] users=File.ReadAllLines("CovidVaccination/BeneficiaryDetails.csv");
            string[] vaccines=File.ReadAllLines("CovidVaccination/VaccineDetails.csv");
            string[] vaccinations=File.ReadAllLines("CovidVaccination/VaccinationDetails.csv");
            
            foreach(String data in users)
            {
                BeneficiaryDetails user=new BeneficiaryDetails(data);
                Operation.BeneficiaryList.Add(user);
            }
             foreach(String data in vaccines)
            {
                VaccineDetails vaccine=new VaccineDetails(data);
                Operation.VaccineList.Add(vaccine);
            }
             foreach(String data in vaccinations)
            {
                VaccinationDetails vaccination=new VaccinationDetails(data);
                Operation.VaccinateList.Add(vaccination);
            }
        }
        public static void WriteToFiles()
        {
            string[] userDetails = new string[Operation.BeneficiaryList.Count];
            string[] vaccineDetails = new string[Operation.VaccineList.Count];
            string[] vaccinationDetails = new string[Operation.VaccinateList.Count];
            for(int i=0;i<Operation.BeneficiaryList.Count;i++)
            {
                userDetails[i]=Operation.BeneficiaryList[i].RegisterNumber+","+Operation.BeneficiaryList[i].Name+","+Operation.BeneficiaryList[i].Gender+","+Operation.BeneficiaryList[i].Phone+","+Operation.BeneficiaryList[i].City+","+Operation.BeneficiaryList[i].Age;
            }
             for(int i=0;i<Operation.VaccineList.Count;i++)
            {
                vaccineDetails[i]=Operation.VaccineList[i].VaccineId+","+Operation.VaccineList[i].VaccineName+","+Operation.VaccineList[i].NoOfDoseAvailable;
            }
             for(int i=0;i<Operation.VaccinateList.Count;i++)
            {
                vaccinationDetails[i]=Operation.VaccinateList[i].VaccinationId+","+Operation.VaccinateList[i].RegisterNumber+","+Operation.VaccinateList[i].VaccineId+","+Operation.VaccinateList[i].DoseNumber+","+Operation.VaccinateList[i].VaccinatedDate.ToShortDateString();
            }
            File.WriteAllLines("CovidVaccination/BeneficiaryDetails.csv",userDetails);
            File.WriteAllLines("CovidVaccination/vaccineDetails.csv",vaccineDetails);
            File.WriteAllLines("CovidVaccination/vaccinationDetails.csv",vaccinationDetails);
        }
        
    }
}