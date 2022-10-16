using System;
using System.Collections.Generic;
namespace SyncfusionCollegeofEngineeringandTechnology;
    public static class Operation
    {
        public static List<StudentDetails> StudentList=new List<StudentDetails>();
        public static List<DepartmentDetails> DepartmentList=new List<DepartmentDetails>();
        public static List<AdmissionDetails> AdmissionList=new List<AdmissionDetails>();
        static StudentDetails currentStudent=null;
        static DepartmentDetails currentDepartment=null;
        static AdmissionDetails currentAdmission=null;
        public static void MainMenu()
        {
            string choice = "yes";
            
            /*string name="Ravichandran E";
            string fathername="Ettapparajan";
            DateTime dob=new DateTime(1999/11/11);
            Gender gender=Gender.Male;
            double physics=95;
            double chemistry=95;
            double maths=95;
            StudentDetails student=new StudentDetails(name,fathername,dob,gender,physics,chemistry,maths);
            StudentList.Add(student);

            
            name="Baskaran S";
            fathername="Sethurajan";
            dob=new DateTime(1999/11/11);
            gender=Gender.Male;
            physics=95;
            chemistry=95;
            maths=95;
            StudentDetails student1=new StudentDetails(name,fathername,dob,gender,physics,chemistry,maths);
            StudentList.Add(student1);

            string departmentname="EEE";
            int  noofseats=29;
            DepartmentDetails department=new DepartmentDetails(departmentname,noofseats);
            DepartmentList.Add(department);

            departmentname="CSE";
            noofseats=29;
            DepartmentDetails department1=new DepartmentDetails(departmentname,noofseats);
            DepartmentList.Add(department1);

            departmentname="MECH";
            noofseats=29;
            DepartmentDetails department2=new DepartmentDetails(departmentname,noofseats);
            DepartmentList.Add(department2);

            departmentname="ECE";
            noofseats=29;
            DepartmentDetails department3=new DepartmentDetails(departmentname,noofseats);
            DepartmentList.Add(department3);*/

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
            } while (choice != "yes");
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

            System.Console.WriteLine("Enter yor Physics mark:");
            double physics = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Chemistry mark:");
            double chemistry = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Maths mark:");
            double maths = double.Parse(Console.ReadLine());


            StudentDetails student2 = new StudentDetails(name, fathername, dob, gender, physics, chemistry, maths);
            StudentList.Add(student2);
            System.Console.WriteLine("Submitted");
            System.Console.WriteLine("Your Register Id is: " + student2.StudentId);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Register Number ");
            string studentid = Console.ReadLine().ToUpper();
            foreach (StudentDetails student in StudentList)
            {
                if (student.StudentId == studentid)
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
                System.Console.WriteLine("/n1.Display Details  /n2.Check Eligibility /n3.Take Admission /n4.Cancel Admission /n5.Show Admission Details /n6.Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Show Details");
                            currentStudent.DisplayDetails();
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
                            System.Console.WriteLine("Take Admission");
                            System.Console.WriteLine("Department details");
                            System.Console.WriteLine("DepartmentId       DepartmentName      NoOfSeats");
                            foreach(DepartmentDetails departments in DepartmentList)
                            {
                                System.Console.WriteLine($"{departments.DepartmentId}                   {departments.DepartmentName}                {departments.NoOfSeats}" );
                            }
                            System.Console.WriteLine("Enter DepartmentId");
                            string departmentid=Console.ReadLine().ToUpper();
                            foreach(DepartmentDetails departments in DepartmentList)
                            {
                                    if(departmentid==departments.DepartmentId)
                                    {        
                                        if(departments.NoOfSeats>0)
                                        {
                                        bool eligible = currentStudent.Checkeligibility(75.0);
                                        if(eligible)
                                        {
                                            bool checkTrue=true;
                                            foreach(AdmissionDetails admission in AdmissionList)
                                            {
                                                if(currentStudent.StudentId==admission.AdmissionId)
                                                {
                                                    if(admission.AdmissionStatus==AdmissionStatus.Admitted)
                                                    {
                                                        checkTrue=false;
                                                    }
                                                }
                                            }
                                            if(checkTrue)
                                            {
                                                AdmissionDetails admission=new AdmissionDetails(currentStudent.StudentId,currentDepartment.DepartmentId,DateTime.Now,AdmissionStatus.Admitted);
                                                AdmissionList.Add(admission);
                                                currentDepartment.NoOfSeats-=1;
                                                System.Console.WriteLine("Admission created Successfully"+admission.AdmissionId);
                                                System.Console.WriteLine("No of Seat"+currentDepartment.NoOfSeats);
                                                SubMenu();
                                            }
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Cancel");
                                            MainMenu();
                                        }
                                        
                                    }
                                }
                                
                            }break;
                        }
                        case 4:
                            {
                                System.Console.WriteLine("Cancel Admission");

                                foreach(AdmissionDetails admission in AdmissionList)
                                {
                                    System.Console.WriteLine("Enter your admission id"+admission.AdmissionId);
                                    if(currentStudent.StudentId==admission.AdmissionId)
                                    {
                                        admission.AdmissionStatus=AdmissionStatus.Cancelled;
                                        foreach(DepartmentDetails department in DepartmentList)
                                        {
                                            if(department.DepartmentId==admission.DepartmentId)
                                            {
                                                System.Console.WriteLine("Admission Cancelled Successfully");
                                                department.NoOfSeats++;
                                                System.Console.WriteLine(department.NoOfSeats);
                                            }
                                        }
                                    }
                                   
                                }
                            }
                            break;
                        
                        case 5:
                        {
                            System.Console.WriteLine("Admission Details");
                            foreach(AdmissionDetails admissions in AdmissionList)
                            {
                                System.Console.WriteLine(admissions.StudentId,admissions.AdmissionDate,admissions.AdmissionStatus);
                            }
                            break;
                        }
                        case 6:
                        {
                            System.Console.WriteLine("Exit from SubMenu and go to main menu");
                            choice="no";
                            break;
                        }
                }
            } while (choice == "yes");
        }
       public static void AddData()
        {
            AdmissionDetails admission=new AdmissionDetails("SF3001","DID101",new DateTime(2022,05,11),AdmissionStatus.Admitted);
            AdmissionList.Add(admission);
            AdmissionDetails admission1=new AdmissionDetails("SF3002","DID102",new DateTime(2022,05,12),AdmissionStatus.Admitted);
            AdmissionList.Add(admission1);
        }    
    }