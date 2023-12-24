using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachineLibrary
{
    public class Cleanser
    {
        private bool turnOn;
        private int Water;
        private int time = 0;
        public Cleanser()
        {
            turnOn = false;
            this.Water = 0;
        }
        public bool On()
        {
            turnOn = true;
            return turnOn;
        }
        public int Clean(bool turnon, int water)
        {

            this.turnOn = turnon;
            this.Water = water;
            time += 6;
            if (time >= 100) time = 100;
            return time;
        }
        public bool Off()
        {
            this.turnOn = false;
            this.Water = 0;
            return turnOn;
        }
        public void returnTimer()
        {
            time = 0;
        }
    }
}