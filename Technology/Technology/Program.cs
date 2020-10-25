using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop hp = new Laptop("Laptop1", "HP", 2, false);
            Smartphone apple = new Smartphone("Smartphone1", true, 15, true);

            hp.CheckBatteryLevel();
            apple.CheckBatteryLevel();
            apple.AnswerPhone(true);
            hp.DisplayInfo(hp);
            apple.DisplayInfo(apple);

        }
    }
}
