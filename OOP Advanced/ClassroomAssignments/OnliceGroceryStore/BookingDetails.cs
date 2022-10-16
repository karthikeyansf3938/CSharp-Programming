using System;
namespace OnlineGroceryStore
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId = 3000;
        public string BookingId{get;}
        public string CustomerId{get;}
        public double TotalPrice{get; set;}
        public DateTime DateofBooking{get; set;}
        public BookingStatus BookingStatus{get; set;}
        public BookingDetails(string cutomerId,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId = "BID" + s_bookingId;
            CustomerId = cutomerId;
            TotalPrice = totalPrice;
            DateofBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
        public BookingDetails(string data)
        {
            string[] value = data.Split(',');
            s_bookingId = int.Parse(value[0].Remove(0,3));
            BookingId = value[0];
            CustomerId = value[1];
            TotalPrice = double.Parse(value[2]);
            DateofBooking = DateTime.Parse(value[3]);
            BookingStatus = Enum.Parse<BookingStatus>(value[4]);
        }
        public void ShowBookingDetails()
        {
            Console.WriteLine($"{BookingId}\t\t{CustomerId}\t\t{TotalPrice}\t\t{DateofBooking.ToShortDateString()}\t\t{BookingStatus}");
        }

    }
}