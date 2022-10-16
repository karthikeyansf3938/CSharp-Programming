using System;
namespace PartialClass;

    public enum Gender{Default,Male,Feamle,Transgender}
    public  enum Department{Default,CSE,ECE,EEE}
    public partial class StudentDetails
    {
        private static int s_id=3000;
        public string StudentId{get;}
        public Department Department{get; set;}

        public string Year{get; set;}
        public double Physics { get; set; }//Property declaration is only allowed
        public double Chemistry{get; set;}

        public double Maths{get; set;}

        public double Total{get; set;}

        public double Average{get; set ;}
    }
    