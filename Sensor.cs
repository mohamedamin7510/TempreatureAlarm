using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempreatureSensor
{
    internal class Sensor
    {
        public  event EventHandler<TempEventArgs> ? SensorChanged;
        

        private double Teampreature;
        /// <summary>
        /// For  changing the teampreature  

        /// </summary>
        /// <param name="newtemp"></param>
        public void SetTeampreature(double newtemp)
        {
            Teampreature = newtemp;
         

            SensorChanged!.Invoke(this , new TempEventArgs() { Tempreature = newtemp});

        }








    }
}
