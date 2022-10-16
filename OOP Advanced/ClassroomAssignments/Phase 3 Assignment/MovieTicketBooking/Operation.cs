using System;
using System.IO;
namespace MovieTicketBooking
{
    public delegate void  EventManger();
    public static class Operation
    {
        public static event EventManger eventlink=null;
        public static List<UserDetails> UserList = new List<UserDetails>();
        public static List<BookingDetails> BookingList = new List<BookingDetails>();
        public static List<TheatreDetails> TheatreList = new List<TheatreDetails>();
        public static List<MovieDetails> MovieList = new List<MovieDetails>();
        public static List<ScreeningDetails> ScreeningList = new List<ScreeningDetails>();

        static UserDetails currentUser;
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
        public static void Subscribe()
        {
            eventlink += new EventManger(Files.create);
            eventlink += new EventManger(Files.ReadFiles);
            eventlink += new EventManger(Operation.MaiMenu);
            eventlink += new EventManger(Files.WriteFiles);
        }
        public static void MaiMenu()
        {
            Console.WriteLine($"Welcome to the Ticket booking application");
            Console.WriteLine($"===========MainMenu===========");
            
            string condition = "yes";

            do
            {
                Console.WriteLine($"\nSelect the Option \n1.User registration \n2.Login and Purchase \n3.Exit");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine($"============User Registration============");
                        UserRegistration();
                        break; 
                    }
                    case 2:
                    {
                        Console.WriteLine($"============Login============");
                        LogIn();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"============Exit============");
                        condition = "no";
                        break;
                    }
                }
                
            }while(condition=="yes");
            
        }
        public static void UserRegistration()
        {
            //Get the data from the user and set walletbalance = 0
            Console.WriteLine($"Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter your Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your Phone Number");
            long phoneNumber = long.Parse(Console.ReadLine());
            double walletBalance = 0;

            //create object and store the object in list
            UserDetails user = new UserDetails(name,age,phoneNumber,walletBalance);
            UserList.Add(user);
            Console.WriteLine($"User Added Successfully");
            Console.WriteLine($"Your User id is {user.UserId}");
        }
        public static void LogIn()
        {
            Console.WriteLine($"Enter your UserId");
            string tempUserId = Console.ReadLine().ToUpper();

            foreach(UserDetails user in UserList)
            {
                if(tempUserId == user.UserId)
                {
                    Console.WriteLine($"Login Succussfully..!");
                    currentUser = user;
                    SubMenu(); 
                }
            }
        }

        public static void SubMenu()
        {
            Console.WriteLine($"\n============SubMenu============");

            string condition = "yes";

            do
            {
                Console.WriteLine($"\nSelect the Option \n1.Ticket Booking \n2.Ticket Cancellation \n3.Booking History \n4.WalletRecharge \n5.Exit");
                int option = int .Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine($"============Ticket Booking============");
                        TicketBooking();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"============Ticket Cancellation============");
                        CancelTicket();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"============Booking Order============");
                        BookingOrder();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine($"============Wallet Recharge============");
                        currentUser.WalletRecharge();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine($"============LogOut============");
                        condition = "no";
                        break;
                    }
                }          
            }while(condition == "yes");
            
        }

        public static void TicketBooking()
        {
            int flag3=0,flag2=0,flag=0;;
            //Show theatre details
            ShowTheatre();
            //Get the theatre Id
            Console.WriteLine($"Enter the theatre id you want book ticket");
            string tempTheatreId = Console.ReadLine().ToUpper();
    
            //Show Screening Details
            Console.WriteLine($"============Screening Details============");
            Console.WriteLine($"MovieId     TheatreId       TicketPrice     SeatAvailability");
            foreach(ScreeningDetails screening in ScreeningList)
            {
                if(tempTheatreId == screening.TheatreId)
                {
                    flag=1;
                    Console.WriteLine($"{screening.MovieId}\t\t{screening.TheatreId}\t\t{screening.TicketPrice}\t\t{screening.NoOfSeatsAvailable}");
                }
            }
            if(flag==0)
            {
                Console.WriteLine($"Invalid theatre id");
            }
            
            Console.WriteLine($"Enter the movie id to book the ticket");
            string tempMovieId = Console.ReadLine().ToUpper();
            Console.WriteLine($"How much ticket you want..");
            int seatCount = int.Parse(Console.ReadLine());
            foreach(ScreeningDetails screening1 in ScreeningList)
            {
                if(tempMovieId == screening1.MovieId)
                {
                    flag2=1;
                    if(seatCount <= screening1.NoOfSeatsAvailable)
                    {   
                        flag3=1;
                        double totalAmount = (seatCount * screening1.TicketPrice) + 0.8;
                        string condition="yes";
                        while(condition == "yes")
                        {
                            if(currentUser.WalletBalance >= totalAmount)
                            {   
                                 Console.WriteLine($"Insufficient Balance..Please Recharge the wallet");
                                currentUser.WalletRecharge();

                                currentUser.WalletBalance -= totalAmount;
                                screening1.NoOfSeatsAvailable -= seatCount;
                                BookingDetails booking = new BookingDetails(currentUser.UserId,tempMovieId,tempTheatreId,seatCount,totalAmount,BookingStatus.Booked);
                                BookingList.Add(booking);
                                Console.WriteLine($"Booking was succussfully \nYour Booking id is {booking.BookingId}");
                                condition="no";
                            }
                        }
                    } 
                }
            }  
            if(flag2!= 1)
            {
                Console.WriteLine($"Invalid MovieId");
            } 
            if(flag3!=1)
            {
                Console.WriteLine($"Required Seat count not available..");  
            }
        }
        public static void ShowTheatre()
        {
            Console.WriteLine($"============Theatre Details============");
            Console.WriteLine($"\nTheatreId     TheatreName        Location");
            foreach(TheatreDetails theatre in TheatreList)
            {
                Console.WriteLine($"{theatre.TheatreId}\t\t{theatre.TheatreName}\t\t{theatre.Location}");  
            }
        }
        public static void CancelTicket()
        {
            int flag = 0;
            BookingOrder();
            Console.WriteLine($"Enter the booking id to cancel the ticket");
            string tempBookingId = Console.ReadLine().ToUpper();
            foreach(BookingDetails booking1 in BookingList)
            {
                if(tempBookingId == booking1.BookingId)
                {
                    flag = 0;
                    foreach(ScreeningDetails screening in ScreeningList)
                    {
                        screening.NoOfSeatsAvailable +=booking1.SeatCount;
                        currentUser.WalletBalance += booking1.TotalAmount - 20;
                        BookingDetails booking = new BookingDetails(currentUser.UserId,booking1.MovieId,booking1.TheatreId,booking1.SeatCount,booking1.TotalAmount,BookingStatus.Cancelled);
                        BookingList.Add(booking);
                    }
                }
            } 
            if(flag == 1)
            {
                Console.WriteLine($"Invalid Booking Id");
            }
            else
            {
                Console.WriteLine($"Ticket was cancelled Succussfully...");
            }
        }
        public static void BookingOrder()
        {
            Console.WriteLine($"============BookingDetails============");
            Console.WriteLine($"BookingId       UserId      MovieId     TheatreId       SeatCount       Total Amout     BookingStatus");
            foreach(BookingDetails booking in BookingList)
            {
                if(currentUser.UserId ==  booking.UserId)
                {
                    Console.WriteLine($"{booking.BookingId}\t\t{booking.UserId}\t\t{booking.MovieId}\t\t{booking.TheatreId}\t\t{booking.SeatCount}\t\t{booking.TotalAmount}\t\t{booking.BookingStatus}");
                }
            }
        }
    }
}