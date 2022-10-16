using System;
namespace EmployeeMent;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails personalDetails=new PersonalDetails("Karthi","Thangaraj",Gender.Male,123456789);
        personalDetails.ShowDetails();

    }
}
