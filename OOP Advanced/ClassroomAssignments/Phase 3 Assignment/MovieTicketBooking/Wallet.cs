namespace MovieTicketBooking
{
    public interface IWallet
    {
           double WalletBalance{get; set;}
           void WalletRecharge();
    }
    
}