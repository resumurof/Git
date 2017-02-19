using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Joe Smith";

            var alarm = new AlarmClock();

            alarm.alarmclockeventhandler += person.HandleAlarm;

            //Step 6 - Causing the event to occur
            alarm.Alarm();


            //Anonymous Function
            string mid = ", middle part,";
            Func<string, string> anonymousDelegate = delegate (string param)
            {
                param = param + mid;
                param = param + " and this was added to the string.";
                return param;
            };

            Console.WriteLine(anonymousDelegate("Start of string"));

        }
    }


    // Step 4 - Creating code that should occur when the event happens
    public class Person
    {
        public string name { get; set; }

        public void HandleAlarm(object sender, AlarnEvntClock e)
        {
            Console.WriteLine("Get out of bed it's {0}", e.datetime);
        }

    }

    // Step 3 - Declaring the code for the event
    public class AlarmClock
    {
        public event AlarmClockEventHandeler alarmclockeventhandler;

        public void Alarm()
        {
            if (alarmclockeventhandler != null)
            {
                alarmclockeventhandler(this, new AlarnEvntClock(DateTime.Now));
            }
        }
    }

    // Step 2 - Setting up the delegate for the event
    public delegate void AlarmClockEventHandeler(object source, AlarnEvntClock e);

    // Step 1 - Creating a class to pass arguments for the event handlers 	
    public class AlarnEvntClock : EventArgs
    {
        public DateTime datetime { get; set; }

        public AlarnEvntClock(DateTime dt)
        {
            this.datetime = dt;
        }
    }

}
