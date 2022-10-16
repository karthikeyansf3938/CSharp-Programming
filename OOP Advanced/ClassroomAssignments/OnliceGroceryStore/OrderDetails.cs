using System;
namespace OnlineGroceryStore
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId { get;}
        public string BookingId { get; set; }
        public string ProductId { get; set; }
        public int PurchaseCount{get; set;}
        public double PriceofOrder { get; set; }
        public OrderDetails(string bookingId,string productId,int purchaseCount,double priceofOrder)
        {
            s_orderId++;
            OrderId = "OID" + s_orderId;
            BookingId = bookingId;
            ProductId = productId;
            PurchaseCount = purchaseCount;
            PriceofOrder = priceofOrder;
        }
        public OrderDetails(string data)
        {
            string[]  value=data.Split(',');
            s_orderId = int.Parse(value[0].Remove(0,3));
            OrderId = value[0];
            BookingId = value[1];
            ProductId = value[3];
            PurchaseCount = int.Parse(value[4]);
            PriceofOrder = double.Parse(value[5]);
        }
        public void ShowOrderDetails()
        {
            Console.WriteLine($"{OrderId}\t\t{BookingId}\t\t{ProductId}\t\t{PurchaseCount}\t\t{PriceofOrder}");
        }
    }
}