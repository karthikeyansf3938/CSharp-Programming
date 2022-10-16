using System;
using System.IO;
namespace EcommerceApplication;
public static class Files
{
    public static void Create()
    {
        if(!Directory.Exists("Ecommerce"))
        {
            Console.WriteLine("Creating a folder");
            Directory.CreateDirectory("Ecommerce");
        }
        if(!File.Exists("Ecommerce/CustomerDetails.csv"))
        {
            Console.WriteLine("Creating File");
            File.Create("Ecommerce/CustomerDetails.csv");  
        }
        if(!File.Exists("Ecommerce/ProductDetails.csv"))
        {
            Console.WriteLine("Creating File");
            File.Create("Ecommerce/ProductDetails.csv");
        }
        if(!File.Exists("Ecommerce/OrderDetails.csv"))
        {
            Console.WriteLine($"Creating File");
            File.Create("Ecommerce/OrderDetails.csv");
        }
    }
     public static void ReadFile()
        {
            string[] customers=File.ReadAllLines("Ecommerce/CutomerList.csv");
            string[] products=File.ReadAllLines("Ecommerce/ProductList.csv");
            string[] orders=File.ReadAllLines("Ecommerce/OrderList.csv");
            
            foreach(String data in customers)
            {
                CustomerDetails customer=new CustomerDetails(data);
                Operation.CustomerList.Add(customer);
            }
             foreach(String data in products)
            {
                ProductDetails product=new ProductDetails(data);
                Operation.ProductList.Add(product);
            }
             foreach(String data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operation.OrderList.Add(order);
            }
        }
        public static void WriteFiles()
        {
            string[] customerDetails = new string[Operation.CustomerList.Count];
            string[] productDetails = new string[Operation.ProductList.Count];
            string[] orderDetails = new string[Operation.OrderList.Count];
            for(int i=0;i<Operation.CustomerList.Count;i++)
            {
                customerDetails[i]=Operation.CustomerList[i].CustomerId+","+Operation.CustomerList[i].Name+","+Operation.CustomerList[i].City+","+Operation.CustomerList[i].Phone+","+Operation.CustomerList[i].Balance+","+Operation.CustomerList[i].Mail;
            }
            for(int i=0;i<Operation.ProductList.Count;i++)
            {
                productDetails[i]=Operation.ProductList[i].ProductId+","+Operation.ProductList[i].ProductName+","+Operation.ProductList[i].AvailableQuantity+","+Operation.ProductList[i].PricePerQuantity+","+Operation.ProductList[i].ShippingDuration;
            }
            for(int i=0;i<Operation.OrderList.Count;i++)
            {
                orderDetails[i]=Operation.OrderList[i].OrderId+","+Operation.OrderList[i].CustomerId+","+Operation.OrderList[i].ProductId+","+Operation.OrderList[i].TotalPrice+","+Operation.OrderList[i].PurchaseDate+","+Operation.OrderList[i].QuantityPurchased;
            }
            File.WriteAllLines("Ecommerce/CustomerDetails.csv",customerDetails);
            File.WriteAllLines("Ecommerce/ProductDetails.csv",productDetails);
            File.WriteAllLines("Ecommerce/OrderDetails.csv",orderDetails);
        }
}