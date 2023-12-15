using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class Filter
    {
        public int Time { get; set; }
        public bool TurnOn;
        public Filter()
        {
            Time = 0;
        }
        public bool On()
        {
            return this.TurnOn = true;
        }
        public void Filt(int time)
        {
            this.Time = time;
            switch (time)
            {
                case 1:
                    for (int i = 0; i <= 100; i += 20)
                    {
                        Console.WriteLine("Filter is filting " + i + "%");
                    }
                    Console.WriteLine("Filted orange juice " + time + " time");
                    break;
                case 2:
                    for (int i = 0; i <= 100; i += 20)
                    {
                        Console.WriteLine("Filter is filting " + i + "%");
                    }
                    Console.WriteLine("Filted watermelon juice " + time + " time");
                    break;
            }
        }
        public bool TurnOff()
        {
            this.Time = 0;
            return this.TurnOn = false;
        }

    }
}