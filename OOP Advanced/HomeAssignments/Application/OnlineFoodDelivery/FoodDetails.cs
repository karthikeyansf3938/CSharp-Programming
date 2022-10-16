namespace OnlineFoodDelivery
{
    public class FoodDetails
    {
        private static int s_foodId=100;
        public string FoodId{get; set;}

        public string FoodName{get; set;}
        public double PricePerQuantity{get; set;}
        public FoodDetails(string foodName,double price)
        {
            s_foodId++;
            FoodId="FID"+s_foodId;
            FoodName=foodName;
            PricePerQuantity=price;
        }
         public FoodDetails(string data)
        {
            string[] value = data.Split(',');
            s_foodId = int.Parse(value[0].Remove(0,3));
            FoodId=value[0];
            FoodName=value[1];
            PricePerQuantity=double.Parse(value[2]);
        }
    }
}