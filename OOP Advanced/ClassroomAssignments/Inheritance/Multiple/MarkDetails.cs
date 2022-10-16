namespace Multiple
{
    public interface IMarkDetails//interface always start with prefic "I"
    {
        //No field
        double Physics { get; set; }//Property declaration is only allowed
        double Chemistry{get; set;}

        double Maths{get; set;}

        double Total{get; set;}

        double Average{get; set ;}

        //No constructor and Object

        void Calculation(); //Method Declaration allowed
        void GetMark(double physics,double chemistry,double maths);
        void ShowMark();
    }
}