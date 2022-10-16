using System.IO;
using System;
namespace OnlineMedicalStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MedicalStore"))
            {
                Console.WriteLine($"Creating Folder");
                Directory.CreateDirectory("MedicalStore");
            }
            if(!File.Exists("MedicalStore/UserDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("MedicalStore/UserDetails.csv");
            }
             if(!File.Exists("MedicalStore/MedicineDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("MedicalStore/MedicineDetails.csv");
            }
            if(!File.Exists("MedicalStore/OrderDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("MedicalStore/OrderDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] users=File.ReadAllLines("MedicalStore/UserDetails.csv");
            string[] medicines=File.ReadAllLines("MedicalStore/MedicineDetails.csv");
            string[] orders=File.ReadAllLines("MedicalStore/OrderDetails.csv");
            
            foreach(String data in users)
            {
                UserDetails user=new UserDetails(data);
                Operation.UserList.Add(user);
            }
             foreach(String data in medicines)
            {
                MedicineDetails medicine=new MedicineDetails(data);
                Operation.MedicineList.Add(medicine);
            }
             foreach(String data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operation.OrderList.Add(order);
            }
        }
        public static void WriteToFiles()
        {
            string[] userDetails = new string[Operation.UserList.Count];
            string[] medicineDetails = new string[Operation.MedicineList.Count];
            string[] orderDetails = new string[Operation.OrderList.Count];
            for(int i=0;i<Operation.UserList.Count;i++)
            {
                userDetails[i]=Operation.UserList[i].UserId+","+Operation.UserList[i].UserName+","+Operation.UserList[i].Age+","+Operation.UserList[i].Phone+","+Operation.UserList[i].Balance;
            }
             for(int i=0;i<Operation.MedicineList.Count;i++)
            {
                medicineDetails[i]=Operation.MedicineList[i].MedicineId+","+Operation.MedicineList[i].MedicineName+","+Operation.MedicineList[i].AvailableCount+","+Operation.MedicineList[i].Price+","+Operation.MedicineList[i].DateofExpiry.ToShortDateString();
            }
             for(int i=0;i<Operation.OrderList.Count;i++)
            {
                orderDetails[i]=Operation.OrderList[i].OrderId+","+Operation.OrderList[i].UserId+","+Operation.OrderList[i].MedicineId+","+Operation.OrderList[i].MedicineCount+","+Operation.OrderList[i].TotalPrice+","+Operation.OrderList[i].OrderDate+","+Operation.OrderList[i].OrderStatus;
            }
            File.WriteAllLines("MedicalStore/UserDetails.csv",userDetails);
            File.WriteAllLines("MedicalStore/MedicineDetails.csv",medicineDetails);
            File.WriteAllLines("MedicalStore/OrderDetails.csv",orderDetails);
        }
        
    }
}