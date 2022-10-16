using System;
using System.IO;
namespace OnlineGroceryStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Grocery"))
            {
                Console.WriteLine($"Folder Created");
                Directory.CreateDirectory("Grocery");
            }
            if(!File.Exists("Grocery/CustomerDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("Grocery/CustomerDetails.csv");
            }
            if(!File.Exists("Grocery/ProductDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("Grocery/ProductDetails.csv");    
            }
            if(!File.Exists("Grocery/BookingDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("Grocery/BookingDetails.csv");
            }
            if(!File.Exists("Grocery/OrderDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("Grocery/OrderDetails.csv");
            }
        }

        public static void ReadFile()
        {
            string[] customers = File.ReadAllLines("Grocery/CustomerDetails.csv");
            string[] products = File.ReadAllLines("Grocery/ProductDetails.csv");
            string[] booking = File.ReadAllLines("Grocery/BookingDetails.csv");
            string[] orders = File.ReadAllLines("Grocery/OrderDetails.csv");

            foreach (string data in customers)
            {
                CustomerDetails customer = new CustomerDetails(data);
                Program.CustomerList.Add(customer);
            }
             foreach (string data in products)
            {
                ProductDetails product = new ProductDetails(data);
                Program.ProductList.Add(product);
            }
             foreach (string data in booking)
            {
                BookingDetails booking1 = new BookingDetails(data);
                Program.BookingList.Add(booking1);
            }
             foreach (string data in orders)
            {
                OrderDetails order = new OrderDetails(data);
                Program.OrderList.Add(order);
            }
        }

        public static void WriteFiles()
        {
           string[] customerDetails = new string[Program.CustomerList.Count];
           string[] productDetails = new string[Program.ProductList.Count];
           string[] bookingDetails = new string[Program.BookingList.Count];
           string[] orderDetails = new string[Program.OrderList.Count];

           for(int i=0;i<Program.CustomerList.Count;i++)
           {
            customerDetails[i] = Program.CustomerList[i].CustomerId + "," + Program.CustomerList[i].Name + "," +Program.CustomerList[i].FatherName + "," +Program.CustomerList[i].Gender + "," +Program.CustomerList[i].Phone + "," +Program.CustomerList[i].DateofBirth + "," +Program.CustomerList[i].MailId;
           }
           for(int i=0;i<Program.ProductList.Count;i++)
           {
            productDetails[i] = Program.ProductList[i].ProductId + "," + Program.ProductList[i].ProductName + "," +Program.ProductList[i].QuantityAvailable +"." +Program.ProductList[i].PriceperQuantity;
           }
           for(int i=0; i<Program.OrderList.Count; i++)
            {
                orderDetails[i] = Program.OrderList[i].OrderId + ',' +Program.OrderList[i].BookingId + ',' +  Program.OrderList[i].ProductId + ',' +Program.OrderList[i].PurchaseCount + ',' +Program.OrderList[i].PriceofOrder; 
            }
            for(int i=0; i<Program.BookingList.Count; i++)
            {
                bookingDetails[i] = Program.BookingList[i].BookingId + ',' +Program.BookingList[i].CustomerId + ',' +  Program.BookingList[i].TotalPrice + ',' +Program.BookingList[i].DateofBooking.ToString("dd/MM/yyyy") + ',' +Program.BookingList[i].BookingStatus; 
            }
            File.WriteAllLines("Grocery/CustomerDetails.csv",customerDetails);
            File.WriteAllLines("Grocery/ProductDetails.csv",productDetails);
            File.WriteAllLines("Grocery/BookingDetails.csv",bookingDetails);
            File.WriteAllLines("Grocery/OrderDetails.csv",orderDetails);
        }
        
    }
}