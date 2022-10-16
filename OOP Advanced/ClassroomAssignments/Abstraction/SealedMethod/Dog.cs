using System;
namespace SealedMethod;
class Dog : Animal
{
    //seale method
    public new void MakeSound()
    {
        System.Console.WriteLine("Dog sound");
    }
}