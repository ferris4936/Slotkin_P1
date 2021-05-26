using System;  

namespace Slotkin_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.TestCelsiusToKelvin();
        }

        static double CelsiusToKelvin(double celsius)
        {
            double kelvin = celsius + 273.15;
            return kelvin;   
        }

        static void TestCelsiusToKelvin()
        {
            double kelvin = Program.CelsiusToKelvin(0.0);
            Console.WriteLine("CelsiusToKelvin(0.0) => {0}", kelvin);
        }
    }
}
;
