using System;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// namesapce name
/// </summary>
namespace CollegeAdmission1
{
    /// <summary>
    /// Used to select student's gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// used to collect the student details
    /// </summary>
    public class StudentDetails
    {
        /// <summary>
        /// Static field used to collect the student details
        /// <see student/> class
        /// </summary>
        private static int s_registernumber=3000;
       /// <summary>
        /// Used to to get the unique id number to identify the student
        /// </summary>
        
        public string RegisterNumber{get;}
        /// <summary>
        /// Used to get the student name
        /// </summary>
        public string Name { get; set; }//Auto property
        /// <summary>
        /// Property father name used to provide father name for the object 
        /// </summary>

        public string FatherName { get; set; }
        /// <summary>
        /// Property date of birth used to provide date of birth for the object 
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Property gender used to provide gender for the object 
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property phone number used to provide phone number for the object 
        /// </summary>
        public long Phone { get; set; }
        /// <summary>
        /// Property mail used to provide mail for the object 
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Property physics used to provide physics for the object 
        /// </summary>
        public double Physics { get; set; }
        /// <summary>
        /// Property chemistry mark used to provide chemistry mark for the object 
        /// </summary>
        public double Chemistry { get; set; }
        /// <summary>
        /// Property Maths used to provide Maths for the object 
        /// </summary>
        /// <value></value>
        public double Maths { get; set; }
        /// <summary>
        /// constructor of <see cref="StudentDetails" /> Clas used to initialize values to its properties
        /// </summary>
        /// <param name="name">Parameter name used to initialize a Student's Name to Name property</param>
        /// <param name="fathername">Parameter father name used to initialize a Student's Father Name to Name property</param>
        /// <param name="dob">Parameter dob used to initialize a Student's DOB to DOB property</param>
        /// <param name="gender">Parameter gender used to initialize a Student's Gender to Gender property</param>
        /// <param name="phonenumber">Parameter phonenumber used to initialize a Student's PhoneNumber to PhoneNumber property</param>
        /// <param name="mail">Parameter mail used to initialize a Student's Mail to Mail property</param>
        /// <param name="physics">Parameter physics mark used to initialize a Student's PhysicsMark to PhysicsMark property</param>
        /// <param name="chemistry">Parameter Chemistry mark used to initialize a Student's ChemistryMark to ChemistryMark   property</param>
        /// <param name="maths">Parameter mathsmark  used to initialize a Student's MathsMark  to MathsMark  property</param>

        public StudentDetails(string name,string fathername,DateTime dob,Gender gender,long phonenumber,string mail,double physics,double chemistry,double maths) 
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            Phone=phonenumber;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        /// <summary>
        /// Method to show the details of the object
        /// </summary>
        public void ShowDetails()
        {
            
            System.Console.WriteLine("\nStudent Details");
            System.Console.WriteLine("Your Name is :"+Name);
            System.Console.WriteLine("Your Father name is :"+FatherName);
            System.Console.WriteLine("Your Date of birth is :"+DOB);
            System.Console.WriteLine("Your Gender is :"+Gender);
            System.Console.WriteLine("Your Phone number is :"+Phone);
            System.Console.WriteLine("Your Mail id is :"+Mail);
            System.Console.WriteLine("Your Physics mark is :"+Physics);
            System.Console.WriteLine("Your Chemistry mark is :"+Chemistry);
            System.Console.WriteLine("Your Maths mark is :"+Maths);
        }
        /// <summary>
        /// Method to check the eligibility of the object
        /// If cut off was less than 75 then it's result is object isn't eligible for the admission else it's result is object is eligible for admission
        /// </summary>
        /// <param name="cutoff">Used to calculate the cutoff and it's shows the eligible or not</param>
        /// <returns></returns>
        public bool Checkeligibility(double cutoff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if(average<=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ~StudentDetails()//destructor
        {

        }
        
    }
}