using System;
namespace MovieTicketBooking
{
    /// <summary>
    ///  <see cref = "BookingStatus"/>Set the default status
    /// </summary>
    public enum BookingStatus{Default,Booked,Cancelled}
    /// <summary>
    ///  <see cref = "BookingDetails"/>Collect the information of the bookingdetails.
    /// </summary>
    public class BookingDetails
    {
        private static int s_bookingId = 7000;
        /// <summary>
        ///  <see cref = "BookingId"/>It is an auto increment value.
        /// </summary>
        /// <value></value>
        public string BookingId{get;}
        /// <summary>
        ///  <see cref = "UserId"/>Get a information from the User Details.
        /// </summary>
        /// <value></value>
        public string UserId{get;}
        /// <summary>
        ///  <see cref = "MovieId"/>Get a object from the movie details
        /// </summary>
        /// <value></value>
        public string MovieId{get; set;}
        /// <summary>
        /// Get the theatre information from the Theatre Details.
        /// </summary>
        /// <value></value>
        public string TheatreId{get;}
        /// <summary>
        ///  <see cref = "SeatCount"/>Get the seat counts from the user
        /// </summary>
        /// <value></value>
        public int SeatCount{get; set;}
        /// <summary>
        /// Get the total Amount.
        /// </summary>
        /// <value></value>
        public double TotalAmount{get; set;}
        /// <summary>
        ///  <see cref = "BookingStatus"/>Set the status of the current status of the booking.
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus{get; set;}
        /// <summary>
        ///  <see cref = "BookingDetails"/>
        /// </summary>
        /// <param name="userId">Get the userid from the userdetails</param>
        /// <param name="movieId">get the movieid from movie details</param>
        /// <param name="theatreId">Get the theatre id from the theatredetails</param>
        /// <param name="seatCount">Get the seat count from the user</param>
        /// <param name="totalAmount">Get the total amount of the tickets</param>
        /// <param name="bookingStatus">Get the status of the booking tickets.</param>
        public BookingDetails(string userId,string movieId,string theatreId,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId = "BID" + s_bookingId;
            UserId = userId;
            MovieId = movieId;
            TheatreId = theatreId;
            SeatCount = seatCount;
            TotalAmount = totalAmount; 
            BookingStatus = bookingStatus; 
        }
        public BookingDetails(string data)
        {
            string[] value = data.Split(',');
            s_bookingId = int.Parse(value[0].Remove(0,3));
            BookingId = value[0];
            UserId = value[1];
            MovieId = value[2];
            TheatreId = value[3];
            SeatCount = int.Parse(value[4]);
            TotalAmount = double.Parse(value[5]); 
            BookingStatus =  Enum.Parse<BookingStatus>(value[6]); 
        }
    }
}