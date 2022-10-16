using System;
using System.Collections.Generic;
namespace FilterDeligates;
public delegate bool FilterDelegate(Person p); //Our delegate
class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person() {Name = "John", Age = 41};
        Person person2 = new Person() {Name = "Karthi", Age = 22};
        Person person3 = new Person() {Name = "Sundar", Age = 35};
        Person person4 = new Person() {Name = "Pichai", Age = 68};
        Person person5 = new Person() {Name = "Jemini", Age = 10};
        Person person6 = new Person() {Name = "Ganesan", Age = 12};

        List<Person> PersonList = new List<Person>(){person1,person2,person3,person4,person5,person6};


        DisplayPeople("Children",PersonList,IsChild);
        DisplayPeople("Children",PersonList,IsAdult);
        DisplayPeople("Children",PersonList,IsVoter);
        DisplayPeople("Children",PersonList,IsSenior);
    }
    static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
    {
        Console.WriteLine($"\nPeople in {title} list are :");
        foreach (Person peoples in people)
        {
            if(filter(peoples))
            {
                Console.WriteLine($"\t{peoples.Name} is {peoples.Age} years old");
            }
        }
    }
     static bool IsChild(Person peoples)
    {
        return peoples.Age<15;
    }
    static bool IsVoter(Person peoples)
    {
        return peoples.Age >= 18;
    }
    static bool IsAdult(Person peoples)
    {
        return peoples.Age>=18 && peoples.Age<=50;
    }
    static bool IsSenior(Person peoples)
    {
        return peoples.Age>=50;
    }
}
