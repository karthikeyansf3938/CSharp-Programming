namespace MovieTicketBooking
{
    /// <summary>
    /// <see cref = "TheatreDetails"/>Collect the theatre name, location and create auto increment for the individual data.
    /// </summary>
    public class TheatreDetails
    {
        private static int s_theatreId = 300;
        /// <summary>
        /// <see cref = "TheatreId"/>Get a individual id for the object
        /// </summary>
        /// <value></value>
        public string TheatreId{get;}
        /// <summary>
        /// <see cref = "TheatreName"/>Get the object values.
        /// </summary>
        /// <value></value>
        public string TheatreName{get; set;}
        /// <summary>
        ///  <see cref = "Location"/>Get the object values.
        /// </summary>
        /// <value></value>
        public string Location{get; set;}
        /// <summary>
        ///  <see cref = "TheatreDetails"/>collect the object values
        /// </summary>
        /// <param name="theatreName">Get the ThetreDatails and store in the object</param>
        /// <param name="location">Get the Theatre and store the object</param>
        public TheatreDetails(string theatreName,string location)
        {
            s_theatreId++;
            TheatreId = "TID" + s_theatreId;
            TheatreName = theatreName;
            Location = location;
        }
        public TheatreDetails(string data)
        {
            string[] value = data.Split(',');
            s_theatreId = int.Parse(value[0].Remove(0,3));
            TheatreId = value[0];
            TheatreName = value[1];
            Location = value[2];
        }
    }
}