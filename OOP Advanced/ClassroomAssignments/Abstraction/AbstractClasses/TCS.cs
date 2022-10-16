namespace AbstractClasses
{
    public class TCS:AbstractBase
    {
        public override string Name {get{return name;}  set{name=value;}} //Abstract Method definition

        public override void Salary(int dates)
        {
            Display();
            Amount=(double)dates*300;
            System.Console.WriteLine(Amount);
        }
    }
}