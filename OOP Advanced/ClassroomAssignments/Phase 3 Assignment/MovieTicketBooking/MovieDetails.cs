namespace MovieTicketBooking
{
    /// <summary>
    ///  <see cref = "MovieDetails"/>Get the movie name and language then show the details
    /// </summary>
    public class MovieDetails
    {
        /// <summary>
        /// <see cref = "MovieId"/> Get the unique movie id from the movie details
        /// </summary>
        /// <value></value>
        public string MovieId{get; set;}
        /// <summary>
        ///  <see cref = "MovieName"/>Show that particular date which movie is telecast on theatres.
        /// </summary>
        /// <value></value>
        public string MovieName{get;set;}
        /// <summary>
        /// Indicates movie language
        /// </summary>
        /// <value></value>
        public string Language{get; set;}
        /// <summary>
        ///  <see cref = "MovieDetails"/>Collect the details and create the object
        /// </summary>
        /// <param name="movieId">get the movieid from movie details</param>
        /// <param name="movieName">get the movie name</param>
        /// <param name="language">get the language of the movie</param>
        public MovieDetails(string movieId,string movieName,string language)
        {
            MovieId = movieId;
            MovieName = movieName;
            Language = language;
        }
        public MovieDetails(string data)
        {
            string[] value = data.Split(',');
            MovieId = value[0];
            MovieName = value[1];
            Language = value[2];
        }
    }
}