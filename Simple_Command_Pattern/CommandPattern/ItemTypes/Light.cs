using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Light
    {
        public string _lightPlacement;

        public Light(string lightPlacement)
        {
            _lightPlacement = lightPlacement;
        }
        public void On()
        {
            Console.WriteLine($"{_lightPlacement} is ON");
        }

        public void Off()
        {
            Console.WriteLine($"{_lightPlacement} is OFF");
        }

        public void SetNewPlacement(string newPlacement)
        {
            _lightPlacement = newPlacement;
        }
    }
}
