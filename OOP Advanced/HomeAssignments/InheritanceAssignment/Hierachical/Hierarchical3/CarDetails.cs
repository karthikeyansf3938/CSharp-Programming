using System;
namespace Hierarchical3
{
    
    public class CarDetails
    {
        public int RcBookNo{get;set;}
        public int EngineNo{get;set;}
        public int ChasisNo{get;set;}
        public int Mileage{get;set;}
        public int TankCapacity{get;set;}
        public int NoOFSeats{get;set;}
        public int NoOFKm{get;set;}
        public DateTime Date{get;set;}

        
        
        
//personal comstructor
        public CarDetails(int rcBook,int engineNo,int chasisNo,int mileage,int tankCapacity,int seatno,int kmNo,DateTime date1)

        {
            RcBookNo=rcBook;
            EngineNo=engineNo;
            ChasisNo=chasisNo;
            Mileage=mileage;
            
            TankCapacity=tankCapacity;
            NoOFSeats=seatno;
            NoOFKm=kmNo;
            Date=date1;

        }
    // Duplicate Constructor    
           public CarDetails(string data,int rcBook,int engineNo,int chasisNo,int mileage,int tankCapacity,int seatno,int kmNo,DateTime date1)

        {
            RcBookNo=rcBook;
            EngineNo=engineNo;
            ChasisNo=chasisNo;
            
            TankCapacity=tankCapacity;
            NoOFSeats=seatno;
            NoOFKm=kmNo;
            Date=date1;

        }
        public void ShowDetails()
        {
            
            System.Console.WriteLine("RC Book :"+RcBookNo);
            System.Console.WriteLine("Engine No :"+EngineNo);
            System.Console.WriteLine("Chasis No : "+ChasisNo);
            System.Console.WriteLine("Mileage : "+Mileage);
            System.Console.WriteLine("Tank Capacity :"+TankCapacity);
            System.Console.WriteLine("No of Seats :"+NoOFSeats);
            System.Console.WriteLine("No Of Km :"+NoOFKm);
            System.Console.WriteLine("Date : "+Date);

        }
    }
}