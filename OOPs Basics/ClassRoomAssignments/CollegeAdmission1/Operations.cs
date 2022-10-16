using System;
using System.Collections.Generic;
namespace CollegeAdmission1
{
    public static class Operations
    {
        static List<StudentDetails> StudentList = new List<StudentDetails>();
        static StudentDetails currentStudent = null;

        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option \n1.Registration \n2.Login \n3.Exit");
                int Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Registration");
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Login");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit");
                            choice = "no";
                            break;
                        }
                }
            } while (choice == "yes");
        }

        public static void Registration()

        {


            System.Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter your Father name:");
            string fathername = Console.ReadLine();

            System.Console.WriteLine("Enter your Date of birth:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            System.Console.WriteLine("Enter your gender:");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            System.Console.WriteLine("Enter your Phone number:");
            long phonenumber = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Mail:");
            string mail = Console.ReadLine();

            System.Console.WriteLine("Enter yor Physics mark:");
            int physics = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Chemistry mark:");
            int chemistry = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Maths mark:");
            int maths = int.Parse(Console.ReadLine());


            StudentDetails student = new StudentDetails(name, fathername, dob, gender, phonenumber, mail, physics, chemistry, maths);
            StudentList.Add(student);
            System.Console.WriteLine("Submitted");
            System.Console.WriteLine("Your Register Id is: " + student.RegisterNumber);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Register Number ");
            string registernumber = Console.ReadLine().ToUpper();
            foreach (StudentDetails student in StudentList)
            {
                if (student.RegisterNumber == registernumber)
                {
                    System.Console.WriteLine("Login Sucessfull");
                    currentStudent = student;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Submenu option:");
                System.Console.WriteLine("/n1.Show Details /2.Check Eligibility /3.Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Show Details");
                            currentStudent.ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Check Eligibility");
                            bool eligible = currentStudent.Checkeligibility(75.0);
                            if (eligible)
                            {
                                System.Console.WriteLine("Yor are eligible for an admission");
                            }
                            else
                            {
                                System.Console.WriteLine("You are not eligible for an admission");
                            }
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit Submenu");
                            choice = "no";
                            break;
                        }
                }
            } while (choice == "yes");
        }
    }
}