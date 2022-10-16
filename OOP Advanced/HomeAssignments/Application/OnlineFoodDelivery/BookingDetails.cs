using System;
namespace OnlineFoodDelivery
{
    /// <summary>
    /// enum <see cref=" Booking Status "/> used to set default values
    /// </summary>
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;
        public string BookingId{get;}
        public string CustomerId{get;}
        public double TotalPrice{get; set;}
        public DateTime DateOfBooking{get; set;}
        public BookingStatus BookingStatus{get; set;}

        public BookingDetails(string customerId,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }
        public BookingDetails(string data)
        {
            string[] value = data.Split(',');
            s_bookingId = int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            CustomerId=value[1];
            TotalPrice=double.Parse(value[2]);
            DateOfBooking=DateTime.Parse(value[3]);
            BookingStatus=Enum.Parse<BookingStatus>(value[4]);
        }

    }
}