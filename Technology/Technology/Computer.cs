using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer
    {
        public string Name { get; set; }
        public double BatteryLevel { get; set; }
        public bool PluggedIn { get; set; }

        public Computer(string name, double batteryLevel, bool pluggedIn = false)
        {
            Name = name;
            BatteryLevel = batteryLevel;
            PluggedIn = pluggedIn;
        }

        public void CheckBatteryLevel()
        {
                if (BatteryLevel < 20 && !PluggedIn)
                {
                    PluggedIn = true;
                    Console.WriteLine("Battery Level is: {0}, so i plugged in your device", BatteryLevel);
                } 
            else
            {
                Console.WriteLine("Battery Level is: {0}", BatteryLevel);
            }
            
        }

        
    }
}
