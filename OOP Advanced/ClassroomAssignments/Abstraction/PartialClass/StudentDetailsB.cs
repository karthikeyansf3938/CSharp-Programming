namespace PartialClass
{
    public partial class StudentDetails
    {
         public void Calculation()
            {
                Total=Physics+Chemistry+Maths;
                Average=Total/3.0;
            }
            public void ShowMark()
            {
                System.Console.WriteLine($"Chemistry : {Chemistry}\nPhysics : {Physics}\n Maths : {Maths}");
                Console.WriteLine($"Total : {Total}\nAverage : {Average}");
                
            }
            public void ShowStudent()
            {
                System.Console.WriteLine($"Student Id : {StudentId}");
                ShowDetails();
                System.Console.WriteLine($"Department : {Department}\n year : {Year}");
            }
             public void GetMark(double physics,double chemistry,double maths)
            {
                Physics=physics;
                Chemistry=chemistry;
                Maths=maths;
            }
    }
}