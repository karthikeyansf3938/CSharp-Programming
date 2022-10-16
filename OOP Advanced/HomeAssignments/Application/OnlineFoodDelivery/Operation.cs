using System;
using System.Collections.Generic;
namespace OnlineFoodDelivery
{
    public static class Operation
    {
        public static List<CustomerDetails> CustomerList = new List<CustomerDetails>();
        public static List<FoodDetails> FoodList = new List<FoodDetails>();
        public static List<BookingDetails> BookingList = new List<BookingDetails>();
        public static List<OrderDetails> OrderList = new List<OrderDetails>();
        public static List<PersonalInfo> UserList = new List<PersonalInfo>();

        public static CustomerDetails currentCustomer=null;
        public static void MainMenu()
        {
            Console.WriteLine($"==========Online Food Delivery==========");
            Console.WriteLine($"\nWelcome !");
            
            string choice="yes";
            do
            {
                Console.WriteLine($"\nSelect Option \n1.Registration  \n2.LogIn   \n3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine($"\n==========User Registration==========");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"\n==========LogIn==========");
                        LogIn();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"\n-*-*-*-*-*-*-*-*Exit-*-*-*-*-*-*-*-*");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
        public static void UserRegistration()
        {
            Console.WriteLine($"Enter your Name");
            string name=Console.ReadLine();
            Console.WriteLine($"Enter your Father Name");
            string fatherName=Console.ReadLine();
            Console.WriteLine($"Enter your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            Console.WriteLine($"Enter your Mobile Number");
            long phone=long.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your Mail Id");
            string mail=Console.ReadLine();
            Console.WriteLine($"Enter your Location");
            string location=Console.ReadLine();
            double walletBalance=0;
        
        

            CustomerDetails person=new CustomerDetails(name,fatherName,gender,phone,mail,location,walletBalance);
            UserList.Add(person);
            Console.WriteLine($"Your User Id is {person.CustomerId}");
        
        }
        public static void LogIn()
        {
            Console.WriteLine($"Enter your Customer Id");
            string tempId=Console.ReadLine().ToUpper();
            foreach(CustomerDetails customer in CustomerList)
            {
                if(tempId == customer.CustomerId)
                {
                    Console.WriteLine($"\nLogIn Successfull");
                    currentCustomer=customer;
                    SubMenu();
                }
            }
            
        }
        public static void SubMenu()
        {
            Console.WriteLine($"===========SubMenu===========");
            string condition="yes";
            do
            {
                Console.WriteLine($"\nSelect the Option \n1.Show Food Item Details \n2.Order Food \n3.Cancel Order  \n4.Order History \n5.Reacharge Wallet \n6.Exit");
                int option =  int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine($"============Show Food Item Details============");
                        ShowFoodItem();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"============Order Food===========");
                        OrderFood();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"=============Cancel Order=============");
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine($"==============Order History============");
                        OrderHistory();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine($"==============Recharge Wallet==============");
                        WalletRecharge();
                        break;
                    }
                    case 6:
                    Console.WriteLine($"==============LogOut=================");
                    condition="no";
                    break;
                }
            }while(condition=="yes");   
        }
        public static void ShowFoodItem()
        {
            Console.WriteLine($"FoodID  FoodName   PricePerQuantity");
            foreach(FoodDetails product in FoodList){
                Console.WriteLine($"{product.FoodId}  {product.FoodName}   {product.PricePerQuantity}");
            }
        }
        public static void OrderFood()
        {

            List<BookingDetails> tempBookingList = new List<BookingDetails>(); 
            string action = "No";
            do{
                //Show Product details
                ShowFoodItem();

                //get  food id and quantity
                Console.WriteLine($"Enter the Food ID");
                string foodId= Console.ReadLine();
            
                Console.WriteLine($"Enter the Quantity");
                int quantity = int.Parse(Console.ReadLine());

                //check available 
                foreach(FoodDetails product in FoodList){
                    if(foodId == product.FoodId){
                        double amount = product.PricePerQuantity*quantity; 
                        //wallet check balance
                        if(currentCustomer.WalletBalance >= amount){
                            BookingDetails tempBooking = new BookingDetails(currentCustomer.CustomerId,amount,DateTime.Now,BookingStatus.Booked);
                            tempBookingList.Add(tempBooking);
                            OrderDetails order = new OrderDetails(tempBooking.BookingId,foodId,quantity,amount);
                            OrderList.Add(order);
                            currentCustomer.WalletBalance -=amount;             
                        
                    }else{
                        Console.WriteLine($"Wallet Balance is Low");
                        break;
                    }
                }
            }
            Console.Write($"Do you want to Order more (Yes/No) : ");
            action = Console.ReadLine();

            }while(action == "Yes"); 

            double totalAmount =0;

            foreach(BookingDetails booking in BookingList){
                totalAmount += booking.TotalPrice;
                BookingList.Add(booking);
                if(currentCustomer.CustomerId == booking.CustomerId){
                    Console.WriteLine($"Booking successful and BookingID: {booking.BookingId}");
                }
                // if()
                // {
                //     booking.BookingStatus=BookingStatus.Booked;
                //     BookingList.Add(booking);
                //     OrderList.AddRange();
                // }
            }
                 
        }
        public static void CancelOrder()
        {
            Console.WriteLine($"BookingId       CustomerId      TotalPrice      DateOfBooking       Order Status");
            
            foreach(BookingDetails booking in BookingList)
            {
                if(currentCustomer.CustomerId==booking.CustomerId)
                {
                    Console.WriteLine($"{booking.BookingId}\t\t{booking.CustomerId}\t\t{booking.TotalPrice}\t\t{booking.DateOfBooking}\t\t{booking.BookingStatus}");
                }
            }
            Console.WriteLine($"Enter Booking Id to cancel order");
            string tempId=Console.ReadLine().ToUpper();
            foreach(BookingDetails booking1 in BookingList)
            {
                if(tempId==booking1.BookingId)
                {
                    Console.WriteLine($"OrderId     Booking Id      Food Id     Purchase Count      PriceOfOrder");
                    
                    foreach(OrderDetails order in OrderList)
                    {
                        Console.WriteLine($"{order.OrderId}\t\t{order.BookingId}\t\t{order.FoodId}\t\t{order.PurchaseCount}\t\t{order.PriceOfOrder}");
                    }
                    Console.WriteLine($"Enter Order Id to cancel");
                    string tempOrder=Console.ReadLine();
                    foreach(OrderDetails order1 in OrderList)
                        if(tempOrder==order1.OrderId)
                        {
                            currentCustomer.WalletBalance-=order1.PriceOfOrder;
                            order1.PurchaseCount=0;
                            order1.PriceOfOrder=0;
                            
                        }
                  
                }
                else
                {
                    Console.WriteLine($"Your Booking Id is invalid...");
                    
                }
            }
            
        }
        public static void OrderHistory()
        {
            Console.WriteLine($"BookingId       CustomerId      TotalPrice      DateOfBooking       Order Status");
            
            foreach(BookingDetails booking in BookingList)
            {
                if(currentCustomer.CustomerId==booking.CustomerId)
                {
                    Console.WriteLine($"{booking.BookingId}\t\t{booking.CustomerId}\t\t{booking.TotalPrice}\t\t{booking.DateOfBooking}\t\t{booking.BookingStatus}");
                }
            }
        }
        public static void WalletRecharge()
        {
            string condition="yes";
            System.Console.WriteLine("If you want to add the amount to Wallet(yes/no)");
            condition=Console.ReadLine();
            while(condition=="yes")
            { 
                System.Console.WriteLine("How much amount you want to add");
                double amount=double.Parse(Console.ReadLine());
                currentCustomer.WalletBalance+=amount;
                System.Console.WriteLine("Your Wallet Balance is "+currentCustomer.WalletBalance);
                System.Console.WriteLine("If you want to add the amount to Wallet(yes/no)");
                condition=Console.ReadLine();
                System.Console.WriteLine("Balance "+currentCustomer.WalletBalance);
            }
        }
        
    }
}