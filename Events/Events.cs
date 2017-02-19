using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate listeners
            Police police = new Police();
            Fire fire = new Fire();
            Ambulance ambulance = new Ambulance();

            Call911 call911 = new Call911();
            call911.callforhelp += police.OnCallTo911;
            call911.callforhelp += fire.OnCallTo911;
            call911.callforhelp += ambulance.OnCallTo911;

            call911.CreateNotification("250 Humber Blvd.  - John Hinz - HELP - Crazy Students!!!!! ");
        }
    }

    public class Police
    {
        // Police listner
        public void OnCallTo911(Object sender, EmergencyInfo e)
        {
            Console.WriteLine("There is a Police call from " + e.address);
        }
    }

    public class Fire
    {
        // Fire listner
        public void OnCallTo911(Object sender, EmergencyInfo e)
        {
            Console.WriteLine("There is a Fire call from " + e.address);
        }
    }

    public class Ambulance
    {
        // Ambulance listner - signature must match event and delegate
        public void OnCallTo911(Object sender, EmergencyInfo e)
        {
            Console.WriteLine("There is a Ambulance call from " + e.address);
        }
    }

    public class Call911
    {
        public event EmergencyEvent callforhelp;

        public void CreateNotification(string msg)
        {
            if (callforhelp != null)
            {
                callforhelp(this,  new EmergencyInfo(msg));
            }
        }
       
    }

     public delegate void EmergencyEvent(Object sender, EmergencyInfo info);
    // event information (holds address passed to listeners)
    public class EmergencyInfo : EventArgs
    {
        public string address { get; set; }

        public EmergencyInfo( string Address)
        {
            this.address = Address;
        }
    }
}
