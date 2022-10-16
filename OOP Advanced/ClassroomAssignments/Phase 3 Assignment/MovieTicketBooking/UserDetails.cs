using System;
namespace MovieTicketBooking
{
    /// <summary>
    /// <see cref = "UserDetails"/>Inherit the Personal Details class and wallet Interface
    /// </summary>
    public  class UserDetails : PersonalDetails,IWallet
    {
        /// <summary>
        /// <see cref = "s_userId"/> Generate the Auto increment
        /// </summary>
        private static int s_userId=1000;
        public string UserId{get;}
        /// <summary>
        /// <see cref = "WalletBalance"/> Get the wallet values
        /// </summary>
        /// <value></value>
        public double WalletBalance{get; set;}

        /// <summary>
        /// <see cref = "UserDetails"/>Get the values from the personal and wallet balance
        /// </summary>
        /// <param name="name">Get the name in string data type</param>
        /// <param name="age">Get the age in int type</param>
        /// <param name="phoneNumber">Get the phone number in long type</param>
        /// <param name="walletBalance">Set a walletBalance is zero</param>
        public UserDetails(string name,int age,long phoneNumber,double walletBalance)
        {
            s_userId++;
            UserId = "UID" + s_userId;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            WalletBalance = walletBalance;
        }
        public UserDetails(string data)
        {
            string[] value = data.Split(',');
            s_userId = int.Parse(value[0].Remove(0,3));
            UserId = value[0];
            Name = value[1];
            Age = int.Parse(value[2]);
            PhoneNumber = long.Parse(value[3]);
            WalletBalance = double.Parse(value[4]);
        }
        /// <summary>
        /// <see cref = "WalletRecharge"/>It is used to add the amount to Wallet.
        /// </summary>
        public void WalletRecharge()
        {
            string action = "yes";
            do
            {
                Console.WriteLine($"Enter the amount you want to recharge");
                double amount = double.Parse(Console.ReadLine());
                
                WalletBalance += amount;
                Console.WriteLine($"Your Wallet Balance Is "+WalletBalance);
                

                Console.WriteLine($"Do you want recharge again(yes/no)");
                action = Console.ReadLine();
            }while(action=="yes");
        }
    }
}