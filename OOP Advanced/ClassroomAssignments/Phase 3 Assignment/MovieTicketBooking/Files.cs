using System;
using System.IO;
namespace MovieTicketBooking
{
    public class Files
    {
        public static void create()
        {
            if(!Directory.Exists("TicketBooking"))
            {
                Console.WriteLine($"Folder was Created");
                Directory.CreateDirectory("TicketBooking");
            }
            if(!File.Exists("TicketBooking/UserDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("TicketBooking/UserDetails.csv");
            }
            if(!File.Exists("TicketBooking/TheatreDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("TicketBooking/TheatreDetails.csv");
            }
            if(!File.Exists("TicketBooking/MovieDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("TicketBooking/MovieDetails.csv");
            }
            if(!File.Exists("TicketBooking/ScreeningDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("TicketBooking/ScreeningDetails.csv");
            }
            if(!File.Exists("TicketBooking/BookingDetails.csv"))
            {
                Console.WriteLine($"File Created");
                File.Create("TicketBooking/BookingDetails.csv");
            }
        }
        public static void ReadFiles()
        {   
            
            //UserDetails
            string[] users = File.ReadAllLines("TicketBooking/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user = new UserDetails(data);
                Operation.UserList.Add(user);
            }

            //Theatre Details
            string[] theaters = File.ReadAllLines("TicketBooking/TheatreDetails.csv");
            foreach(string data in theaters)
            {
                TheatreDetails theatre = new TheatreDetails(data);
                Operation.TheatreList.Add(theatre);
            }
            

            //MovieDetails
            string[] movies = File.ReadAllLines("TicketBooking/MovieDetails.csv");
            foreach(string data in movies)
            {
                MovieDetails movie = new MovieDetails(data);
                Operation.MovieList.Add(movie);
            }

            //Screening Details
            string[] screenings = File.ReadAllLines("TicketBooking/ScreeningDetails.csv");
            foreach(string data in screenings)
            {
                ScreeningDetails screening = new ScreeningDetails(data);
                Operation.ScreeningList.Add(screening);
            }

            //Booking Details
            string[] bookings = File.ReadAllLines("TicketBooking/BookingDetails.csv");
            foreach(string data in bookings)
            {
                BookingDetails booking = new BookingDetails(data);
                Operation.BookingList.Add(booking);
            }
        }

        public static void WriteFiles()
        {
            //Writefiles for userDetails
            string[] userDetails = new String[Operation.UserList.Count];
            for(int i=0;i<Operation.UserList.Count;i++)
            {
                userDetails[i] = Operation.UserList[i].UserId + "," +Operation.UserList[i].Name + "," +Operation.UserList[i].Age + "," +Operation.UserList[i].PhoneNumber + "," +Operation.UserList[i].WalletBalance;
            }
            File.WriteAllLines("TicketBooking/UserDetails.csv",userDetails);

            //Theatre Details
            string[] theatreDetails = new string[Operation.TheatreList.Count];
            for(int i=0;i<Operation.TheatreList.Count;i++)
            {
                theatreDetails[i] = Operation.TheatreList[i].TheatreId + "," +Operation.TheatreList[i].TheatreName + "," +Operation.TheatreList[i].Location;
            }
            File.WriteAllLines("TicketBooking/TheatreDetails.csv",theatreDetails);

            //MovieDetails
            string[] movieDetails = new string[Operation.MovieList.Count];
            for(int i =0;i<Operation.MovieList.Count;i++)
            {
                movieDetails[i] = Operation.MovieList[i].MovieId + "," +Operation.MovieList[i].MovieName + ","  +Operation.MovieList[i].Language;
            }
             File.WriteAllLines("TicketBooking/MovieDetails.csv",movieDetails);


            //ScreeningDetails
            string[] screeningDetails = new string[Operation.ScreeningList.Count];
            for(int i = 0;i<Operation.ScreeningList.Count;i++)
            {
                screeningDetails[i] = Operation.ScreeningList[i].MovieId + "," +Operation.ScreeningList[i].TheatreId + "," +Operation.ScreeningList[i].NoOfSeatsAvailable +"," +Operation.ScreeningList[i].TicketPrice;
            }
            File.WriteAllLines("TicketBooking/ScreeningDetails.csv",screeningDetails);

            //BookingDetails
            string[] bookingDetails = new string[Operation.BookingList.Count];
            for(int i=0;i<Operation.BookingList.Count;i++)
            {
                bookingDetails[i] = Operation.BookingList[i].BookingId+ "," +Operation.BookingList[i].UserId +"," +Operation.BookingList[i].MovieId +"," +Operation.BookingList[i].TheatreId + ","  +Operation.BookingList[i].SeatCount + ","  +Operation.BookingList[i].TotalAmount + ","  +Operation.BookingList[i].BookingStatus;
            }
            File.WriteAllLines("TicketBooking/BookingDetails.csv",bookingDetails);
        }
    }
}