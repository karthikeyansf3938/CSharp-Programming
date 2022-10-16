namespace MovieTicketBooking
{
    /// <summary>
    ///  <see cref = "ScreeningDetails"/>To get which movie is screening on these theatres
    /// </summary>
    public class ScreeningDetails
    {
        /// <summary>
        ///  <see cref = "MovieId"/>Get the unique id of the movie
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }
        /// <summary>
        /// Get the theatre Id from the theatredetails.
        /// </summary>
        /// <value></value>
        public string TheatreId { get; set; }
        /// <summary>
        ///  <see cref = "NoOfSeatsAvailable"/>Show the number of seats available in the particular theatre.
        /// </summary>
        /// <value></value>
        public int NoOfSeatsAvailable{get; set;}
        /// <summary>
        ///  <see cref = "TicketPrice"/>Set the default values for the tickets.
        /// </summary>
        /// <value></value>
        public double TicketPrice{get; set;}
        /// <summary>
        /// Organizing the object values
        /// </summary>
        /// <param name="movieId">Get the unique id</param>
        /// <param name="theatreId">get the theatre id</param>
        /// <param name="noOfSeatsAvailable">get the number of seats available in the theatre</param>
        /// <param name="ticketPrice">show the particular movie ticket price</param>
        public ScreeningDetails(string movieId,string theatreId,int noOfSeatsAvailable,double ticketPrice)
        {
            MovieId = movieId;
            TheatreId = theatreId;
            NoOfSeatsAvailable = noOfSeatsAvailable;
            TicketPrice = ticketPrice;
        }
        public ScreeningDetails(string data)
        {
            string[] value = data.Split(',');
            MovieId = value[0];
            TheatreId = value[1];
            NoOfSeatsAvailable = int.Parse(value[2]);
            TicketPrice = double.Parse(value[3]);
        }

    }
}