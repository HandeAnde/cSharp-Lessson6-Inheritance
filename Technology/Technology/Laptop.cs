using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Laptop : Computer
    {
        public string Brand { get; set; }

        public Laptop (string name, string brand, double batteryLevel, bool pluggedIn) :base(name, batteryLevel, pluggedIn)
        {
            Brand = brand;
        }
        public void DisplayInfo(Laptop info)
        {
            Console.WriteLine("Name: {0}, Brand: {1}, Battery Level: {2}, Plugged In: {3}", info.Name, info.Brand, info.BatteryLevel, info.PluggedIn);
        }
    }
}
