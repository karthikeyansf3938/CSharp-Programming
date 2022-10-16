using System;
namespace OnlineMedicalStore;

public delegate void EventManager(); //user defind delegate
public static class Operation
{
    private static string _eventName;
    public static event EventManager eventlink=null;
    public static void Subscribe()
    {
        eventlink += new EventManager(Files.Create);
        eventlink += new EventManager(Files.ReadFile);
        eventlink += new EventManager(Operation.MainMenu);
        eventlink += new EventManager(Files.WriteToFiles);
    }
    public static void StartEvent()
    {
        Subscribe();
        eventlink();
    }
    public static List<UserDetails> UserList=new List<UserDetails>();
    public static List<MedicineDetails> MedicineList=new List<MedicineDetails>();
    public static List<OrderDetails> OrderList=new List<OrderDetails>();
    public static UserDetails currentUser=null;
    public static void MainMenu()
    {
        Console.WriteLine($"==========Online Medical Store==========");
        Console.WriteLine($"\nWelcome !");
        
        string choice="yes";
        
        
        do
        {
            Console.WriteLine($"Select Option \n1.Registration  \n2.LogIn   \n3.Order History \n4.Exit");
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
                    Console.WriteLine($"\n==========Order History==========");
                    OrderHistory();
                    break;
                }
                case 4:
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
        Console.WriteLine($"Enter your Age");
        int age=int.Parse(Console.ReadLine());
        Console.WriteLine($"Enter your Mobile Number");
        long phone=long.Parse(Console.ReadLine());
        double balance=0;
        System.Console.WriteLine("Blanace :"+balance);

        UserDetails user=new UserDetails(name,age,phone,balance);
        UserList.Add(user);
        Console.WriteLine($"Your User Id is {user.UserId}");
        
    }
    public static void LogIn()
    {
        System.Console.WriteLine("Enter your UserId");
        string tempId=Console.ReadLine().ToUpper();

        foreach(UserDetails user in UserList)
        {
            if(tempId==user.UserId)
            {
                Console.WriteLine($"LogInSuccessfull");
                currentUser=user;
                SubMenu();
            }
        }
        
    }
    public static void SubMenu()
    {
        Console.WriteLine($"\n==========SubMenu==========");
        string choice="yes";

        do
        {
            Console.WriteLine($"Select the Option \n1.Show Medicine List \n2.Purchase Medicine \n3.Cancel Purchase \n4.Show Purchase history \n5.Recharge \n6.Logout");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine($"==========Medicine List==========");
                    Console.WriteLine($"Medicine Id\tMedicine Name\t\tAvailable Count\t\tPrice\tDateOfExpiry");
                    
                    foreach (MedicineDetails medicine in MedicineList)
                    {
                        Console.WriteLine($"{medicine.MedicineId}\t\t{medicine.MedicineName}\t\t\t{medicine.AvailableCount}\t\t{medicine.Price}\t\t{medicine.DateofExpiry.ToShortDateString()}"); 
                    }
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"\n==========Purchase Medicine==========");
                    PurchaseMedicine();
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"\n==========Cancel Order==========");
                    CancelOrder();
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"\n==========Show Purchase History==========");
                    ShowHistory();
                    break;
                }
                case 5:
                {
                    Console.WriteLine($"\n==========Wallet Recharge==========");
                    Recharge();
                    break;
                }
                case 6:
                {
                    Console.WriteLine($"\n==========LogOut==========");
                    choice="no";
                    break;
                }

            }
        }while(choice=="yes");
    }
    public static void PurchaseMedicine()
    {
        Console.WriteLine($"==========Medicine List==========");
        Console.WriteLine($"Medicine Id\tMedicine Name\t\tAvailable Count\t\tPrice\tDateOfExpiry");
        
        foreach (MedicineDetails medicine in MedicineList)
        {
            Console.WriteLine($"{medicine.MedicineId}\t\t{medicine.MedicineName}\t\t{medicine.AvailableCount}\t\t{medicine.Price}\t\t{medicine.DateofExpiry.ToShortDateString()}"); 
        }
        //get data from User
        Console.WriteLine($"Enter Medicine Id which you want to buy :");
        string tempId=Console.ReadLine().ToUpper();

        Console.WriteLine($"Enter the number of count of the medicine :");
        int number=int.Parse(Console.ReadLine());
        

        foreach(MedicineDetails medicine1 in MedicineList)
        {
            if(tempId==medicine1.MedicineId && number<=medicine1.AvailableCount)
            {
               double totalPrice=number*medicine1.Price;
               if(currentUser.Balance<totalPrice)
               {
                    System.Console.WriteLine("Insufficient Balnce \nPlease Reacharge Your Wallet");
               }
               else
               {
                    currentUser.Balance-=totalPrice;
                    medicine1.AvailableCount-=number;
                    DateTime orderDate=DateTime.Now;

                    OrderDetails order=new OrderDetails(currentUser.UserId,medicine1.MedicineId,number,totalPrice,orderDate,OrderStatus.Purchased);
                    OrderList.Add(order);
                    System.Console.WriteLine("Order Placed Successfully..!");
                    Console.WriteLine($"Your Order Id is {order.OrderId}");
               }  
            }
        }
        
    }

    public static void CancelOrder()
    {
         System.Console.WriteLine($"OrderId\tUserId\tMedicineId\tMedicineCount\tTotalPice\tOrderDate\tOrderStatus");
            foreach(OrderDetails order in OrderList)
            {
                if(currentUser.UserId==order.UserId)
                {
                    System.Console.WriteLine($"{order.OrderId}\t{order.UserId}\t{order.MedicineId}\t{order.MedicineCount}\t{order.TotalPrice}\t{order.OrderDate}\t{order.OrderStatus}");
                }
            }
            Console.WriteLine($"Enter the id to cancel:");
            string orderId=Console.ReadLine().ToUpper();

            foreach(OrderDetails order in OrderList)
            {
                if(orderId==order.OrderId)
                {
                    foreach(MedicineDetails medicine in MedicineList)
                    {
                        if(order.MedicineId==medicine.MedicineId)
                        {
                            currentUser.Balance+=order.TotalPrice;
                            System.Console.WriteLine("Your order cancel successfully");
                            medicine.AvailableCount=medicine.AvailableCount+order.MedicineCount;

                            currentUser.Balance=currentUser.Balance+order.TotalPrice;
                            order.OrderStatus=OrderStatus.Cancelled;
                        }
                    }
                }
            }
    }

