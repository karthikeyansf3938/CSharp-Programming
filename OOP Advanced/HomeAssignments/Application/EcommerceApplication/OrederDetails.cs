using System;
namespace EcommerceApplication
{
    public enum OrderStatus{Default,Oredered,cancelled}

    public class OrderDetails
    {
        private static int s_orderId=1000;
        public string OrderId{get;}

        private static int s_customerId=1000;
        public string CustomerId{get;}

        private static int s_productId=100;
        public string ProductId{get;}

        public double TotalPrice{get; set;}

        public DateTime PurchaseDate{get; set;}

        public int QuantityPurchased{get; set;}

        public OrderStatus OrederStatus{get; set;}

        public OrderDetails(string customerId,string productId,double totalPrice,DateTime purchasedate,int quantityPurchased,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            CustomerId=customerId;
            ProductId=productId;
            TotalPrice=totalPrice;
            PurchaseDate=purchasedate;
            QuantityPurchased=quantityPurchased;
            OrederStatus=orderStatus;
        }
        
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            CustomerId=values[1];
            ProductId=values[2];
            TotalPrice=double.Parse(values[3]);
            PurchaseDate=DateTime.Parse(values[4]);
            QuantityPurchased=int.Parse(values[5]);
            OrederStatus=Enum.Parse<OrderStatus>(values[6]);
        }

    }
}