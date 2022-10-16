namespace OnlineMedicalStore
{
    public class UserDetails
    {
        private static int s_userId=1000;
        public string  UserId{get;}
        public string UserName{get; set;}
        public int Age{get; set;}
        public long Phone{get; set;}
        public double Balance=0;
        public UserDetails(string name,int age,long phone,double balance)
        {
            s_userId++;
            UserId="UID"+s_userId;
            UserName=name;
            Age=age;
            Phone=phone;
            Balance=balance;
        }
        public UserDetails(string data)
        {
            string[] value=data.Split(',');
            s_userId=int.Parse(value[0].Remove(0,3));
            UserId=value[0];
            UserName=value[1];
            Age=int.Parse(value[2]);
            Phone=long.Parse(value[3]);
            Balance=double.Parse(value[4]);
        }
    }
}