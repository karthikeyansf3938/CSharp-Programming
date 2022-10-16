using System;
namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineId=100;
        public string MedicineId{get;}
        public string MedicineName{get; set;}
        public int AvailableCount{get; set;}
        public double Price{get; set;}
        public DateTime DateofExpiry{get; set;}

        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateofExpiry)
        {
            s_medicineId++;
            MedicineId="MID"+s_medicineId;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateofExpiry=dateofExpiry;
        }
        public MedicineDetails(string data)
        {
            string[] value=data.Split(',');
            s_medicineId=int.Parse(value[0].Remove(0,3));
            MedicineId=value[0];
            MedicineName=value[1];
            AvailableCount=int.Parse(value[2]);
            Price=double.Parse(value[3]);
            DateofExpiry=DateTime.Parse(value[4]);
        }
    }
}