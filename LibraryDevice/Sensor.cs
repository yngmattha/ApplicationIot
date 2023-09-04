
using LibreriaDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIot 
{
    public class Sensor : Iservice
    {
        private int v;

        public Sensor(int v)
        {
            this.v = v;
        }

        public int temperatura { get; set; }
        public int umidità { get; set; }
        public int co2 { get; set; }

        public double MisuraTemperatura()
        {
            var rand = new Random();
            double temperatura = rand.Next(1, 101);
            return temperatura;
        }
        public int MisuraCO2()
        {
            var rand = new Random();
            int co2 = rand.Next(1, 101);
            return co2;
        }

        public int MisuraUmidità()
        {
            var rand = new Random();
            int umidità = rand.Next(1, 101);
            return umidità;
        }

        public void Print()
        {
            Console.WriteLine($"Umidità: {MisuraUmidità()}°C");
            Console.WriteLine($"Temperatura: {MisuraTemperatura()}°C");
            Console.WriteLine($"CO2: {MisuraCO2()} ppm");


        }

        public double MisuraCo2()
        {
            throw new NotImplementedException();
        }

        double Iservice.MisuraUmidità()
        {
            throw new NotImplementedException();
        }
    }
}