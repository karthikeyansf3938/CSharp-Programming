namespace AbstractClasses;

public abstract class AbstractBase //Abstract Class
{
    protected string name; //Normal Field
    public abstract string Name{get; set;} //Abstract Property

    public double Amount{get; set;}// normal property

    public void Display() //Normal method
    {
        System.Console.WriteLine(name);
    }
    public abstract void Salary(int dates);   //Abstract Method
    
}
