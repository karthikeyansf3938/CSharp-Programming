using System;
namespace Multiple;
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
       

    }
}
