using System;

namespace SyncfusionCollegeofEngineeringandTechnology;

 public enum AdmissionStatus{Default,Admitted,Cancelled}
public class AdmissionDetails
{
   
        private static int s_admissionId=1000;
        public string AdmissionId{get;}

        private static int s_studentId=3000;
        public string StudentId{get;}

        private static int s_departmentId=100;
        public string DepartmentId{get;}

        public DateTime AdmissionDate{get; set;}

        public AdmissionStatus AdmissionStatus{get; set;}

        public AdmissionDetails(string studentId,string departmentId,DateTime admissionDate,AdmissionStatus admissionStatus)
        {
            s_admissionId++;
            AdmissionId="AID"+s_admissionId;
            s_studentId++;
            StudentId="SF"+s_studentId;
            s_departmentId++;
            DepartmentId="DID"+s_departmentId;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;
        }
        public AdmissionDetails(string data)
        {
            string[] values=data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,3));
            AdmissionId=values[0];
            s_studentId=int.Parse(values[1].Remove(0,2));
            StudentId=values[1];
            s_departmentId=int.Parse(values[2].Remove(0,3));
            DepartmentId=values[2];
            AdmissionDate=DateTime.Parse(values[3]);
            AdmissionStatus=Enum.Parse<AdmissionStatus>(values[4]);
        }
        ~AdmissionDetails()
        {
            System.Console.WriteLine("Destructor Called");
        }
}