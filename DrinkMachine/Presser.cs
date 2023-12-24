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
                    timer += 5;
                    if (timer >= 100) timer = 100;
                    break;
                case 2://watermelon
                    timer += 8;
                    if (timer >= 100) timer = 100;
                    break;
                case 3://mango
                    timer += 12;
                    if (timer >= 100) timer = 100;
                    break;
            }
            return timer;
        }
        public void returnTimer()
        {
            timer = 0;
        }
        public bool Off()
        {
            TurnOn = false;
            Time = 0;
            return TurnOn;
        }
    }
}