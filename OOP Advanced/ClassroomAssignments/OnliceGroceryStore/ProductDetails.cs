using System;
namespace OnlineGroceryStore
{
    public class ProductDetails
    {

        private static int s_productId=100;
        public string ProductId{get;}
        public string ProductName{get; set;}
        public int QuantityAvailable{get; set;}
        public double PriceperQuantity{get; set;}

        public ProductDetails(string productName,int quantityAvailable,double priceperQuantity)
        {
            s_productId++;
            ProductId = "PID" + s_productId;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PriceperQuantity = priceperQuantity;
        }
        public ProductDetails(string data)
        {
            string[] value = data.Split(',');
            s_productId = int.Parse(value[0].Remove(0,3));
            ProductId = value[0];
            ProductName = value[1];
            QuantityAvailable = int.Parse(value[2]);
            PriceperQuantity = double.Parse(value[3]);
        }
        public void ShowProductDetails1()
        {
            Console.WriteLine($"{ProductId}\t\t{ProductName}\t\t{QuantityAvailable}\t\t{PriceperQuantity}");    
        }
    }
}