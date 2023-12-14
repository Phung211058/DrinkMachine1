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
        public Cleanser()
        {
            turnOn = false;
            Water = 0;
        }
        public bool On()
        {
            return this.turnOn = true;
        }
        public void Clean()
        {

           
            Console.WriteLine("Fruit is being soaked in  ml water");
            for (int i = 0; i <= 100; i += 50)
            {
                Console.WriteLine("Cleanser is cleaning" + i + "%");
            }
            Console.WriteLine("Cleaned");

        }
        public bool Off()
        {
            return this.turnOn = false;
            this.Water = 0;
        }
    }
}