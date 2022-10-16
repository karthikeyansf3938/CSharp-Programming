namespace EcommerceApplication
{
    public class CustomerDetails
    {
        private static int s_customerId=1000;
        public string CustomerId{get;}

        public string Name{get; set;}

        public string City{get; set;}

        public long Phone{get; set;}

        public double Balance{get; set;}

        public string Mail{get; set;}

        public CustomerDetails(string name,string city,long phone,double balance,string mail)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            Name=name;
            City=city;
            Phone=phone;
            Balance=balance;
            Mail=mail;
        }
        
        public CustomerDetails(string data)
        {
            string[] values=data.Split(',');
            s_customerId=int.Parse(values[0].Remove(0,3));
            CustomerId=values[0];
            Name=values[1];
            City=values[2];
            Phone=long.Parse(values[3]);
            Balance=double.Parse(values[4]);
            Mail=values[5];
        }




    }
}