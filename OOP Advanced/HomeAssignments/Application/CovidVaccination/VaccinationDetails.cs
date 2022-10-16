using System;

namespace CovidVaccination
{
    public class VaccinationDetails
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber{get;}

        private static int s_vaccineId=100;
        public string VaccineId{get;}

        private static int s_vaccinationId=1000;
        public string VaccinationId{get;}

        public int DoseNumber{get; set;}

        public DateTime VaccinatedDate{get; set;}

        public VaccinationDetails(string registerNumber,string vaccineId,int doseNumber,DateTime vaccinatedDate)
        {
            s_vaccinationId++;
            VaccinationId="VID"+s_vaccinationId;
            RegisterNumber=registerNumber;
            VaccineId=vaccineId;
            DoseNumber=doseNumber;
            VaccinatedDate=vaccinatedDate;
        }
         public VaccinationDetails(string data)
        {
            string[] value=data.Split(',');
            s_vaccinationId=int.Parse(value[0].Remove(0,3));
            VaccinationId=value[0];
            RegisterNumber=value[1];
            VaccineId=value[2];
            DoseNumber=int.Parse(value[3]);
            VaccinatedDate=DateTime.Parse(value[4]);
        }
    }
}