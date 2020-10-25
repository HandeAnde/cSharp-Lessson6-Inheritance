using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Smartphone : Computer
    {
        public bool IsRinging { get; set; } = false;

        public Smartphone(string name, bool isRinging, double batteryLevel, bool pluggedIn) : base(name, batteryLevel, pluggedIn)
        {
            IsRinging  = isRinging;
        }

        public void AnswerPhone(bool ringing)
        {
            if (IsRinging)
            {
                Console.WriteLine("Hello, you called");
            }
        }

        public void DisplayInfo(Smartphone info)
        {
            Console.WriteLine("Name: {0}, Battery Level: {1}, Plugged In: {2}, Is phone Ringing: {3}", info.Name, info.BatteryLevel, info.PluggedIn, info.IsRinging);
        }
    }
}