public static void ShowHistory()
{
    System.Console.WriteLine($"OrderId UserId MedicineId MedicineCount TotalPice OrderDate OrderStatus");
    foreach(OrderDetails order in OrderList)
    {
        if(currentUser.UserId==order.UserId)
        {
            System.Console.WriteLine($"{order.OrderId}  {order.UserId}  {order.MedicineId}   {order.MedicineCount}  {order.TotalPrice}  {order.OrderDate}   {order.OrderStatus}");
        }
    }
}
public static void Recharge()
{
    {
           
            string condition="yes";
            System.Console.WriteLine("If you want to add the amount to Wallet(yes/no)");
            condition=Console.ReadLine();
            while(condition=="yes")
            { 
                System.Console.WriteLine("How much amount you want to add");
                double amount=double.Parse(Console.ReadLine());
                currentUser.Balance+=amount;
                System.Console.WriteLine("Your Wallet Balance is "+currentUser.Balance);
                System.Console.WriteLine("Do you want to add the amount to Wallet(yes/no)");
                condition=Console.ReadLine();
                System.Console.WriteLine("Balance "+currentUser.Balance);
            }
           
        }
}
public static void OrderHistory()
{
   System.Console.WriteLine($"OrderId UserId MedicineId MedicineCount TotalPice OrderDate OrderStatus");
    foreach(OrderDetails order in OrderList)
    {
        {
            System.Console.WriteLine($"{order.OrderId}  {order.UserId}  {order.MedicineId}   {order.MedicineCount}  {order.TotalPrice}  {order.OrderDate}   {order.OrderStatus}");
        }
    }
}


}
