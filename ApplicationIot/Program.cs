

using ApplicationIot;
using LibreriaDevices;
using System;
using System.Collections.Generic;

namespace AppIot
{
    public class Program
    {
        static void Main(string[] args)
        {


            Device entry = new Device()
            {
                Model = "Entry",
                Sensors = new List<Sensor>
                {
                    new Sensor(1)
                }

            };

            Device pro1 = new Device()
            {
                Model = "Pro1",
                Sensors = new List<Sensor>()
                {
                    new Sensor(1),
                    new Sensor(2),
                    new Sensor(3),
                    new Sensor(4)
                }

            };

            Device pro2 = new Device()
            {
                Model = "Pro2",
                Sensors = new List<Sensor>()
                {
                    new Sensor(1),
                    new Sensor(2),
                    new Sensor(3),
                    new Sensor(4)
                }

            };

            Device Super = new Device()
            {
                Model = "Super",
                Sensors = new List<Sensor>()
                {
                    new Sensor(1),
                    new Sensor(2),
                    new Sensor(3),
                    new Sensor(4),
                    new Sensor(5),
                    new Sensor(6),
                    new Sensor(7),
                    new Sensor(8),
                }
                
            };
            foreach (var i in Sensor)
            {
                i.MisuraTemperatura();
            }
            

        }
    }

}


    

