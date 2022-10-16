using System.IO;
using System;
namespace OnlineFoodDelivery
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("FoodDelivery"))
            {
                Console.WriteLine($"Creating Folder");
                Directory.CreateDirectory("FoodDelivery");
            }
             if(!File.Exists("FoodDelivery/CustomerDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("FoodDelivery/CustomerDetails.csv");
            }
            if(!File.Exists("FoodDelivery/FoodDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("FoodDelivery/FoodDetails.csv");
            }
            if(!File.Exists("FoodDelivery/OrderDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("FoodDelivery/OrderDetails.csv");  
            }
            if(!File.Exists("FoodDelivery/BookingDetails.csv"))
            {
                File.Create("FoodDelivery/BookingDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] customers=File.ReadAllLines("FoodDelivery/CustomerDetails.csv");
            string[] foods=File.ReadAllLines("FoodDelivery/FoodDetails.csv");
            string[] orders=File.ReadAllLines("FoodDelivery/OrderDetails.csv");
            string[] bookings=File.ReadAllLines("FoodDelivery/BookingDetails.csv");
            
             foreach(String data in customers)
            {
                CustomerDetails customer=new CustomerDetails(data);
                Operation.CustomerList.Add(customer);
            }
            foreach(string data in foods)
            {
                FoodDetails food = new FoodDetails(data);
                Operation.FoodList.Add(food);
            }
             foreach(String data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operation.OrderList.Add(order);
            }
            foreach(string data in bookings)
            {
                BookingDetails booking = new BookingDetails(data);
                Operation.BookingList.Add(booking);
            }
        }
        public static void WriteToFiles()
        {
            string[] customerDetails = new string[Operation.CustomerList.Count];
            string[] foodDetails = new string[Operation.FoodList.Count];
            string[] orderDetails = new string[Operation.OrderList.Count];
            string[] bookingDetails = new string[Operation.BookingList.Count];
             for(int i=0;i<Operation.CustomerList.Count;i++)
            {
                customerDetails[i]=Operation.CustomerList[i].CustomerId+","+Operation.CustomerList[i].WalletBalance+","+Operation.CustomerList[i].Name+","+Operation.CustomerList[i].FatherName+","+Operation.CustomerList[i].Gender + "," +Operation.CustomerList[i].Phone + "," +Operation.CustomerList[i].DOB.ToShortDateString() + "," +Operation.CustomerList[i].Mail +","+Operation.CustomerList[i].Location + "," +Operation.CustomerList[i].WalletBalance;
            }
            for (int i=0;i<Operation.FoodList.Count;i++)
            {
                foodDetails[i]=Operation.FoodList[i].FoodId + "," +Operation.FoodList[i].FoodName + "," +Operation.FoodList[i].PricePerQuantity;
            }
             for(int i=0;i<Operation.OrderList.Count;i++)
            {
                orderDetails[i]=Operation.OrderList[i].OrderId+","+Operation.OrderList[i].BookingId+","+Operation.OrderList[i].FoodId+","+Operation.OrderList[i].PurchaseCount+","+Operation.OrderList[i].PriceOfOrder;
            }
            for(int i=0;i<Operation.BookingList.Count;i++)
            {
                bookingDetails[i]=Operation.BookingList[i].BookingId + "," +Operation.BookingList[i].CustomerId + "," +Operation.BookingList[i].TotalPrice + "," +Operation.BookingList[i].DateOfBooking + ", " +Operation.BookingList[i].BookingStatus;
            }
            File.WriteAllLines("FoodDelivery/CustomerDetails.csv",customerDetails);
            File.WriteAllLines("FoodDelivery/FoodDetails.csv",foodDetails);
            File.WriteAllLines("FoodDelivery/OrderDetails.csv",orderDetails);
            File.WriteAllLines("FoodDelivery/BookingDetails.csv",bookingDetails);
        }
        
    }
}