using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempreatureSensor
{
    internal class Alarm
    {
        public int alarmedvalue { get; init; }

      

        public  void alarmfiring(object? obj, TempEventArgs? boom)
        {

            var sensor = obj as Sensor;
            Sensor s = new Sensor ();
            if (boom.Tempreature > alarmedvalue)
            {

                Console.WriteLine($"Watch out the degree above {alarmedvalue}");

            }

        }

    }
}
