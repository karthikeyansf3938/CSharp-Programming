namespace CovidVaccination
{
    public class VaccineDetails
    {
        private static int s_vaccineId=100;
        public string VaccineId{get;}
        public string VaccineName{get; set;}

        public int NoOfDoseAvailable{get; set;}

        public VaccineDetails(string vaccineName,int noOfDoseAvailable)
        {
            s_vaccineId++;
            VaccineId="CID"+s_vaccineId;
            VaccineName=vaccineName;
            NoOfDoseAvailable=noOfDoseAvailable;
        }
        public VaccineDetails(string data)
        {
            string[] value=data.Split(',');
            s_vaccineId=int.Parse(value[0].Remove(0,3));
            VaccineId=value[0];
            VaccineName=value[1];
            NoOfDoseAvailable=int.Parse(value[2]);
        }
    }
}