using System;
namespace Event
{
    public delegate void EventManager(); //user defined delegate
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink=null;//User defined event
        static int i;
        public Events(string eventName)
        {
            _eventName=eventName;
        }
        public static void HandleEvent() //event triggering method //static method
        {
            i=1;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Start the folloeing events");
            eventlink(); //event trigger ->like clicking a button
        }
        public void Showevent() //Non static method //Explanation about the button click action.
        {
            Console.WriteLine($"Event No : {i++} is {_eventName} Started"); 
        }
    }
}