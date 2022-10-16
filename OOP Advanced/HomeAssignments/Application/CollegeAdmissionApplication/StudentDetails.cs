using System;
namespace SyncfusionCollegeofEngineeringandTechnology;

    public enum Gender{Default,Male,Feamle,Transgender}
    public class StudentDetails
    {
        private static int s_studentId=3000;
        public string StudentId{get;}
        

        public string Name { get; set; }

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public double Physics { get; set; }

        public double Chemistry { get; set; }

        public double Maths { get; set; }

        public StudentDetails(string name,string fathername, DateTime dob,Gender gender,double physics,double chemistry,double maths)
        {
            s_studentId++;
            StudentId="SF"+s_studentId;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
         public StudentDetails(string data)
        {
            string[] values = data.Split(',');
            s_studentId=int.Parse(values[0].Remove(0,2));
            StudentId=values[0];
            Name=values[1];
            FatherName=values[2];
            DOB=DateTime.Parse(values[3]);
            Gender=Enum.Parse<Gender>(values[4]);
            Physics=double.Parse(values[5]);
            Chemistry=double.Parse(values[6]);
            Maths=double.Parse(values[7]);
        }
        ~StudentDetails()
        {
            System.Console.WriteLine("Destructor Called");
        }
        public void DisplayDetails()
        {
            System.Console.WriteLine("\nStudent Details");
            System.Console.WriteLine("Your Name is :"+Name);
            System.Console.WriteLine("Your Father name is :"+FatherName);
            System.Console.WriteLine("Your Date of birth is :"+DOB.ToShortDateString());
            System.Console.WriteLine("Your Gender is :"+Gender);
            System.Console.WriteLine("Your Physics mark is :"+Physics);
            System.Console.WriteLine("Your Chemistry mark is :"+Chemistry);
            System.Console.WriteLine("Your Maths mark is :"+Maths);
        }
        public bool Checkeligibility(double cutoff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if(average<=cutoff)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
        
