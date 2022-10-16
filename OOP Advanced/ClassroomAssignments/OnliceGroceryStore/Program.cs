using System;
using System.IO;
namespace OnlineGroceryStore;

public delegate void EventManager();
public static class Program
{

    public static event EventManager eventlink=null;
    public static List<CustomerDetails> CustomerList = new List<CustomerDetails>();
    public static List<ProductDetails> ProductList = new List<ProductDetails>();
    public static List<BookingDetails> BookingList = new List<BookingDetails>();
    public static List<OrderDetails> OrderList = new List<OrderDetails>();
    public static List<OrderDetails> tempOrderList = new List<OrderDetails>();
    public static CustomerDetails currentLoginCustomer;
    public static void startEvent()
    {
        Subscribe();
        eventlink();
    }
    public static void Subscribe()
    {
        eventlink += new EventManager(Files.Create);
        //eventlink += new EventManager(Files.ReadFile);
        eventlink += new EventManager(MainMenu);
        eventlink += new EventManager(Files.WriteFiles);
    }
    public static void MainMenu()
    {   
        //AddDefaultData();
        string condition="yes";
        do
        {
            Console.WriteLine($"Main Menu");
            System.Console.WriteLine("\nSelect the Option \n1.Customer Registration \n2.Customer Login \n3.Exit");
            System.Console.WriteLine("Enter your option :");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    CustomerRegistration();
                    break;
                }
                case 2:
                {
                    CustomerLogin();
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Exiting Main Menu");
                    condition = "no";//condition breaker
                    break;
                }
            }            
        }while(condition=="yes");
    }

    public static void CustomerRegistration()
    {
        Console.WriteLine($"Registration");
        Console.WriteLine($"Enter your Name :");
        string name=Console.ReadLine();
        Console.WriteLine($"Enter your Father Name :");
        string fatherName=Console.ReadLine();
        Console.WriteLine($"Enter your Gender");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine());
        Console.WriteLine($"Enter your mobile number");
        long phone = long.Parse(Console.ReadLine());
        Console.WriteLine($"Enter your Date of Birth");
        DateTime dateOfBirth =DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Enter your Mail id");
        string mail=Console.ReadLine();
        
        CustomerDetails customer = new CustomerDetails(name,fatherName,gender,phone,dateOfBirth,mail);
        CustomerList.Add(customer);

        Console.WriteLine($"Registration Successfull..Your Customer id is {customer.CustomerId}");  
    }
    public static void CustomerLogin()
    {
        Console.WriteLine($"LogIn page");
        Console.WriteLine($"Enter your Customer Id");
        string tempLoginId = Console.ReadLine().ToUpper();
        int flag=0;
        foreach(CustomerDetails customer in CustomerList)
        {
            if(tempLoginId == customer.CustomerId)
            {
                flag=1;
                currentLoginCustomer =customer;
                Console.WriteLine($"Login Successfull");
                SubMenu();
            }
        }
        if(flag==0)
        {
            Console.WriteLine($"Invalid Input");
        }
    }
    public static void SubMenu()
    {
        string condition = "yes";
        do
        {
            Console.WriteLine($"\nSelect Option \n1.Show CustomerDetails \n2.Show Product Details \n3.Wallet Recharge \n4.Take Order \n5.Modify Order Quantity \n6.Cancel Order \n7.Exit");
            Console.WriteLine($"Enter your Option");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    Console.WriteLine($"Show CustomerDetails");
                    currentLoginCustomer.ShowDetails();
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Show Product Details");
                    ShowProductDetails();
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Wallet Recharge");
                    currentLoginCustomer.WalletRecharge();
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Take Order");
                    TakeOrder();
                    break;
                }
                case 5:
                {
                    Console.WriteLine($"Modify order Quantity");
                    ModifyOrderQuantity();
                    break;
                }
                case 6:
                {
                    Console.WriteLine($"Cancel Order");
                    CancelOrder();
                    break;
                }
                case 7:
                {
                    System.Console.WriteLine("Exit");
                    condition="no";
                    break;
                }
            }
        }while(condition=="yes");   
    }

    public static void AddDefaultData()
    {
        CustomerDetails customer2=new CustomerDetails("Ravi","Chandran",Gender.Male,978675677,new DateTime(1999/11/11),"ravi@gmail.com");
        CustomerDetails customer1=new CustomerDetails("Ravi","Kumar",Gender.Male,876517637,new DateTime(1999/11/11),"ravikumar@gmail.com");
        CustomerList.Add(customer2);
        CustomerList.Add(customer1);
        
        //Product Details
        ProductDetails product0 = new ProductDetails("Sugar",20,40);
        ProductDetails product1 = new ProductDetails("Rice",100,50);
        ProductDetails product2 = new ProductDetails("Milk",10,40);
        ProductDetails product3 = new ProductDetails("Coffee",10,10);
        ProductDetails product4 = new ProductDetails("Tea",10,10);
        ProductDetails product5 = new ProductDetails("Masala Powder",10,20);
        ProductDetails product6 = new ProductDetails("Salt",10,10);
        ProductDetails product7 = new ProductDetails("Turmeric Powder",10,25);
        ProductDetails product8 = new ProductDetails("Chilli Powder",10,20);
        ProductDetails product9 = new ProductDetails("Groundnut Oil",10,140);
        ProductList.Add(product0);
        ProductList.Add(product1);
        ProductList.Add(product2);
        ProductList.Add(product3);
        ProductList.Add(product4);
        ProductList.Add(product5);
        ProductList.Add(product6);
        ProductList.Add(product7);
        ProductList.Add(product8);
        ProductList.Add(product9);

        //Booking Details
        BookingDetails booking3 = new BookingDetails("CID3001",220,new DateTime(26/07/2022),BookingStatus.Booked);
        BookingDetails booking1 = new BookingDetails("CID3001",220,new DateTime(26/07/2022),BookingStatus.Booked);
        BookingDetails booking2 = new BookingDetails("CID3001",220,new DateTime(26/07/2022),BookingStatus.Initiated);
        BookingList.Add(booking3);
        BookingList.Add(booking1);
        BookingList.Add(booking2);

        //OrderDetails
        OrderDetails order4 = new OrderDetails("BID3001","PID101",2,80);
        OrderDetails order1 = new OrderDetails("BID3001","PID102",2,100);
        OrderDetails order2 = new OrderDetails("BID3001","PID103",1,40);
        OrderDetails order3 = new OrderDetails("BID3002","PID101",1,40);
        OrderList.Add(order4);
        OrderList.Add(order1);
        OrderList.Add(order2);
        OrderList.Add(order3);
    }
    
   public static void TakeOrder()
        {
            /*
            Show Product Details List
            Select a project & Check for Product Quanitity
            Get the Quantity & compare with Availblity
            Calculate Price and compare with Customer wallet
            Take order and create Object
            */
            string choice = "Yes";
            double totalPrice = 0;

            BookingDetails booking = new BookingDetails(currentLoginCustomer.CustomerId, 0, DateTime.Now, BookingStatus.Initiated);

            do
            {
                double amount = 0;
                int flag = 0;
                ShowProductDetails();
                Console.WriteLine($"Enter the Product ID");
                string productID = Console.ReadLine().ToUpper();

                foreach (ProductDetails product in ProductList)
                {
                    if (productID == product.ProductId)
                    {
                        flag = 1;
                        Console.WriteLine($"Enter the Quanitity you want to buy :");
                        int quanitity = int.Parse(Console.ReadLine());
                        if (product.QuantityAvailable > quanitity)
                        {
                            amount = product.PriceperQuantity * quanitity;
                            product.QuantityAvailable -= quanitity;
                            OrderDetails localOrder = new OrderDetails(booking.BookingId, productID, quanitity, amount);
                            tempOrderList.Add(localOrder);
                            Console.WriteLine($"Your Product is Added to the Cart");
                        }
                        else
                        {
                            Console.WriteLine($"Quantity is Low");
                        }
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine($"Invailed ID");
                }
                Console.WriteLine($"Do you want to buy more Product ?(Yes/No)");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");

            foreach (OrderDetails order in tempOrderList)
            {
                totalPrice += order.PriceofOrder;
            }
            Console.WriteLine($"Do you want Proceed : (Yes/no)");
            string wantToProceed = Console.ReadLine();

            if (wantToProceed == "Yes")
            {
                while (totalPrice > currentLoginCustomer.WalletBalance)
                {
                    Console.WriteLine($"You want to Recharge Imediately\nThe total Price is :{totalPrice} but your balance is :{currentLoginCustomer.WalletBalance}\nYou want {totalPrice - currentLoginCustomer.WalletBalance} amount");
                    currentLoginCustomer.WalletRecharge();
                }
                currentLoginCustomer.WalletBalance -= totalPrice;
                booking.BookingStatus = BookingStatus.Booked;
                booking.TotalPrice = totalPrice;
                OrderList.AddRange(tempOrderList);
                BookingList.Add(booking);
                Console.WriteLine($"Your Cart is Deleted");
                
                Console.WriteLine($"Your Order is Successful and Booking ID is : {booking.BookingId}");
                
            }else{
                foreach(OrderDetails order in tempOrderList){
                    foreach(ProductDetails product in ProductList){
                        product.QuantityAvailable+= order.PurchaseCount ;
                    }
                }
            }
        }
    
    public static void ModifyOrderQuantity()
    {
        System.Console.WriteLine("Modify quantity is open");
    }
    public static void CancelOrder()
    {
        System.Console.WriteLine("Cancel order is open");
    }
    public static void ShowProductDetails()
    {
        Console.WriteLine($"ProductId       ProductName         QuantityAvailable       PricePerQuantity");
        foreach(ProductDetails product in ProductList)
        {
            product.ShowProductDetails1();
        }
    }
}