using System;

namespace SyncfusionCollegeofEngineeringandTechnology
{
    public class DepartmentDetails
    {
        private static int s_departmentId=100;
        public string DepartmentId{get;}

        public string DepartmentName{get; set;}

        public int NoOfSeats{get; set;}

        public DepartmentDetails(string departmentname,int noofseats)
        {
            s_departmentId++;
            DepartmentId="DID"+s_departmentId;
            DepartmentName=departmentname;
            NoOfSeats=noofseats;
        }
        public DepartmentDetails(string data)
        {
            string[] values=data.Split(',');
            s_departmentId=int.Parse(values[0].Remove(0,3));
            DepartmentId=values[0];
            DepartmentName=values[1];
            NoOfSeats=int.Parse(values[2]);
        }
        ~DepartmentDetails()
        {
            System.Console.WriteLine("Destructor Called");
        }
    }
}