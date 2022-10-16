using System;
using System.Collections.Generic;

namespace EcommerceApplication;

    public static class Operation
    {
        public static List<CustomerDetails> CustomerList=new List<CustomerDetails>();
        public static List<ProductDetails> ProductList=new List<ProductDetails>();

        public static List<OrderDetails> OrderList=new List<OrderDetails>();

        static CustomerDetails currentCustomer=null;
        static ProductDetails currentProduct=null;

        static OrderDetails currenetOrder=null;
       public static void MainMenu()
       {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select option 1.Registration 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login Portal");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="No";
                        break;
                    }
                }
            }while(choice=="yes");
            
       }
        public static void Registration()
        {
            System.Console.WriteLine("Enter Your Name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your City");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your phone number");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your walletbalance");
            double balance=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail");
            string mail=Console.ReadLine();

            CustomerDetails customer=new CustomerDetails(name,city,phone,balance,mail);
            CustomerList.Add(customer);
            System.Console.WriteLine("Registration Successfull");
            System.Console.WriteLine("Your Customer Id is :"+customer.CustomerId);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Customer Id :");
            string customerid=Console.ReadLine().ToUpper();
            foreach(CustomerDetails customer in CustomerList)
            {
                if(customer.CustomerId==customerid)
                {
                    System.Console.WriteLine("Login successfull");
                    currentCustomer=customer;
                    subMenu();
                }
            }
        } 
        public static void subMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select SubMenu Option 1.Purchase 2.Oredr History 3.Cancel Order 4.Wallet Balance 5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("-----Purchase-----");
                        Purchase();
                        break;
                    }       
                    case 2:
                    {  
                        System.Console.WriteLine("-----Order History-----");
                        OrderHistory();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("-----Cancel Order-----");
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Balance:"+currentCustomer.Balance);
                        WalletBalance();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("LogOut");
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");   
        }
        public static void Purchase()
        {
            
            System.Console.WriteLine("Product Details");
            System.Console.WriteLine("ProductId         Productname        AvailableQuantity      PricePerQuantity        ShippingDuration");
            foreach (ProductDetails product in ProductList)
            {
                System.Console.WriteLine($"{product.ProductId}             {product.ProductName}                {product.AvailableQuantity}                    {product.PricePerQuantity}              {product.ShippingDuration}");
            }


            System.Console.WriteLine("Choose the product then enter that product id");
            string productId=Console.ReadLine().ToUpper();

            System.Console.WriteLine("Enter the quantity of product");
            int quantityPurchased=int.Parse(Console.ReadLine());


            foreach(ProductDetails product in ProductList)
            {
                if(productId==product.ProductId && quantityPurchased<=product.AvailableQuantity)
                {
                    currentProduct=product;
                    double deliveryCharge=50;
                    double totalPrice=(quantityPurchased * product.PricePerQuantity)+deliveryCharge;

                    if(currentCustomer.Balance<totalPrice)
                    {
                        System.Console.WriteLine("Insufficient Amount..Please reacharge your wallet");
                    }
                    else
                    {
                        currentCustomer.Balance-=totalPrice;
                        currentProduct.AvailableQuantity-=quantityPurchased;

                        DateTime date=DateTime.Now;
                        DateTime shippingdate=date.AddDays(product.ShippingDuration);
                        OrderDetails order=new OrderDetails(currentCustomer.CustomerId,currentProduct.ProductId,totalPrice,date,quantityPurchased,OrderStatus.Oredered);
                        OrderList.Add(order);
                        System.Console.WriteLine("Order placed Successfully..!");
                        System.Console.WriteLine("Your Oreder id is :"+order.OrderId);
                    }
                }
            }
        }
        public static void CancelOrder()
        {
            System.Console.WriteLine($"OrderId CustomerId ProductId TotalPrice PurchaseDate QuantityPurchased OrderStatus");
            foreach(OrderDetails order in OrderList)
            {
                if(currentCustomer.CustomerId==order.CustomerId)
                {
                    System.Console.WriteLine($"{order.OrderId}  {order.CustomerId}  {order.ProductId}   {order.TotalPrice}  {order.PurchaseDate.ToShortDateString}  {order.OrederStatus}");
                }
            }
            Console.WriteLine($"Enter the id to cancel:");
            string orderId=Console.ReadLine().ToUpper();

            foreach(OrderDetails order in OrderList)
            {
                if(orderId==order.OrderId)
                {
                    foreach(ProductDetails product in ProductList)
                    {
                        if(order.ProductId==product.ProductId)
                        {
                            System.Console.WriteLine("Your order cancel successfully");
                            product.AvailableQuantity=product.AvailableQuantity+1;

                            currentCustomer.Balance=currentCustomer.Balance+order.TotalPrice;
                            order.OrederStatus=OrderStatus.cancelled;
                        }
                    }
                }
            }
        }
        public static void WalletBalance()
        {
           
            string condition="yes";
            System.Console.WriteLine("If you want to add the amount to Wallet(yes/no)");
            condition=Console.ReadLine();
            while(condition=="yes")
            { 
                System.Console.WriteLine("How much amount you want to add");
                double amount=double.Parse(Console.ReadLine());
                currentCustomer.Balance+=amount;
                System.Console.WriteLine("Your Wallet Balance is "+currentCustomer.Balance);
                System.Console.WriteLine("If you want to add the amount to Wallet(yes/no)");
                condition=Console.ReadLine();
                System.Console.WriteLine("Balance "+currentCustomer.Balance);
            }
           
        }
        public static void OrderHistory()
        {
            System.Console.WriteLine($"OrderId CustomerId ProductId TotalPrice PurchaseDate  OrderStatus");
            foreach(OrderDetails order in OrderList)
            {
                if(currentCustomer.CustomerId==order.CustomerId)
                {
                    System.Console.WriteLine($"{order.OrderId}  {order.CustomerId}  {order.ProductId}   {order.TotalPrice}  {order.PurchaseDate.ToShortDateString()}  {order.OrederStatus}");
                }
            }
          
        }
        public static void Adddata()
        {
        CustomerDetails customer=new CustomerDetails("Ravi","chennai",9885858588,50000,"ravi@mail.com");
        CustomerList.Add(customer);
        CustomerDetails customer1=new CustomerDetails("Baskaran","Chennai",9888475757,60000,"baskaran@mail.com");
        CustomerList.Add(customer1);
        }
        public static void productdata()
        {
            ProductDetails product1=new ProductDetails("MObile",10,10000,3);
            ProductList.Add(product1);
            ProductDetails product2=new ProductDetails("Tablet",5,15000,2);
            ProductList.Add(product2);
            ProductDetails product3=new ProductDetails("Camera",3,20000,4);
            ProductList.Add(product3);
            ProductDetails product4=new ProductDetails("IPhone",5,50000,6);
            ProductList.Add(product4);
            ProductDetails product5=new ProductDetails("Labtop",3,40000,3);
            ProductList.Add(product5);
        }
        public static void orderdata()
        {
            OrderDetails order1=new OrderDetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Oredered);
            OrderDetails order2=new OrderDetails("CID1002","PID103",40000,DateTime.Now,2,OrderStatus.Oredered);
        }
        
    }