using System;
namespace Question3
{
    public class Attendance
    {
        public DateTime Date{get; set;}
        public double NumberOfHoursWorked{get; set;}

        public Attendance(DateTime date,double noofHoursWorked)
        {
            Date=date;
            NumberOfHoursWorked=noofHoursWorked;
        }
    }
}