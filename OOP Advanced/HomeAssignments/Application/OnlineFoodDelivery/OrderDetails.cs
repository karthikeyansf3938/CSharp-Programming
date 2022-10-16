namespace OnlineFoodDelivery
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId{get;}
        public string BookingId{get;}
        public string FoodId{get; set;}
        public int PurchaseCount{get;set;}
        public double PriceOfOrder{get; set;}

        public OrderDetails(string bookingId,string foodId,int purchaseCount,double priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            FoodId=foodId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
        public OrderDetails(string data)
        {
            string[] value=data.Split(',');
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            BookingId=value[1];
            FoodId=value[2];
            PurchaseCount=int.Parse(value[3]);
            PriceOfOrder=double.Parse(value[4]);
        }
    }
}