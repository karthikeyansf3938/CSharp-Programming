namespace EcommerceApplication
{
    public class ProductDetails
    {
        private static int s_productId=100;
        public string ProductId{get;}

        public string ProductName{get; set;}

        public int AvailableQuantity{get; set;}

        public double PricePerQuantity{get; set;}

        public double ShippingDuration{get; set;}

        public ProductDetails(string productname, int availablequantity, double priceperquantity,double shippingduration)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productname;
            AvailableQuantity=availablequantity;
            PricePerQuantity=priceperquantity;
            ShippingDuration=shippingduration;
        }
        public ProductDetails(string data)
        {
            string[] values=data.Split(',');
            s_productId=int.Parse(values[0].Remove(0,3));
            ProductId=values[0];
            ProductName=values[1];
            AvailableQuantity=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);
            ShippingDuration=double.Parse(values[4]);
        }
    }
}