using System;
namespace Event;
class Program
{
    public static void Main(string[] args)
    {
        Events event1 = new Events("Quiz");
        Events event2 = new Events("Debugging");
        Events event3 = new Events("Presentation");
        Events event4 = new Events("Games");

        //Eveent registration by management
        //Subscribe to events
        //Calling events via eventlink before we call over deligates
        Events.eventlink += new EventManager(event1.Showevent);
        Events.eventlink += new EventManager(event2.Showevent);
        Events.eventlink += new EventManager(event3.Showevent);
        Events.eventlink += new EventManager(event4.Showevent);

        Events.HandleEvent(); //Process initiation

        //Event Cancellation / Deregistration
        //unsubscribe to events
        Events.eventlink -=new EventManager(event3.Showevent);
        Events.HandleEvent();
    }
}