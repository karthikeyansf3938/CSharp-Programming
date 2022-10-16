using System;

namespace Multilevel
{
    public class EmploymentDetails : StudentDetails
    {
        private static int s_empId=2000;
        public string EmployeeId{get;}

        public DateTime RegisterationDate{get; set;}

        public EmploymentDetails(string studentId,string aadharId,string name,string fatherName,Gender gender,long phone,Department department):base(studentId,aadharId,name,fatherName,gender,phone,department)
        {
            s_empId++;
            EmployeeId="EID"+s_empId;
            RegisterationDate=DateTime.Now;
        }
        public void ShowEmploymentDetail()
        {
            System.Console.WriteLine("Employee Id"+EmployeeId);
            ShowStudent();
            System.Console.WriteLine("Registration Date"+RegisterationDate.ToString("dd/MM/yyyy"));
        }
    }
}