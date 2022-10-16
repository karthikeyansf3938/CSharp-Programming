using System;
namespace RunTime;
class Dog : Animal
{
    //seale method
    public override void MakeSound()
    {
        System.Console.WriteLine("Dog sound");
    }
}