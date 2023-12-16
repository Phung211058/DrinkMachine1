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
        private int timer = 0;
        public Filter()
        {
            Time = 0;
        }
        public bool On()
        {
            TurnOn = true;
            return TurnOn;
        }
        public int Filt(int time)
        {
            Time = time;
            switch (time)
            {
                case 1://oranges
                       //    for (int i = 0; i <= 100; i += 50)
                       //    {
                       //        Console.WriteLine("Filter is filting" + i + "%");
                       //    }
                       //    Console.WriteLine("Filted orange juice" + time + "time");
                    timer += 15;
                    if (timer >= 100) timer = 100;

                    break;
                case 2://watermelon
                    //for (int i = 0; i <= 100; i += 25)
                    //{
                    //    Console.WriteLine("Filter is filting" + i + "%");
                    //}
                    //Console.WriteLine("Filted watermelon juice" + time + "time");
                    timer += 10;
                    if (timer >= 100) timer = 100;

                    break;
                case 3://mango
                    //for (int i = 0; i <= 100; i += 20)
                    //{
                    //    Console.WriteLine("Filter is filting" + i + "%");
                    //}
                    //Console.WriteLine("Filted watermelon juice" + time + "time");
                    timer += 20;
                    if (timer >= 100) timer = 100;
                    break;
            }
            return timer;
        }
        public bool TurnOff()
        {
            TurnOn = true;
            Time = 0;
            return TurnOn;
        }

    }
}