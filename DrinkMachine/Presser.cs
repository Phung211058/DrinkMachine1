using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class Presser
    {
        private int Time { get; set; }
        public bool TurnOn;
        private int timer = 0;
        public Presser()
        {
            TurnOn = false;
            Time = 0;
        }
        public bool On()
        {
            TurnOn = true;
            return TurnOn;

        }
        public int Press(int time)
        {
            this.Time = time;
            switch (time)
            {
                case 1://oranges 
                    //for (int i = 100; i <= 100; i++)
                    //{
                    //    Console.WriteLine("Presser is pressing" + i + "%");
                    //}
                    //Console.WriteLine("Successfull Press Orange");
                    timer += 15;
                    if (timer >= 100) timer = 100;

                    break;
                case 2://watermelon
                    //for (int i = 0; i <= 100; i += 50)
                    //{
                    //    Console.WriteLine("Presser is pressing" + i + "%");
                    //}
                    //Console.WriteLine("Successful Press Watermelon");
                    timer += 10;
                    if (timer >= 100) timer = 100;
                    break;
                case 3://mango
                    //for (int i = 0; i <= 100; i += 20)
                    //{
                    //    Console.WriteLine("Presser is pressing" + i + "%");
                    //}
                    //Console.WriteLine("Successful Press Mango");
                    timer += 20;
                    if (timer >= 100) timer = 100;
                    break;
            }
            return timer;
        }
        public bool Off()
        {
            TurnOn = false;
            Time = 0;
            return TurnOn;
        }
    }
}