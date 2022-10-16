using System;
using System.IO;

namespace SyncfusionCollegeofEngineeringandTechnology
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                Console.WriteLine($"Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("College/StudentDetails.csv");
            }
             if(!File.Exists("College/DepartmentDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                Console.WriteLine($"Creating File");
                File.Create("College/AdmissionDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");
            string[] departments=File.ReadAllLines("College/DepartmentDetails.csv");
            string[] admissions=File.ReadAllLines("College/AdmissionDetails.csv");
            
            foreach(String data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operation.StudentList.Add(student);
            }
             foreach(String data in departments)
            {
                DepartmentDetails department=new DepartmentDetails(data);
                Operation.DepartmentList.Add(department);
            }
             foreach(String data in admissions)
            {
                AdmissionDetails admission=new AdmissionDetails(data);
                Operation.AdmissionList.Add(admission);
            }
        }
        public static void WriteToFiles()
        {
            string[] studentDetails = new string[Operation.StudentList.Count];
            string[] departmentDetails = new string[Operation.DepartmentList.Count];
            string[] admissionDetails = new string[Operation.AdmissionList.Count];
            for(int i=0;i<Operation.StudentList.Count;i++)
            {
                studentDetails[i]=Operation.StudentList[i].StudentId+","+Operation.StudentList[i].Name+","+Operation.StudentList[i].FatherName+","+Operation.StudentList[i].DOB+","+Operation.StudentList[i].Gender+","+Operation.StudentList[i].Physics+","+Operation.StudentList[i].Chemistry+","+Operation.StudentList[i].Maths;
            }
             for(int i=0;i<Operation.DepartmentList.Count;i++)
            {
                departmentDetails[i]=Operation.DepartmentList[i].DepartmentId+","+Operation.DepartmentList[i].DepartmentName+","+Operation.DepartmentList[i].NoOfSeats;
            }
             for(int i=0;i<Operation.AdmissionList.Count;i++)
            {
                admissionDetails[i]=Operation.AdmissionList[i].AdmissionId+","+Operation.AdmissionList[i].StudentId+","+Operation.AdmissionList[i].DepartmentId+","+Operation.AdmissionList[i].AdmissionDate+","+Operation.AdmissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);
            File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);
            File.WriteAllLines("College/AdmissionDetails.csv",admissionDetails);
        }
        
    }
}