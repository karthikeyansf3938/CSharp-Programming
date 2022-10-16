using System;
namespace Hierarchical3
{
    public class SuzukiDetails:CarDetails
    {
        public int ModelNumber{get;set;}
        public string ModelName{get;set;}
        public SuzukiDetails(string data,int rcBook,int engineNo,int chasisNo,int mileage,int tankCapacity,int seatno,int kmNo,DateTime date1,int modelNo,string modelName):base(data, rcBook,engineNo,chasisNo, mileage,tankCapacity, seatno,kmNo,date1)
        {
            ModelNumber=modelNo;
            ModelName=modelName;

        }
        public void ShowSuzuki()
        {
            Mileage=TankCapacity*NoOFKm;
            ShowDetails();
            System.Console.WriteLine("Model No :"+ModelNumber);
            System.Console.WriteLine("Model Name :"+ModelName);
            System.Console.WriteLine("Mileage : "+Mileage);

        }

    }
    
}