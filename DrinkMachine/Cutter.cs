using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class Cutter
    {

        public int Material { get; set; }
        private bool TurnOn;
        private int time = 0;
        public Cutter()
        {
            this.TurnOn = false;
            this.Material = 0;

        }
        public bool On()
        {
            return this.TurnOn = true;
        }
        public int Cut(int material)
        {
            switch (material)
            {
                case 1://Orange
                    time += 5;
                    if (time >= 100) time = 100;
                    break;
                case 2://Watermelon
                    time += 12;
                    if (time >= 100) time = 100;
                    break;
                case 3: //Mango
                    time += 8;
                    if (time >= 100) time = 100;
                    break;
            }
            return time;
        }
        public void returnTimer()
        {
            time = 0;
        }
        public bool Off() { 
                TurnOn = false;
            return TurnOn;

        }
    }
}