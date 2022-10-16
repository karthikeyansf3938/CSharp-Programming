using System;
namespace AbstractClasses
{
    public class Syncfusion : AbstractBase
    {
        public override string Name {get{return name;}  set{name=value;}} //Abstract Method definition

        public override void Salary(int dates)
        {
            Display();
            Amount=(double)dates*500;
            System.Console.WriteLine(Amount);
        }
    }
}