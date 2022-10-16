using System;
using System.Collections.Generic;

namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        List<PersonalInfo> PersonList=new List<PersonalInfo>();
        List<StudentInfo> StudentList=new List<StudentInfo>();

        PersonalInfo person=new PersonalInfo("Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male);
        PersonList.Add(person);
        PersonalInfo person1=new PersonalInfo("Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male);
        PersonList.Add(person1);
        PersonalInfo person2=new PersonalInfo("Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male);
        PersonList.Add(person2);
        PersonalInfo person3=new PersonalInfo("Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male);
        PersonList.Add(person3);
        foreach (PersonalInfo persons in PersonList)
        {
            persons.ShowInfo();
        }
        StudentInfo student=new StudentInfo("SID1001","Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male,12,"CSE","2011");
        StudentList.Add(student);
        StudentInfo student1=new StudentInfo("SID1001","Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male,12,"CSE","2011");
        StudentInfo student2=new StudentInfo("SID1001","Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male,12,"CSE","2011");
        StudentInfo student3=new StudentInfo("SID1001","Karthi","Thangaraj",7010390886,"Karthi@gmail.com",Gender.Male,12,"CSE","2011");
        StudentList.Add(student1);
        StudentList.Add(student2);
        StudentList.Add(student3);
        foreach (StudentInfo students in StudentList)
        {
            students.UpdateInfo();
        }

    }
}