using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit
{
    internal class EventHandler
    {
        // Define a Delegate first
        public delegate void MyEventHandler(object sender, EventArgs e);

        //declare an event using delegate
        public class Publisher
        {
            public event MyEventHandler MyEventHandler;

            //raise the event
            protected virtual void OnMyEvent()
            {
                if (MyEventHandler != null)
                {
                    MyEventHandler(this, EventArgs.Empty);
                }
            }

            public void DoSomething()
            {
                OnMyEvent();
            }
        }

        //class to subscribe to the event and defines the event handler method
        public class Subscriber
        {
            private readonly Publisher _publisher;
            public Subscriber(Publisher publisher)
            {
                _publisher = publisher;
                _publisher.MyEventHandler += HandleMyEvent;
            }

            private void HandleMyEvent(object sender, EventArgs e)
            {
                Console.WriteLine("Event Recieved !!");
            }
        }

        // handle the event
        public class program
        {
            // when "DoSomething" method is calles on the "Publisher" object, it raises the event and the "Handle MyEvent" method in the "Subscriber" object is called
            public static void Main(string[] args)
            {
                Publisher publisher = new Publisher();
                Subscriber subscriber = new Subscriber(publisher);

                publisher.DoSomething();
            }
        }
    }
}
