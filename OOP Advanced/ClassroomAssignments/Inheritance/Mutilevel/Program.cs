using System;

namespace Multilevel;
class Program
{
    public static void Main(string[] args)
    {
        //Single inheritance
        PersonalDetails personalDetails=new PersonalDetails("Karthi","Thangaraj",Gender.Male,123456789);
        personalDetails.ShowDetails();
        StudentDetails student=new StudentDetails("9192782","Karthi","Thangaraj",Gender.Male,3733983,Department.CSE,"Final");
        student.ShowStudent();
        student.GetMark(90,90,90);
        student.Calculation();
        student.ShowMark();

        //Hierarchical inheritance
        CustomerDetails customer=new CustomerDetails("263876464","Karthi","Thangaraj",Gender.Male,3733983);
         customer.Recharge();
        customer.ShowCustomerDetails();


        //Multilevel
        EmploymentDetails employmentDetails=new EmploymentDetails("SID2001","73673673","karthi","Thangaraj",Gender.Male,6737637,Department.CSE);
        employmentDetails.ShowStudent();
        employmentDetails.GetMark(90,90,90);
        employmentDetails.Calculation();
        employmentDetails.ShowMark();
        employmentDetails.ShowEmploymentDetail();
       

    }
}
