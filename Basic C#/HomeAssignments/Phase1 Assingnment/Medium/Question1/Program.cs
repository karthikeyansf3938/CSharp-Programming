using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a basic salary:");
            double basicsalary=double.Parse(Console.ReadLine());
            double Hr, Da,tax,insurance;
            if(basicsalary<=10000)
            {
                Hr=(basicsalary/100)*20;
                Da=(basicsalary/100)*80;
                tax=(basicsalary/100)*6;
                insurance=(basicsalary/100)*1;
                double monthlysalary=basicsalary+Hr+Da;
                double annualsalary=(monthlysalary*12)-(tax*12)-(insurance*12);
                System.Console.WriteLine($"Take home salary : {+monthlysalary}\n Annual Salary : {+annualsalary}");
            }
            else if(basicsalary>10000 && basicsalary<=20000)
            {
                Hr=(basicsalary/100)*25;
                Da=(basicsalary/100)*90;
                tax=(basicsalary/100)*6;
                insurance=(basicsalary/100)*1;
                double monthlysalary=basicsalary+Hr+Da-tax-insurance;
                double annualsalary=monthlysalary*12;
                System.Console.WriteLine($"Take home salary : {+monthlysalary}\n Annual Salary : {+annualsalary}");
            }
            else if(basicsalary>20000)
            {
                Hr=(basicsalary/100)*30;
                Da=(basicsalary/100)*95;
                tax=(basicsalary/100)*6;
                insurance=(basicsalary/100)*1;
                double monthlysalary=basicsalary+Hr+Da-tax-insurance;
                double annualsalary=monthlysalary*12;
                System.Console.WriteLine($"Take home salary : {+monthlysalary}\n Annual Salary : {+annualsalary}");
            }
        }
    }
}